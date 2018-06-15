using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Viewer
{
    public partial class UpdateWindow : Form
    {
        private TmpInfo infos;
        private List<string> availableVersions;
        private string currentVersion, nextVersion;
        private List<VersionObject> versions;

        public UpdateWindow()
        {
            InitializeComponent();

            infos = TmpInfo.Instance;

            availableVersions = new List<string>() { "0.0", "0.1" ,"0.2", "0.3"};

            currentVersion = infos.CurrentVersion;
            currentVersion = String.IsNullOrEmpty(currentVersion) ? availableVersions[0] : currentVersion;

            nextVersion = availableVersions[availableVersions.IndexOf(currentVersion) + 1];

            lCurrentV.Text += $" {currentVersion}";
            lLatestV.Text += $" {availableVersions.Last()}";

            createVersions();
            showChanges();
        }

        private void createVersions()
        {
            versions = new List<VersionObject>()
            {
                new VersionObject()
                {
                    VersionNo = "0.1",
                    Changes = new string[]
                    {
                        "Add groupnames to LoginObject (XML)",
                        "Add versions to Logins (XML)",
                        "Add update functions"
                    }
                },
                new VersionObject()
                {
                    VersionNo = "0.2",
                    Changes = new string[]
                    {
                        "Add group 'TU-DD'"
                    }
                },
                new VersionObject()
                {
                    VersionNo = "0.3",
                    Changes = new string[]
                    {
                        "Add creation and change date to each login"
                    }
                }
            };
        }

        private void showChanges()
        {
            tViewChanges.BeginUpdate();
            tViewChanges.Nodes.Clear();

            foreach (VersionObject version in versions)
            {
                TreeNode tmpVersion = new TreeNode(version.VersionNo);

                foreach (string change in version.Changes)
                {
                    tmpVersion.Nodes.Add(new TreeNode(change));
                }
                tViewChanges.Nodes.Add(tmpVersion);
            }

            tViewChanges.EndUpdate();      
        }

        //###   Update Methods

        private void update00to01()
        {
            List<LoginObject> tmpLogList = infos.LoginList;
            List<GroupObject> groupList = infos.ListGroups;

            foreach (LoginObject log in tmpLogList)
            {
                log.GroupName = groupList.Where(x => x.IndexAz == log.IndexAz).First().Name;
            }

            infos.LoginList = tmpLogList;
            infos.CurrentVersion = nextVersion;
            currentVersion = nextVersion;
        }

        private void update01to02()
        {
            List<LoginObject> tmpLogList = infos.LoginList;
            List<GroupObject> groupList = infos.ListGroups;

            foreach (LoginObject log in tmpLogList)
            {
                log.IndexAz = groupList.Where(x => x.Name == log.GroupName).First().IndexAz;
            }

            infos.LoginList = tmpLogList;
            infos.CurrentVersion = nextVersion;
            currentVersion = nextVersion;
        }

        private void update02to03()
        {
            foreach (LoginObject log in infos.LoginList)
            {
                DateTime currentDate = new DateTime(1993, 5, 22, 0,0,0);                

                log.ChangeDate = currentDate;
                log.CreationDate = currentDate;
            }
            
            infos.CurrentVersion = nextVersion;
            currentVersion = nextVersion;
        }

        //###   Buttons Handles

        private void btStart_Click(object sender, EventArgs e)
        {
            int i = availableVersions.IndexOf(nextVersion);
            for (int no = i; no < availableVersions.Count(); no++)
            {
                switch (availableVersions[no])
                {
                    case "0.1":
                        update00to01();
                        break;
                    case "0.2":
                        update01to02();
                        break;
                    case "0.3":
                        update02to03();
                        break;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
