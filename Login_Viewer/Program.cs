using System;
using System.Threading;
using System.Windows.Forms;

namespace Login_Viewer
{
    static class Program
    {
        public static LoginSplashScreen splashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread splashThread = new Thread(new ThreadStart(delegate{
                splashScreen = new LoginSplashScreen();
                Application.Run(splashScreen);
            }));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

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
