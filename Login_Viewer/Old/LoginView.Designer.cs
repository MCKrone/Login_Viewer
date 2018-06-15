namespace Login_Viewer
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.pLoginAction = new System.Windows.Forms.Panel();
            this.pListNames = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.pCustomAction = new System.Windows.Forms.Panel();
            this.buttonSearchReset = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btTrueCMountDism = new System.Windows.Forms.Button();
            this.pSets = new System.Windows.Forms.Panel();
            this.btSettings = new System.Windows.Forms.Button();
            this.pListNames.SuspendLayout();
            this.pCustomAction.SuspendLayout();
            this.pSets.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxNames
            // 
            this.listBoxNames.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBoxNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNames.ForeColor = System.Drawing.Color.White;
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(0, 0);
            this.listBoxNames.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(133, 342);
            this.listBoxNames.TabIndex = 1;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
            // 
            // pLoginAction
            // 
            this.pLoginAction.BackColor = System.Drawing.Color.Transparent;
            this.pLoginAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoginAction.Location = new System.Drawing.Point(138, 67);
            this.pLoginAction.Name = "pLoginAction";
            this.pLoginAction.Size = new System.Drawing.Size(431, 342);
            this.pLoginAction.TabIndex = 2;
            // 
            // pListNames
            // 
            this.pListNames.Controls.Add(this.listBoxNames);
            this.pListNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.pListNames.Location = new System.Drawing.Point(5, 67);
            this.pListNames.Name = "pListNames";
            this.pListNames.Size = new System.Drawing.Size(133, 342);
            this.pListNames.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(377, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add login";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(470, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove login";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // pCustomAction
            // 
            this.pCustomAction.BackColor = System.Drawing.Color.Transparent;
            this.pCustomAction.Controls.Add(this.buttonSearchReset);
            this.pCustomAction.Controls.Add(this.textBoxSearch);
            this.pCustomAction.Controls.Add(this.buttonRemove);
            this.pCustomAction.Controls.Add(this.buttonAdd);
            this.pCustomAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCustomAction.Location = new System.Drawing.Point(5, 35);
            this.pCustomAction.Name = "pCustomAction";
            this.pCustomAction.Size = new System.Drawing.Size(564, 32);
            this.pCustomAction.TabIndex = 0;
            // 
            // buttonSearchReset
            // 
            this.buttonSearchReset.Location = new System.Drawing.Point(140, 5);
            this.buttonSearchReset.Name = "buttonSearchReset";
            this.buttonSearchReset.Size = new System.Drawing.Size(52, 20);
            this.buttonSearchReset.TabIndex = 4;
            this.buttonSearchReset.Text = "Reset";
            this.buttonSearchReset.UseVisualStyleBackColor = true;
            this.buttonSearchReset.Click += new System.EventHandler(this.buttonSearchReset_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(0, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(133, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Search...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Clicked);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btTrueCMountDism
            // 
            this.btTrueCMountDism.Location = new System.Drawing.Point(3, 3);
            this.btTrueCMountDism.Name = "btTrueCMountDism";
            this.btTrueCMountDism.Size = new System.Drawing.Size(75, 23);
            this.btTrueCMountDism.TabIndex = 5;
            this.btTrueCMountDism.Text = "Mount";
            this.btTrueCMountDism.UseVisualStyleBackColor = true;
            this.btTrueCMountDism.Click += new System.EventHandler(this.btTrueCMountDismount_Click);
            // 
            // pSets
            // 
            this.pSets.BackColor = System.Drawing.Color.Transparent;
            this.pSets.Controls.Add(this.btSettings);
            this.pSets.Controls.Add(this.btTrueCMountDism);
            this.pSets.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSets.Location = new System.Drawing.Point(5, 5);
            this.pSets.Name = "pSets";
            this.pSets.Size = new System.Drawing.Size(564, 30);
            this.pSets.TabIndex = 4;
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(486, 3);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(75, 23);
            this.btSettings.TabIndex = 7;
            this.btSettings.Text = "Settings";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 414);
            this.Controls.Add(this.pLoginAction);
            this.Controls.Add(this.pListNames);
            this.Controls.Add(this.pCustomAction);
            this.Controls.Add(this.pSets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 453);
            this.MinimumSize = new System.Drawing.Size(590, 453);
            this.Name = "LoginView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Viewer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginView_FormClosing);
            this.pListNames.ResumeLayout(false);
            this.pCustomAction.ResumeLayout(false);
            this.pCustomAction.PerformLayout();
            this.pSets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Panel pLoginAction;
        private System.Windows.Forms.Panel pListNames;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel pCustomAction;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchReset;
        private System.Windows.Forms.Button btTrueCMountDism;
        private System.Windows.Forms.Panel pSets;
        private System.Windows.Forms.Button btSettings;
    }
}

