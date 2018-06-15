using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Viewer
{
    public class LoginActions
    {
        public void setLockContent(bool lockMode, TextBox[] textInputs, RichTextBox memo)
        {
            foreach (TextBox input in textInputs)
            {
                input.ReadOnly = !lockMode;
            }

            memo.ReadOnly = !lockMode;
        }

        public void clearContent(TextBox[] textInputs, RichTextBox memo)
        {
            foreach (TextBox input in textInputs)
            {
                input.Clear();
            }

            memo.Clear();
        }

        public void setContent(string loginName, TextBox[] textInputs, RichTextBox memo)
        {
            clearContent(textInputs, memo);
            
            UseXML_old uxml = new UseXML_old();
            uxml.loadXML();
            List<string> content = uxml.getContent(loginName);

            fillFields(content, textInputs, memo);
        }

        private void fillFields(List<string> content, TextBox[] textInputs, RichTextBox memo)
        {            
            int cCount = content.Count;
            for (int i = 0; i < cCount; i++)
            {
                string text = content.ElementAt(i);

                if (i < 5)
                {
                    textInputs[i].Text = text;                    
                }
                else
                {
                    if (i != cCount - 1)
                        memo.AppendText(text + Environment.NewLine);
                    else
                        memo.AppendText(text);
                }
            }
        }

        public void saveContent(string loginName, TextBox[] textInputs, RichTextBox memo, Button[] buttons)
        {            
            List<string> changes = new List<string>();

            if (string.IsNullOrWhiteSpace(textInputs[0].Text))
            {
                MessageBox.Show("Der Name darf nicht leer sein", "Speichern nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Error);        
            }
            else
            {
                foreach (TextBox input in textInputs)
                {
                    string text = input.Text;                    
                    changes.Add(text);                   
                }

                foreach (string line in memo.Lines)
                {
                    changes.Add(line);
                }
                UseXML_old uxml = new UseXML_old();
                uxml.loadXML();
                if (uxml.saveLogin(loginName, changes))
                {
                    setLockContent(false, textInputs, memo);

                    lockEdit(true, buttons);
                }
            }              
        }

        public void lockEdit(bool mode, Button[] buttons)
        {
            buttons[0].Enabled = mode;
            buttons[1].Enabled = !mode;
            buttons[2].Enabled = !mode;
        }        
    }
}
