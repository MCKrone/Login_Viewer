using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workplace_Viewer
{
    public partial class LookForDriveWaitDialog : Form, IJob
    {
        public string MountDrive { private get; set; }

        private BackgroundWorker job;
        private int jobNo;

        public LookForDriveWaitDialog()
        {
            InitializeComponent();
        }

        public void createJob(int jobNo)
        {
            this.jobNo = jobNo;
            job = new BackgroundWorker();
            job.WorkerSupportsCancellation = true;
            job.DoWork += new DoWorkEventHandler(job_DoWork);
            job.RunWorkerCompleted += new RunWorkerCompletedEventHandler(job_RunWorkerCompleted);
        }

        public void job_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (jobNo)
            {
                case 0:
                    while (!Directory.Exists(MountDrive + ":\\"))
                    {
                        Thread.Sleep(100);
                        if (job.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                    }
                    break;
                case 1:
                    while (Directory.Exists(MountDrive + ":\\"))
                    {
                        Thread.Sleep(100);
                        if (job.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                    }
                    break;
            }
        }

        public void job_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {           
        }

        public void job_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        public void start()
        {
            job.RunWorkerAsync();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            job.CancelAsync();
        }
    }
}
