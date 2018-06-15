using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workplace_Viewer
{
    class DoUpdate
    {
        TmpInfo infos;

        public DoUpdate()
        {
            infos = TmpInfo.Instance;
        }

        public bool CheckForUpdate()
        {
            if (UpdateAvailable())
            {
                return RunUpdate();

            }
            return true;
        }        

        private bool UpdateAvailable()
        {
            return infos.CurrentVersion == infos.SettingValues[6] ? false : true;
        }

        private bool RunUpdate()
        {
            UpdateWindow update = new UpdateWindow();
            DialogResult runUpdate = update.ShowDialog();
            if (runUpdate == DialogResult.Cancel)
            {
                //tc.dismount();TODO
                //this.Close();TODO
                return false;
            }
            else
            {
                //add to xml file     
                new UseXML().saveLoginObjects();

                //fillListViews(); TODO

                return true;
            }            
        }
    }
}
