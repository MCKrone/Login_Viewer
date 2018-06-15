using System;
using System.Windows.Forms;

namespace Workplace_Viewer
{
    public partial class Login : Form
    {
        private TmpInfo infos;

        public Login()
        {
            InitializeComponent();

            infos = new TmpInfo();
        }

        private void btMount_Click(object sender, EventArgs e)
        {
            if(new UseTrueCrypt().mount())
            {
                infos.IsMounted = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            SettingWindow settings = new SettingWindow();
            settings.loadSettings(false);
            settings.ShowDialog();
        }
    }
}
