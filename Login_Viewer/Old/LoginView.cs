using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Login_Viewer
{
    public partial class LoginView : Form
    {        
        private InfoControl uc1;
        private UseXML_old uxml;        
        private string loginName;
        private List<string> tmpNames, searchNames;
        private string[] mountedText;
        

        public LoginView()
        {
            mountedText = new string[] { "Mount", "Dismount" };

            InitializeComponent();

            btTrueCMountDism.Text = mountedText[1];

            uxml = new UseXML_old();
            uxml.loadXML();

            uc1 = new InfoControl(this);
            uc1.Dock = DockStyle.Fill;

            pLoginAction.Controls.Add(uc1);

            searchNames = new List<string>();
            tmpNames = uxml.getLogins();

            listBoxNames.DataSource = tmpNames;
        }


        private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedIndex > -1)
            {
                loginName = listBoxNames.SelectedItem.ToString();
                uc1.updateContent(loginName);

                uc1.hidePw();
            }
            else
            {
                uc1.clearLogin();
            }
        }
        

        private void buttonAdd_Click(object sender, EventArgs e)
        {            
            uxml.addLogin();
            updateListView(false);
        }

        public void updateListView(bool freshLoad)
        {
            if (freshLoad)
                uxml.loadXML();

            tmpNames = uxml.getLogins();
            listBoxNames.DataSource = null;
            listBoxNames.DataSource = tmpNames;
            listBoxNames.Refresh();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxNames.Items.Count > 1)
            {
                DialogResult answer = MessageBox.Show("Wollen Sie den Eintrag wirklich löschen?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    if (uxml.removeLogin(loginName))
                    {
                        updateListView(false);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nur noch ein Eintrag enthalten.\r\nDieser kann nicht gelöscht werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void textBoxSearch_Clicked(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxSearch.Text;

            if (searchNames.Count > 0)
                searchNames.Clear();

            for (int i = 0; i < tmpNames.Count; i++)
            {
                string item = tmpNames[i];

                if (item.ToLower().StartsWith(input.ToLower()))
                {
                    searchNames.Add(item);
                }
            }

            listBoxNames.DataSource = null;
            listBoxNames.DataSource = searchNames;
            listBoxNames.Refresh();
        }


        private void btTrueCMountDismount_Click(object sender, EventArgs e)
        {
            //if (!Program.isMounted)
            //{
            //    if(new UseTrueCrypt().mount())
            //    {
            //        Program.isMounted = true;
            //        btTrueCMountDism.Text = mountedText[1];                                  

            //        searchNames = new List<string>();                    

            //        updateListView(true);

            //        pCustomAction.Enabled = true;
            //        pLoginAction.Enabled = true;
            //    }
            //}
            //else
            //{
            //    if(new UseTrueCrypt().dismount())
            //    {
            //        Program.isMounted = false;
            //        btTrueCMountDism.Text = mountedText[0];

            //        listBoxNames.DataSource = null;
            //        uc1.clearLogin();

            //        pCustomAction.Enabled = false;
            //        pLoginAction.Enabled = false;
                    
            //        tmpNames = null;
            //    }
            //}    
        }        

        private void btSettings_Click(object sender, EventArgs e)
        {
            //if (!Program.isMounted)
            //{
            //    SettingWindow st = new SettingWindow();
            //    st.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Einstellungen können erst nach dem Dismount geändert werden!");
            //}
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Program.isMounted)
            //{
            //    MessageBox.Show("Vor dem Verlassen bitte Dismountend");
            //    e.Cancel = true;
            //}
        }

        public void tooglePanels(bool mode)
        {
            pCustomAction.Enabled = !mode;
            pSets.Enabled = !mode;
            pListNames.Enabled = !mode;
        }

        private void buttonSearchReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Search...";
            listBoxNames.DataSource = null;
            listBoxNames.DataSource = tmpNames;
            listBoxNames.Refresh();            
        }
    }
}