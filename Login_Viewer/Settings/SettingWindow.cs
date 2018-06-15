using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Viewer
{
    public partial class SettingWindow : Form
    {
        private List<string> driveLetters;
        private TmpInfo infos;
        
        public SettingWindow()
        {
            InitializeComponent();

            infos = TmpInfo.Instance;

            driveLetters = new List<string>() {
                "E", "G", "H", "I", "J", "K", "L",
                "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
                "V", "W", "X", "Y", "Z"
            };    
        }

        public void loadSettings(bool readOnly)
        {
            List<string> settingsValues = infos.SettingValues;

            checkBAutoLogin.Checked = settingsValues[4] == "true" ? true : false;
            checkBAutoLogout.Checked = settingsValues[5] == "true" ? true : false;

            tBExePath.Text = settingsValues[0];
            tBFilePath.Text = settingsValues[1];            

            if (!readOnly)
            {
                List<string> filteredList = filterDriverLs();

                cBoxDriveLetters.DataSource = filteredList;
                int letterIndex = filteredList.IndexOf(settingsValues[2].ToUpper());

                if (letterIndex > -1)
                {
                    cBoxDriveLetters.SelectedIndex = letterIndex;
                }
                else
                    cBoxDriveLetters.SelectedIndex = 0;
            }
            else
            {
                cBoxDriveLetters.DataSource = new List<string>() { settingsValues[2].ToUpper() };
                cBoxDriveLetters.SelectedIndex = 0;
            }

            tBXmlPath.Text = settingsValues[3];
        }

        private List<string> filterDriverLs()
        {
            List<string> drives = Directory.GetLogicalDrives().ToList();

            List<string> result = driveLetters.Where(x => !drives.Any(y => y.Contains(x))).ToList();

            return result;
        }

        public void readOnly()
        {
            tBExePath.ReadOnly = true;
            tBFilePath.ReadOnly = true;
            tBXmlPath.ReadOnly = true;
            cBoxDriveLetters.Enabled = false;
            btGetExePath.Enabled = false;
            btGetFilePath.Enabled = false;
            btSetSave.Enabled = false;
            lNoSaveInfo.Visible = true;
            checkBAutoLogin.Enabled = false;
            checkBAutoLogout.Enabled = false;
        }

        private void btGetExePath_Click(object sender, EventArgs e)
        {
            getExe.ShowDialog();
            tBExePath.Text = getExe.FileName;
        }

        private void btGetFilePath_Click(object sender, EventArgs e)
        {
            getVolume.ShowDialog();
            tBFilePath.Text = getVolume.FileName;
        }

        private void btSetSave_Click(object sender, EventArgs e)
        {
            List<string> changedSettings = new List<string>()
            {
                tBExePath.Text,
                tBFilePath.Text,
                cBoxDriveLetters.SelectedItem.ToString(),
                tBXmlPath.Text,
                checkBAutoLogin.Checked.ToString().ToLower(),
                checkBAutoLogout.Checked.ToString().ToLower()
            };

            new Settings().saveSettings(changedSettings);            

            this.Close();
        }

        private void btSetCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
