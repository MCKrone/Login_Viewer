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
using Expanse_Viewer;
using Node_Viewer;
using Login_Viewer;
using ToDo_Viewer;

namespace Workplace_Viewer
{
    public partial class MainWindow : Form
    {
        private TmpInfo infos;
        private Panel[] workplaces;
        private Panel activeWPAction;
        private UseTrueCrypt tc;
        private UseXML xml;
        private DoLoginOut doLoginOut;
        private Login_V login;
        private Expense_V expanse;
        private Node_V node;
        private ToDo_V todo;

        public MainWindow()
        {        
            InitializeComponent();            

            LoadValues();

            LoadTabPageViewers();

            InitializeLook();

            //Thread.Sleep(2000); TODO                  
        }    

        private void LoadValues()
        {
            infos = TmpInfo.Instance;
            new Settings().loadSettings();

            xml = new UseXML();
            tc = new UseTrueCrypt();

            doLoginOut = new DoLoginOut();

            workplaces = new Panel[]
            {
                pWPLogin, pWPToDO, pWPNode, pWPExpanses
            };
        }

        private void LoadTabPageViewers()
        {
            login = new Login_V();
            expanse = new Expense_V();
            node = new Node_V();
            todo = new ToDo_V();

            login.Dock = DockStyle.Fill;            
            expanse.Dock = DockStyle.Fill;
            node.Dock = DockStyle.Fill;
            todo.Dock = DockStyle.Fill;

            login.Enabled = false;
            expanse.Enabled = false;
            node.Enabled = false;
            todo.Enabled = false;
                        
            tabPLoginViewer.Controls.Add(login);
            tabPExpanseViewer.Controls.Add(expanse);
            tabPNodeViewer.Controls.Add(node);
            tabPToDoViewer.Controls.Add(todo);
        }
        
        private void InitializeLook()
        {
            //Hide TabControl headers
            tabCWorksplaces.Appearance = TabAppearance.FlatButtons;
            tabCWorksplaces.ItemSize = new Size(0, 1);
            tabCWorksplaces.SizeMode = TabSizeMode.Fixed;

            //Hide Workplace-Actives
            pLoginActive.Visible = false;
            pNodeActive.Visible = false;
            pExpansesActive.Visible = false;
            pToDoActive.Visible = false;

            //Set active WP
            activeWPAction = (Panel)workplaces[0].Controls[0];
            activeWPAction.Visible = true;
        }

        public void SetWPActive(int index)
        {
            activeWPAction.Visible = false;
            activeWPAction = (Panel)workplaces[index].Controls[0];
            activeWPAction.Visible = true;
        }

        public void SetTabPageActive(int index)
        {
            tabCWorksplaces.SelectedIndex = index;
        }

        public void SetLoginState(bool state)
        {
            bLogInOut.ImageIndex = state ? 1 : 0;

            
        }

        public void SetActive(bool active)
        {
            this.flowLPOptions.Enabled = active;
        }        

        private void WPButton_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse((string)((Button)sender).Tag);
            SetWPActive(index);
            SetTabPageActive(index);
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            SettingWindow settings = new SettingWindow();

            if (infos.IsMounted)
            {
                settings.loadSettings(true);
                settings.readOnly();
                settings.ShowDialog();
            }
            else
            {
                settings.loadSettings(false);
                settings.ShowDialog();
            }
        }

        private void bLogInOut_Click(object sender, EventArgs e)
        {
            if (infos.IsMounted)
            {
                //Logout
                doLoginOut.Logout(this);
            }
            else
            {
                //Login
                doLoginOut.Login(this);                
            }
        }

        public void LoadViewer()
        {
            Logins logs = xml.getLoginObjects();
            infos.LoginList = logs.LoginList;
            infos.CurrentVersion = logs.VersionNo;

            DoUpdate updates = new DoUpdate();
            if (!updates.CheckForUpdate()) {
                doLoginOut.Logout(this);
            }

            Console.WriteLine("Load Viewer");

            login.Enabled = true;
            expanse.Enabled = true;
            node.Enabled = true;
            todo.Enabled = true;

            login.fillListViews();
        }

        public void ClearViewer()
        {
            Console.WriteLine("Clear Content");
            login.Clear();

            login.Enabled = false;
            expanse.Enabled = false;
            node.Enabled = false;
            todo.Enabled = false;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (infos.IsMounted)
            {
                if (infos.SettingValues[5] == "true")
                {
                    e.Cancel = !doLoginOut.Logout(this);
                }
                else
                {
                    MessageBox.Show("Please logout befor closing the tool!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = false;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            if (infos.SettingValues[4] == "true")
            {
                doLoginOut.Login(this);
            }
        }
    }
}
