using System;
using System.Threading;
using System.Windows.Forms;

namespace Workplace_Viewer
{
    static class Program
    {
        public static SplashScreen splashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Thread splashThread = new Thread(new ThreadStart(delegate{ TODO
            //    splashScreen = new SplashScreen();
            //    Application.Run(splashScreen);
            //}));
            //splashThread.SetApartmentState(ApartmentState.STA);
            //splashThread.Start();

            MainWindow main = new MainWindow();
            main.Load += new EventHandler(main_Load);

            Application.Run(main);
        }

        static void main_Load(object sender, EventArgs e)
        {
            //close splash
            if (splashScreen == null)
            {
                return;
            }

            splashScreen.Invoke(new Action(splashScreen.Close));
            splashScreen.Dispose();
            splashScreen = null;
        }
    }
}
