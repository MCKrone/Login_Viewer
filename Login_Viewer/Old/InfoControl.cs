using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace Login_Viewer
{
    public partial class InfoControl : UserControl
    {
        private LoginView logView;
        private string loginName;
        private TextBox[] inputs;
        private Button[] buttons;
        private RichTextBox memo;

        public InfoControl(LoginView logView)
        {
            InitializeComponent();

            inputs = new TextBox[] { textBoxName, textBoxWebs, textBoxMail, textBoxUser, textBoxPw };
            buttons = new Button[] { buttonEdit, buttonCancel, buttonSave };
            memo = richTextBoxMemo;          

            new LoginActions().setLockContent(false, inputs, memo);

            this.logView = logView;
        }       
        
        public void updateContent(string loginName)
        {
            this.loginName = loginName;
            new LoginActions().setContent(loginName, inputs, memo);
        }   
        
        private void buttonNameCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxName.Text);
        }

        private void buttonWebCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxWebs.Text);
        }

        private void buttonWebVisite_Click(object sender, EventArgs e)
        {
           Process.Start(textBoxWebs.Text);
        }

        private void buttonUserCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxUser.Text);
        }

        private void buttonPwCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPw.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {            
            new LoginActions().saveContent(loginName, inputs, memo, buttons);
            logView.tooglePanels(false);
            logView.updateListView(true);
        }        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoginActions logAc = new LoginActions();
            logAc.setLockContent(false, inputs, memo);
            logAc.setContent(loginName, inputs, memo);

            logAc.lockEdit(true, buttons);
            logView.tooglePanels(false);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            LoginActions logAc = new LoginActions();
            logAc.setLockContent(true, inputs, memo);
            logAc.lockEdit(false, buttons);

            logView.tooglePanels(true);
        }

        private void buttonTogglePW_Click(object sender, EventArgs e)
        {
            textBoxPw.UseSystemPasswordChar = !textBoxPw.UseSystemPasswordChar;
        }

        private void buttonMailCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxMail.Text);
        }

        public void hidePw()
        {
            textBoxPw.UseSystemPasswordChar = true;
        }
        
        public void clearLogin()
        {
            new LoginActions().clearContent(inputs, memo);
        }
    }
}
