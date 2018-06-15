using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Viewer
{
    class LoginJob : IJob
    {
        private BackgroundWorker job;
        private TmpInfo infos;
        private UseTrueCrypt tc;
        private MainWindow main;
        private int jobNo, loginState;

        public LoginJob(MainWindow main)
        {
            infos = TmpInfo.Instance;
            tc = new UseTrueCrypt();
            this.main = main;            
        }

        public void createJob(int jobNo)
        {
            this.jobNo = jobNo;

            job = new BackgroundWorker();
            //job.WorkerSupportsCancellation = true;
            job.DoWork += new DoWorkEventHandler(job_DoWork);
            job.RunWorkerCompleted += new RunWorkerCompletedEventHandler(job_RunWorkerCompleted);
        }

        public void job_DoWork(object sender, DoWorkEventArgs e)
        {            
            loginDirect();            
        }

        private void loginDirect()
        {
            if (tc.mount())
            {
                loginState = 0;
            }
            else
                loginState = 1;
        }        

        public void job_ProgressChanged(object sender, ProgressChangedEventArgs e)  {}

        public void job_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (loginState)
            {
                case 0:
                    main.setActive(true);
                    main.login();
                    break;
                case 1:
                    main.setActive(true);
                    break;
            }
        }

        public void start()
        {
            job.RunWorkerAsync();
        }
    }
}
