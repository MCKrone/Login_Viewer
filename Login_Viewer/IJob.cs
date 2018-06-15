using System.ComponentModel;

namespace Login_Viewer
{
    interface IJob
    {
        void createJob(int jobNo);
        void job_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e);               
        void job_ProgressChanged(object sender, ProgressChangedEventArgs e);
        void job_DoWork(object sender, DoWorkEventArgs e);
        void start();
    }
}
