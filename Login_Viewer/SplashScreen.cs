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

namespace Workplace_Viewer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
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
