using System;
using System.Windows.Forms;
using System.Diagnostics;
using Workplace_Viewer;

namespace Login_Viewer
{
    public partial class Content : UserControl
    {    
        private Login_V main;
        private TmpInfo infos;
        private LoginObject currentLog;
        private UseXML xml;

        public Content(Login_V main)
        {
            InitializeComponent();

            toggleContent(false);            

            this.main = main;
            this.infos = TmpInfo.Instance;
            xml = new UseXML();
        }      

        public void updateContent(string id)
        {
            currentLog = infos.LoginList.Find(x => x.ID.ToString() == id);

            gBoxLog_Content.Text = "Login - " + currentLog.Name;

            flowLPContent.Visible = false;
                        
            //Add Name
            if(!String.IsNullOrWhiteSpace(currentLog.Name))
                AddLine("normal", "Name", currentLog.Name);

            //Add Website
            if (!String.IsNullOrWhiteSpace(currentLog.Website))
                AddLine("website", "Website", currentLog.Website);

            //Add Mail
            if (!String.IsNullOrWhiteSpace(currentLog.Mail))
                AddLine("normal", "Mail", currentLog.Mail);

            //Add Username
            if (!String.IsNullOrWhiteSpace(currentLog.Username))
                AddLine("normal", "Username", currentLog.Username);

            //Add Password
            if (!String.IsNullOrWhiteSpace(currentLog.Password))
                AddLine("password", "Password", currentLog.Password);

            //Add Memo
            if (!String.IsNullOrWhiteSpace(currentLog.Memo))
            {
                int height0 = 0;
                foreach (Control c in flowLPContent.Controls)
                    height0 += c.Height + 6;

                AddLine("memo", "Memo", currentLog.Memo);
                int height1 = 0;
                foreach (Control c in flowLPContent.Controls)
                    height1 += c.Height + 6;

                if (height1 > flowLPContent.Height)
                {
                    Control c = flowLPContent.Controls[flowLPContent.Controls.Count - 1];
                    c.Height = flowLPContent.Height - height0 - 6;
                }
            }

            flowLPContent.Visible = true;
            
            //update Bts-States
            toggleFavStates(!currentLog.Fav);
        }

        private void AddLine(string type, string name, string content)
        {
            Content_Line ct = new Content_Line();
            ct.CustomizeContent(type, name, content);
            flowLPContent.Controls.Add(ct);
        }

        public void clearContent()
        {
            //Delete Lines
            flowLPContent.Controls.Clear();

            gBoxLog_Content.Text = "Login - ";
        }

        //####  Toogle Form States

        public void toggleContent(bool active)
        {
            pLog_Content.Enabled = active;
        }

        public void toggleFavStates(bool active)
        {
            //true      -> +add || -remove
            //false     -> -add || +remove
            btFavorite_Add.Enabled = active;
            btFavorite_Remove.Enabled = !active;
        }

        //####  Actions:

        private void btFavorite_Add_Click(object sender, EventArgs e)
        {
            currentLog.Fav = true;

            //update List
            int index = infos.LoginList.FindIndex(x => x.ID == currentLog.ID);
            infos.LoginList[index] = currentLog;

            //update View
            main.updateListItem(currentLog);

            //update Bts-States
            toggleFavStates(false);

            //update in xml file     
            xml.saveLoginObjects();
        }

        private void btFavorite_Remove_Click(object sender, EventArgs e)
        {
            currentLog.Fav = false;

            //update from List
            int index = infos.LoginList.FindIndex(x => x.ID == currentLog.ID);
            infos.LoginList[index] = currentLog;

            //remove from ViewFav
            //main.updateListItem(currentLog);TODO

            //update Bts-States
            toggleFavStates(true);

            //update in xml file     
            xml.saveLoginObjects();
        }

        private void btLog_Edit_Click(object sender, EventArgs e)
        {
            EditContent editC = new EditContent();
            editC.editLogin(currentLog);
            DialogResult edited = editC.ShowDialog();

            if (edited == DialogResult.OK)
            {
                currentLog = editC.TmpLogObject;

                //Update ListViews
                main.updateListItem(currentLog);
                main.resetSearch();

                //Clear Content
                clearContent();

                //Update Content
                updateContent(currentLog.ID.ToString());

                //update Bts-States
                toggleFavStates(!currentLog.Fav);

                //update in xml file 
                xml.saveLoginObjects();
            }
        }

        private void btLog_Remove_Click(object sender, EventArgs e)
        {
            DialogResult deleteQuestion = MessageBox.Show($"Would you like to delete the Login '{currentLog.Name}'?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteQuestion == DialogResult.Yes)
            {
                toggleContent(false);
                clearContent();                

                //remove from infoList
                int index = infos.LoginList.FindIndex(x => x.ID == currentLog.ID);
                infos.LoginList.RemoveAt(index);

                //remove from xml file  
                xml.saveLoginObjects();

                //remove from LViews
                main.removeListItem(currentLog);
                main.resetSearch();
            }
        }        
    }
}
