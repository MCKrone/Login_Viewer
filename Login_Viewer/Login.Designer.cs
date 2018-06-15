namespace Login_Viewer
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.btMount = new System.Windows.Forms.Button();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btSetting);
            this.panel1.Controls.Add(this.btMount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 144);
            this.panel1.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btCancel.Image = global::Login_Viewer.Properties.Resources.Cancel_icon_48;
            this.btCancel.Location = new System.Drawing.Point(234, 40);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(80, 65);
            this.btCancel.TabIndex = 3;
            this.toolTipLogin.SetToolTip(this.btCancel, "Cancel Login");
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSetting
            // 
            this.btSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSetting.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetting.Image = global::Login_Viewer.Properties.Resources.Wheel_icon_32;
            this.btSetting.Location = new System.Drawing.Point(348, 3);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(45, 45);
            this.btSetting.TabIndex = 2;
            this.toolTipLogin.SetToolTip(this.btSetting, "Open Settings");
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btMount
            // 
            this.btMount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btMount.FlatAppearance.BorderSize = 0;
            this.btMount.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btMount.Image = global::Login_Viewer.Properties.Resources.Login_in_icon_48;
            this.btMount.Location = new System.Drawing.Point(66, 40);
            this.btMount.Name = "btMount";
            this.btMount.Size = new System.Drawing.Size(80, 65);
            this.btMount.TabIndex = 0;
            this.btMount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipLogin.SetToolTip(this.btMount, "Login");
            this.btMount.UseVisualStyleBackColor = true;
            this.btMount.Click += new System.EventHandler(this.btMount_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btMount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(397, 144);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMount;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipLogin;
    }
}