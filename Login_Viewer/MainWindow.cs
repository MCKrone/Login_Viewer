using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Viewer.Login_Content;
using static System.Windows.Forms.ListView;

namespace Login_Viewer
{
    public partial class MainWindow : Form
    {
        private Content content;
        private EditListView editLV;
        private TmpInfo infos;
        private bool firstItemSelected, cancelSearch;
        private UseXML xml;
        private UseTrueCrypt tc;
        private Button lastOrderB;

        public MainWindow()
        {        
            InitializeComponent();

            firstItemSelected = false;
            cancelSearch = false;

            gBoxLogs.Enabled = false;
            gBoxFavs.Enabled = false;

            infos = TmpInfo.Instance;

            new Settings().loadSettings();            

            editLV = new EditListView();
            editLV.addGroups(new ListView[] { lViewLogs, lViewFavorites});

            xml = new UseXML();
            tc = new UseTrueCrypt();

            content = new Content(this);
            content.Dock = DockStyle.Fill;
            pCustomAction.Controls.Add(content);

            lastOrderB = btOrderGroups;
            lastOrderB.FlatAppearance.BorderSize = 2;    

            Thread.Sleep(2000);
        }

        public void updateListItem(LoginObject log)
        {      
            //update lViewLog
            editLV.updateItem(lViewLogs, log);

            //update lViewFav -> JA=Update | NEIN= gab es mich vorher? -> löschen : nichts
            if (log.Fav)
                editLV.updateItem(lViewFavorites, log);
            else
                editLV.removeItem(lViewFavorites, log.ID.ToString());

            lViewLogs.Refresh();
        }

        public void removeListItem(LoginObject log)
        {
            firstItemSelected = false;

            //remove from lViewLog
            editLV.removeItem(lViewLogs, log.ID.ToString());

            //update lViewFav -> JA=Update | NEIN= gab es mich vorher? -> löschen : nichts
            if (log.Fav)
                editLV.removeItem(lViewFavorites, log.ID.ToString());            
        }

        public void resetSearch()
        {
            cancelSearch = true;

            textBoxSearch.Text = "Search...";
            lViewLogs.Items.Clear();
            lViewLogs.Items.AddRange(editLV.addList(lViewLogs));

            cancelSearch = false;
        }

        public void setActive(bool state)
        {
            this.Enabled = state;
        }

        public void login()
        {  
            fillListViews();

            if (checkUpdates())
            {
                runUpdate();
            }

            toggleSelections(true);
        }

        private bool checkUpdates()
        {
            return infos.CurrentVersion == infos.SettingValues[6] ? false : true;
        }

        private void runUpdate()
        {
            UpdateWindow update = new UpdateWindow();
            DialogResult runUpdate = update.ShowDialog();
            if(runUpdate == DialogResult.Cancel)
            { 
                tc.dismount();
                this.Close();
            }
            else
            {
                //add to xml file     
                xml.saveLoginObjects();
                                
                fillListViews();
            }
        }

        private void fillListViews()
        {
            Logins logs = xml.getLoginObjects();
            infos.LoginList = logs.LoginList;
            infos.CurrentVersion = logs.VersionNo;

            lViewLogs.Items.Clear();
            lViewFavorites.Items.Clear();

            lViewLogs.Items.AddRange(editLV.addList(lViewLogs));
            lViewFavorites.Items.AddRange(editLV.addListFav(lViewFavorites));
        }

        private void toggleSelections(bool state)
        {
            infos.IsMounted = state;
            btMountDism.ImageIndex = state ? 1 : 0;
            gBoxLogs.Enabled = state;
            gBoxFavs.Enabled = state;
        }

        //####  Button EventHandler

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditContent editC = new EditContent(this);
            editC.newLogin();
            DialogResult edited = editC.ShowDialog();

            if(edited == DialogResult.OK)
            {
                LoginObject newLog = editC.TmpLogObject;
                editLV.addItem(lViewLogs, newLog);    
                  
                if(newLog.Fav)
                    editLV.addItem(lViewFavorites, newLog);

                //add to xml file     
                xml.saveLoginObjects();
            }
        }

