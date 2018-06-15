using System;
using System.Linq;
using System.Windows.Forms;
using Workplace_Viewer;

namespace Login_Viewer
{
    public partial class EditContent : Form
    {
        private bool loading, saveEnabled, editLog;
        private TmpInfo infos;

        public LoginObject TmpLogObject { get; private set; }

        public EditContent()
        {
            InitializeComponent();

            editLog = false;
            loading = true;
            saveEnabled = false;

            infos = TmpInfo.Instance;

            cBoxGroups.DataSource = infos.ListGroups;
            cBoxGroups.DisplayMember = "Name";
            cBoxGroups.SelectedIndex = 0;   
        }

        public void newLogin()
        {
            TmpLogObject = new LoginObject();
            TmpLogObject.ID = Guid.NewGuid();
            TmpLogObject.ChangeDate = DateTime.Today;
            TmpLogObject.CreationDate = DateTime.Today;

            loading = false;
        }

        public void editLogin(LoginObject log)
        {
            editLog = true;

            TmpLogObject = log;

            //add Infos
            cBoxFav.Checked = log.Fav;
            cBoxGroups.SelectedIndex = infos.ListGroups.FindIndex(x => x.IndexAz == log.IndexAz);
            tBoxName.Text = log.Name;
            tBoxWebs.Text = log.Website;
            tBoxMail.Text = log.Mail;
            tBoxUser.Text = log.Username;
            tBoxPw.Text = log.Password;
            richTextBoxMemo.Text = log.Memo;

            loading = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            GroupObject selectedGroup = ((GroupObject)cBoxGroups.SelectedItem);

            TmpLogObject.Fav = cBoxFav.Checked;
            TmpLogObject.Index = selectedGroup.IndexDef;
            TmpLogObject.IndexAz = selectedGroup.IndexAz;
            TmpLogObject.GroupName = selectedGroup.Name;
            TmpLogObject.Name = tBoxName.Text;
            TmpLogObject.Website = tBoxWebs.Text;
            TmpLogObject.Mail = tBoxMail.Text;
            TmpLogObject.Username = tBoxUser.Text;
            TmpLogObject.Password = tBoxPw.Text;
            TmpLogObject.Memo = richTextBoxMemo.Text;

            if (editLog)
            {
                //saveEdit -> Eintrag überschreiben
                int index = infos.LoginList.FindIndex(x => x.ID == TmpLogObject.ID);
                TmpLogObject.ChangeDate = DateTime.Today;
                TmpLogObject.ChangeType = "Edit";

                infos.LoginList[index] = TmpLogObject;
            }
            else
            {
                TmpLogObject.ChangeType = "New";

                infos.LoginList.Add(TmpLogObject);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void contentChanged(object sender, EventArgs e)
        {   
            if (!loading)
            {
                if (String.IsNullOrWhiteSpace(tBoxName.Text))
                {
                    if (saveEnabled)
                    {
                        saveEnabled = false;
                        btSave.Enabled = false;
                    }
                }
                else
                {
                    if (!saveEnabled)
                    {
                        saveEnabled = true;
                        btSave.Enabled = true;
                    }
                }
            }
        }
    }
}
