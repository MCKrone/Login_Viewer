using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workplace_Viewer
{
    class DoLoginOut
    {
        public void InitialLogin()
        {
            DoUpdate updates = new DoUpdate();
            updates.CheckForUpdate();
        }

        public void Login(MainWindow mainW)
        {
            //try to mount with settings     
            mainW.SetActive(false);
            mainW.SetLoginState(false);

            LoginJob logJob = new LoginJob(mainW);
            logJob.createJob(0);
            logJob.start();
        }

        public bool Logout(MainWindow mainW)
        {
            mainW.SetLoginState(false);

            //auto dismount
            if (new UseTrueCrypt().dismount())
            {
                TmpInfo info = TmpInfo.Instance;
                info.IsMounted = false;
                info.LoginList.Clear();

                mainW.SetLoginState(false);
                mainW.ClearViewer();
                return false;
            }
            else
            {
                MessageBox.Show("Error during logout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
