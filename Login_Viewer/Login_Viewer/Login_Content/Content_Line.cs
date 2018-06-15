using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Login_Viewer
{
    public partial class Content_Line : UserControl
    {
        private TextBox tBox;
        private string Type;

        public Content_Line()
        {
            InitializeComponent();

            SetBtVisibility(false, false);
            SetBtImage(bt1, 0);
            SetBtImage(bt2, 1);
        }

        public void CustomizeContent(string type, string name, string content)
        {
            Type = type;

            SetName(name);

            switch (type)
            {
                case "normal":
                    CreateTextBox(content);
                    
                    SetBtVisibility(true, false);
                    break;
                case "website":
                    CreateTextBox(content);
                    
                    SetBtImage(bt2, 0);
                    SetBtVisibility(true, true);
                    break;
                case "password":
                    CreateTextBox(content);
                    AddPwToTBox();

                    SetBtImage(bt2, 1);
                    SetBtVisibility(true, true);
                    break;
                case "memo":
                    CreateRichTB(content);
                    break;
            }
        }

        private void SetName(string name)
        {
            lName.Text = name + ":";
        }

        private void CreateTextBox(string content)
        {
            tBox = new TextBox()
            {
                Size = new Size(224, 20),
                Text = content,
                ReadOnly = true,
                Location = new Point(3, 8),
                HideSelection = true
            };

            pContent.Controls.Add(tBox);
        }

        private void CreateRichTB(string content)
        {
            RichTextBox rTB = new RichTextBox()
            {
                Text = content,
                ReadOnly = true,
                Location = new Point(3, 8),
                Dock = DockStyle.Fill
            };
            int memoHeight = (rTB.Lines.Length * ((int)(rTB.Font.SizeInPoints * 1.3333333) + 3)) + 10;
            if (memoHeight > this.Height)
                this.Height = memoHeight;

            //Console.WriteLine($"h1: {rTB.Font.SizeInPoints * 1.3333333}");
            pContent.Controls.Add(rTB);
        }

        private void AddPwToTBox()
        {
            tBox.UseSystemPasswordChar = true;
        }

        private void CopyContent()
        {
            Clipboard.SetText(tBox.Text);
        }

        private void SetBtImage(Button bt, int index)
        {
            bt.ImageIndex = index;
        }

        private void TogglePw()
        {
            bool showPW = !tBox.UseSystemPasswordChar;
            int index = showPW ? 1 : 2; 

            tBox.UseSystemPasswordChar = showPW;
            bt2.ImageIndex = index;
        }

        private void OpenWebsite()
        {            
            try
            {
                Process.Start(tBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open website!\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void SetBtVisibility(bool bt1Bool, bool bt2Bool)
        {
            bt1.Visible = bt1Bool;
            bt2.Visible = bt2Bool;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            CopyContent();            
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case "website":
                    OpenWebsite();
                    break;
                case "password":
                    TogglePw();
                    break;
            }
        }
    }
}
