using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Viewer
{
    public partial class LoginSplashScreen : Form
    {
        public LoginSplashScreen()
        {
            InitializeComponent();

            timerStartProgress.Start();
        }

        private void timerStartProgress_Tick(object sender, EventArgs e)
        {
            pBarLogin.PerformStep();
            if (pBarLogin.Value == pBarLogin.Maximum)
                timerStartProgress.Stop();
        }
    }
}