        private void showLogin(object sender, EventArgs e)
        {
            ListView usedView = (ListView)sender;

            if (usedView.SelectedItems.Count > 0)
            {
                if (!firstItemSelected)
                {
                    firstItemSelected = true;
                    content.toggleContent(true);
                }

                string itemID = usedView.SelectedItems[0].Name;
                content.clearContent();
                content.updateContent(itemID);
            }
        }

        private void btMountDism_Click(object sender, EventArgs e)
        {
            if (infos.IsMounted)
            {
                //dismount
                if (tc.dismount())
                {
                    toggleSelections(false);

                    firstItemSelected = false;

                    lViewLogs.Clear();
                    lViewFavorites.Clear();

                    content.toggleContent(false);
                    content.clearContent();

                    infos.LoginList.Clear();
                }
                else
                    MessageBox.Show("Error during logout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
            else
            {
                //mount
                if (tc.mount())
                {
                    login();
                }
                else
                    MessageBox.Show("Error during login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            SettingWindow settings = new SettingWindow();

            if (infos.IsMounted)
            {
                settings.loadSettings(true);
                settings.readOnly();
                settings.ShowDialog();
            }
            else
            {
                settings.loadSettings(false);             
                settings.ShowDialog();
            }
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!cancelSearch)
            {
                string input = textBoxSearch.Text.ToLower();

                lViewLogs.Items.Clear();

                lViewLogs.Items.AddRange(infos.LoginList.Where(i => string.IsNullOrWhiteSpace(input) || i.Name.ToLower().Contains(input) || i.GroupName.ToLower().Contains(input))
                    .Select(c => editLV.createItem(lViewLogs, c)).ToArray());
            }
        }

        private void btCancelSearch_Click(object sender, EventArgs e)
        {
            resetSearch();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {       
            if(infos.SettingValues[4] == "true")
            {
                this.Enabled = false;
                //try to mount with settings     
                LoginJob logJob = new LoginJob(this);
                logJob.createJob(0);
                logJob.start();
            }
            else
            {
                //show Mount-Window
                Login loginWindow = new Login();
                DialogResult loginResult = loginWindow.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    login();
                }
                else
                {
                    this.Close();
                }
            }            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (infos.IsMounted)
            {
                if (infos.SettingValues[5] == "true")
                {
                    //auto dismount
                    if (tc.dismount())
                    {
                        toggleSelections(false);

                        firstItemSelected = false;

                        lViewLogs.Clear();
                        lViewFavorites.Clear();

                        content.toggleContent(false);
                        content.clearContent();

                        infos.LoginList.Clear();
                        e.Cancel = false;
                    }
                    else
                    {
                        MessageBox.Show("Error during logout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }                    
                }
                else
                {
                    MessageBox.Show("Please logout befor closing the tool!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = false;
        }

        private void btOrderAz_Click(object sender, EventArgs e)
        {
            changeBtBorder(btOrderAz);
            lViewLogs.ShowGroups = false;
            lViewLogs.Sorting = SortOrder.Ascending;
            lViewLogs.Alignment = ListViewAlignment.Top;
            resetSearch();
        }

        private void btOrderGroups_Click(object sender, EventArgs e)
        {
            changeBtBorder(btOrderGroups);     
            lViewLogs.ShowGroups = true;
            lViewLogs.Sorting = SortOrder.Ascending;
            lViewLogs.Alignment = ListViewAlignment.Default;

            resetSearch();
        }

        private void btOrderZa_Click(object sender, EventArgs e)
        {
            changeBtBorder(btOrderZa);
            lViewLogs.ShowGroups = false;
            lViewLogs.Sorting = SortOrder.Descending;
            lViewLogs.Alignment = ListViewAlignment.Top;
            resetSearch();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            InfoWindows info = new InfoWindows();
            info.ShowDialog();
        }

        private void changeBtBorder(Button bt)
        {
            lastOrderB.FlatAppearance.BorderSize = 0;
            bt.FlatAppearance.BorderSize = 2;
            lastOrderB = bt;
        }
    }
}
