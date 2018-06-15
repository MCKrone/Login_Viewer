using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_Viewer
{
    class UseTrueCrypt
    {
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private IntPtr handle;

        private string exe, mountDrive;
        private List<string> settings;

        private TmpInfo infos;

        public UseTrueCrypt()
        {
            infos = TmpInfo.Instance;
                        
            settings = infos.SettingValues;

            exe = settings[0];
            mountDrive = settings[2];
        }

        public bool mount()
        {
            bool success = false;
            
            string param = $"/v \"{settings[1]}\" /l{mountDrive} /q";

            Process trueCrypt = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exe,
                    Arguments = param
                }
            };

            try
            {
                trueCrypt.Start();
            }
            catch (Exception e)
            {
                string msg = "An error occurred while startin TrueCrypt.\r\n";
                msg += "Please recheck the settings!\r\n";
                msg += "Errormessage:\r\n";
                MessageBox.Show(msg + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            handle = trueCrypt.MainWindowHandle;
            SetForegroundWindow(handle);

            trueCrypt.WaitForExit();

            if (trueCrypt.ExitCode == 0)
            {
                LookForDriveWaitDialog searchDialog = new LookForDriveWaitDialog();
                searchDialog.MountDrive = mountDrive;
                searchDialog.createJob(0);
                searchDialog.start();
                DialogResult foundDrive = searchDialog.ShowDialog();
                if (foundDrive == DialogResult.OK)
                    success = true;
                else
                    success = false;
            }
            else
            {
                MessageBox.Show("TrueCrypt was cancelled", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                success = false;
            }

            return success;
        }

        public bool dismount()
        {
            bool success = false;

            Process trueCrypt = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $"\"{exe}\"",
                    Arguments = $"/d{mountDrive} /q"
                }
            };

            trueCrypt.Start();
            trueCrypt.WaitForExit();

            if (trueCrypt.ExitCode == 0)
            {
                LookForDriveWaitDialog searchDialog = new LookForDriveWaitDialog();
                searchDialog.MountDrive = mountDrive;
                searchDialog.createJob(1);
                searchDialog.start();
                DialogResult foundDrive = searchDialog.ShowDialog();
                if (foundDrive == DialogResult.OK)
                    success = true;
                else
                    success = false;
            }
            else
            {
                MessageBox.Show("TrueCrypt was cancelled", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                success = false;
            }

            if (!Directory.Exists(mountDrive + ":\\"))
            {
                success = true;
            }

            return success;
        }
    }
}
