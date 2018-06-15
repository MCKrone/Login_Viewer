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
using static System.Windows.Forms.ListView;
using Workplace_Viewer;

namespace Login_Viewer
{
    public partial class Login_V : UserControl
    {
        private Content content;
        private EditListView editLV;
        private TmpInfo infos;
        private bool firstItemSelected, cancelSearch;
        private UseXML xml;
        private Button lastOrderB;

        public Login_V()
        {           
            InitializeComponent();

            firstItemSelected = false;
            cancelSearch = false;

            infos = TmpInfo.Instance;

            editLV = new EditListView();          

            xml = new UseXML();

            content = new Content(this);
            content.Dock = DockStyle.Fill;
            pCustomAction.Controls.Add(content);

            lastOrderB = btOrderGroups;
            lastOrderB.FlatAppearance.BorderSize = 2;          
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

        public void fillListViews()
        {
            //lViewLogs.Items.Clear();
            //lViewFavorites.Items.Clear();

            editLV.addGroups(new ListView[] { lViewLogs, lViewFavorites });

            lViewLogs.Items.AddRange(editLV.addList(lViewLogs));
            lViewFavorites.Items.AddRange(editLV.addListFav(lViewFavorites));
        }

        //####  Button EventHandler

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditContent editC = new EditContent();
            editC.newLogin();
            DialogResult edited = editC.ShowDialog();

            if (edited == DialogResult.OK)
            {
                LoginObject newLog = editC.TmpLogObject;
                editLV.addItem(lViewLogs, newLog);

                if (newLog.Fav)
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

        public void Clear()
        {
            //if dismount ->
            firstItemSelected = false;

            lViewLogs.Clear();
            lViewFavorites.Clear();

            content.toggleContent(false);
            content.clearContent();
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
