namespace Workplace_Viewer
{
    partial class SettingWindow
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
            this.gBoxTrueC = new System.Windows.Forms.GroupBox();
            this.tLPTrueC = new System.Windows.Forms.TableLayoutPanel();
            this.btGetExePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBExePath = new System.Windows.Forms.TextBox();
            this.tBFilePath = new System.Windows.Forms.TextBox();
            this.btGetFilePath = new System.Windows.Forms.Button();
            this.cBoxDriveLetters = new System.Windows.Forms.ComboBox();
            this.pAction = new System.Windows.Forms.Panel();
            this.lNoSaveInfo = new System.Windows.Forms.Label();
            this.btSetSave = new System.Windows.Forms.Button();
            this.btSetCancel = new System.Windows.Forms.Button();
            this.getVolume = new System.Windows.Forms.OpenFileDialog();
            this.getExe = new System.Windows.Forms.OpenFileDialog();
            this.gBoxXml = new System.Windows.Forms.GroupBox();
            this.tLPXml = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tBXmlPath = new System.Windows.Forms.TextBox();
            this.checkBAutoLogin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBAutoLogout = new System.Windows.Forms.CheckBox();
            this.tabCSettings = new System.Windows.Forms.TabControl();
            this.tabPLogin = new System.Windows.Forms.TabPage();
            this.tabPToDo = new System.Windows.Forms.TabPage();
            this.tabPGeneral = new System.Windows.Forms.TabPage();
            this.tabPNode = new System.Windows.Forms.TabPage();
            this.tabPExpanses = new System.Windows.Forms.TabPage();
            this.gBoxTrueC.SuspendLayout();
            this.tLPTrueC.SuspendLayout();
            this.pAction.SuspendLayout();
            this.gBoxXml.SuspendLayout();
            this.tLPXml.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCSettings.SuspendLayout();
            this.tabPLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxTrueC
            // 
            this.gBoxTrueC.Controls.Add(this.tLPTrueC);
            this.gBoxTrueC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxTrueC.Location = new System.Drawing.Point(3, 28);
            this.gBoxTrueC.Name = "gBoxTrueC";
            this.gBoxTrueC.Padding = new System.Windows.Forms.Padding(5);
            this.gBoxTrueC.Size = new System.Drawing.Size(564, 120);
            this.gBoxTrueC.TabIndex = 11;
            this.gBoxTrueC.TabStop = false;
            this.gBoxTrueC.Text = "TrueCrypt";
            // 
            // tLPTrueC
            // 
            this.tLPTrueC.ColumnCount = 3;
            this.tLPTrueC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tLPTrueC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPTrueC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tLPTrueC.Controls.Add(this.btGetExePath, 2, 0);
            this.tLPTrueC.Controls.Add(this.label3, 0, 2);
            this.tLPTrueC.Controls.Add(this.label1, 0, 0);
            this.tLPTrueC.Controls.Add(this.label2, 0, 1);
            this.tLPTrueC.Controls.Add(this.tBExePath, 1, 0);
            this.tLPTrueC.Controls.Add(this.tBFilePath, 1, 1);
            this.tLPTrueC.Controls.Add(this.btGetFilePath, 2, 1);
            this.tLPTrueC.Controls.Add(this.cBoxDriveLetters, 1, 2);
            this.tLPTrueC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPTrueC.Location = new System.Drawing.Point(5, 18);
            this.tLPTrueC.Name = "tLPTrueC";
            this.tLPTrueC.RowCount = 4;
            this.tLPTrueC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tLPTrueC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tLPTrueC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tLPTrueC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPTrueC.Size = new System.Drawing.Size(554, 97);
            this.tLPTrueC.TabIndex = 0;
            // 
            // btGetExePath
            // 
            this.btGetExePath.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGetExePath.Location = new System.Drawing.Point(522, 2);
            this.btGetExePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btGetExePath.Name = "btGetExePath";
            this.btGetExePath.Size = new System.Drawing.Size(28, 22);
            this.btGetExePath.TabIndex = 0;
            this.btGetExePath.Text = "...";
            this.btGetExePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGetExePath.UseVisualStyleBackColor = true;
            this.btGetExePath.Click += new System.EventHandler(this.btGetExePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mount Drive:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Exe:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path Mount-File:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBExePath
            // 
            this.tBExePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBExePath.Location = new System.Drawing.Point(142, 3);
            this.tBExePath.Name = "tBExePath";
            this.tBExePath.ReadOnly = true;
            this.tBExePath.Size = new System.Drawing.Size(375, 20);
            this.tBExePath.TabIndex = 4;
            this.tBExePath.TabStop = false;
            // 
            // tBFilePath
            // 
            this.tBFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBFilePath.Location = new System.Drawing.Point(142, 28);
            this.tBFilePath.Name = "tBFilePath";
            this.tBFilePath.ReadOnly = true;
            this.tBFilePath.Size = new System.Drawing.Size(375, 20);
            this.tBFilePath.TabIndex = 5;
            this.tBFilePath.TabStop = false;
            // 
            // btGetFilePath
            // 
            this.btGetFilePath.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGetFilePath.Location = new System.Drawing.Point(522, 27);
            this.btGetFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btGetFilePath.Name = "btGetFilePath";
            this.btGetFilePath.Size = new System.Drawing.Size(28, 22);
            this.btGetFilePath.TabIndex = 1;
            this.btGetFilePath.Text = "...";
            this.btGetFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGetFilePath.UseVisualStyleBackColor = true;
            this.btGetFilePath.Click += new System.EventHandler(this.btGetFilePath_Click);
            // 
            // cBoxDriveLetters
            // 
            this.cBoxDriveLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDriveLetters.FormattingEnabled = true;
            this.cBoxDriveLetters.Location = new System.Drawing.Point(142, 53);
            this.cBoxDriveLetters.Name = "cBoxDriveLetters";
            this.cBoxDriveLetters.Size = new System.Drawing.Size(47, 21);
            this.cBoxDriveLetters.TabIndex = 2;
            // 
            // pAction
            // 
            this.pAction.Controls.Add(this.lNoSaveInfo);
            this.pAction.Controls.Add(this.btSetSave);
            this.pAction.Controls.Add(this.btSetCancel);
            this.pAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAction.Location = new System.Drawing.Point(5, 252);
            this.pAction.Name = "pAction";
            this.pAction.Size = new System.Drawing.Size(578, 49);
            this.pAction.TabIndex = 0;
            // 
            // lNoSaveInfo
            // 
            this.lNoSaveInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lNoSaveInfo.Image = global::Login_Viewer.Properties.Resources.sign_warning_icon;
            this.lNoSaveInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lNoSaveInfo.Location = new System.Drawing.Point(0, 0);
            this.lNoSaveInfo.Name = "lNoSaveInfo";
            this.lNoSaveInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lNoSaveInfo.Size = new System.Drawing.Size(227, 49);
            this.lNoSaveInfo.TabIndex = 10;
            this.lNoSaveInfo.Text = "No changes while  mounted possible!";
            this.lNoSaveInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lNoSaveInfo.Visible = false;
            // 
            // btSetSave
            // 
            this.btSetSave.Image = global::Login_Viewer.Properties.Resources.Save_icon_24;
            this.btSetSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSetSave.Location = new System.Drawing.Point(263, 8);
            this.btSetSave.Name = "btSetSave";
            this.btSetSave.Size = new System.Drawing.Size(75, 32);
            this.btSetSave.TabIndex = 4;
            this.btSetSave.Text = "Save";
            this.btSetSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSetSave.UseVisualStyleBackColor = true;
            this.btSetSave.Click += new System.EventHandler(this.btSetSave_Click);
            // 
            // btSetCancel
            // 
            this.btSetCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSetCancel.Image = global::Login_Viewer.Properties.Resources.Cancel_icon_24;
            this.btSetCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSetCancel.Location = new System.Drawing.Point(344, 8);
            this.btSetCancel.Name = "btSetCancel";
            this.btSetCancel.Size = new System.Drawing.Size(75, 32);
            this.btSetCancel.TabIndex = 5;
            this.btSetCancel.TabStop = false;
            this.btSetCancel.Text = "Cancel";
            this.btSetCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSetCancel.UseVisualStyleBackColor = true;
            this.btSetCancel.Click += new System.EventHandler(this.btSetCancel_Click);
            // 
            // getVolume
            // 
            this.getVolume.AddExtension = false;
            this.getVolume.FileName = "volume.tc";
            this.getVolume.Filter = "TrueCryp Volume (*.tc)|*.tc";
            this.getVolume.Title = "Select a TrueCrypt Volume";
            // 
            // getExe
            // 
            this.getExe.FileName = "trueCrypt.exe";
            this.getExe.Filter = "TrueCryp Exe (*.exe)|*.exe";
            // 
            // gBoxXml
            // 
            this.gBoxXml.Controls.Add(this.tLPXml);
            this.gBoxXml.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxXml.Location = new System.Drawing.Point(3, 148);
            this.gBoxXml.Name = "gBoxXml";
            this.gBoxXml.Size = new System.Drawing.Size(564, 65);
            this.gBoxXml.TabIndex = 12;
            this.gBoxXml.TabStop = false;
            this.gBoxXml.Text = "Login XML";
            // 
            // tLPXml
            // 
            this.tLPXml.ColumnCount = 3;
            this.tLPXml.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tLPXml.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPXml.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tLPXml.Controls.Add(this.label5, 0, 0);
            this.tLPXml.Controls.Add(this.tBXmlPath, 1, 0);
            this.tLPXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPXml.Location = new System.Drawing.Point(3, 16);
            this.tLPXml.Name = "tLPXml";
            this.tLPXml.RowCount = 2;
            this.tLPXml.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tLPXml.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tLPXml.Size = new System.Drawing.Size(558, 46);
            this.tLPXml.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Relative xml-path:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBXmlPath
            // 
            this.tBXmlPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBXmlPath.Location = new System.Drawing.Point(142, 3);
            this.tBXmlPath.Name = "tBXmlPath";
            this.tBXmlPath.Size = new System.Drawing.Size(379, 20);
            this.tBXmlPath.TabIndex = 3;
            // 
            // checkBAutoLogin
            // 
            this.checkBAutoLogin.AutoSize = true;
            this.checkBAutoLogin.Location = new System.Drawing.Point(11, 4);
            this.checkBAutoLogin.Name = "checkBAutoLogin";
            this.checkBAutoLogin.Size = new System.Drawing.Size(115, 17);
            this.checkBAutoLogin.TabIndex = 1;
            this.checkBAutoLogin.Text = "Auto-Login on start";
            this.checkBAutoLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBAutoLogout);
            this.panel1.Controls.Add(this.checkBAutoLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 25);
            this.panel1.TabIndex = 1;
            // 
            // checkBAutoLogout
            // 
            this.checkBAutoLogout.AutoSize = true;
            this.checkBAutoLogout.Location = new System.Drawing.Point(147, 4);
            this.checkBAutoLogout.Name = "checkBAutoLogout";
            this.checkBAutoLogout.Size = new System.Drawing.Size(135, 17);
            this.checkBAutoLogout.TabIndex = 2;
            this.checkBAutoLogout.Text = "Auto-Logout on closing";
            this.checkBAutoLogout.UseVisualStyleBackColor = true;
            // 
            // tabCSettings
            // 
            this.tabCSettings.Controls.Add(this.tabPGeneral);
            this.tabCSettings.Controls.Add(this.tabPLogin);
            this.tabCSettings.Controls.Add(this.tabPToDo);
            this.tabCSettings.Controls.Add(this.tabPNode);
            this.tabCSettings.Controls.Add(this.tabPExpanses);
            this.tabCSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCSettings.Location = new System.Drawing.Point(5, 5);
            this.tabCSettings.Name = "tabCSettings";
            this.tabCSettings.SelectedIndex = 0;
            this.tabCSettings.Size = new System.Drawing.Size(578, 247);
            this.tabCSettings.TabIndex = 11;
            // 
            // tabPLogin
            // 
            this.tabPLogin.Controls.Add(this.gBoxXml);
            this.tabPLogin.Controls.Add(this.gBoxTrueC);
            this.tabPLogin.Controls.Add(this.panel1);
            this.tabPLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPLogin.Name = "tabPLogin";
            this.tabPLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPLogin.Size = new System.Drawing.Size(570, 221);
            this.tabPLogin.TabIndex = 0;
            this.tabPLogin.Text = "Login";
            this.tabPLogin.UseVisualStyleBackColor = true;
            // 
            // tabPToDo
            // 
            this.tabPToDo.Location = new System.Drawing.Point(4, 22);
            this.tabPToDo.Name = "tabPToDo";
            this.tabPToDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPToDo.Size = new System.Drawing.Size(570, 221);
            this.tabPToDo.TabIndex = 1;
            this.tabPToDo.Text = "ToDo";
            this.tabPToDo.UseVisualStyleBackColor = true;
            // 
            // tabPGeneral
            // 
            this.tabPGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPGeneral.Name = "tabPGeneral";
            this.tabPGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGeneral.Size = new System.Drawing.Size(570, 221);
            this.tabPGeneral.TabIndex = 2;
            this.tabPGeneral.Text = "General";
            this.tabPGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPNode
            // 
            this.tabPNode.Location = new System.Drawing.Point(4, 22);
            this.tabPNode.Name = "tabPNode";
            this.tabPNode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPNode.Size = new System.Drawing.Size(570, 221);
            this.tabPNode.TabIndex = 3;
            this.tabPNode.Text = "Node";
            this.tabPNode.UseVisualStyleBackColor = true;
            // 
            // tabPExpanses
            // 
            this.tabPExpanses.Location = new System.Drawing.Point(4, 22);
            this.tabPExpanses.Name = "tabPExpanses";
            this.tabPExpanses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPExpanses.Size = new System.Drawing.Size(570, 221);
            this.tabPExpanses.TabIndex = 4;
            this.tabPExpanses.Text = "Expenses";
            this.tabPExpanses.UseVisualStyleBackColor = true;
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btSetCancel;
            this.ClientSize = new System.Drawing.Size(588, 306);
            this.Controls.Add(this.tabCSettings);
            this.Controls.Add(this.pAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.gBoxTrueC.ResumeLayout(false);
            this.tLPTrueC.ResumeLayout(false);
            this.tLPTrueC.PerformLayout();
            this.pAction.ResumeLayout(false);
            this.gBoxXml.ResumeLayout(false);
            this.tLPXml.ResumeLayout(false);
            this.tLPXml.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCSettings.ResumeLayout(false);
            this.tabPLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxTrueC;
        private System.Windows.Forms.TableLayoutPanel tLPTrueC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pAction;
        private System.Windows.Forms.Button btSetSave;
        private System.Windows.Forms.Button btSetCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBExePath;
        private System.Windows.Forms.TextBox tBFilePath;
        private System.Windows.Forms.Button btGetFilePath;
        private System.Windows.Forms.Button btGetExePath;
        private System.Windows.Forms.OpenFileDialog getVolume;
        private System.Windows.Forms.OpenFileDialog getExe;
        private System.Windows.Forms.GroupBox gBoxXml;
        private System.Windows.Forms.TableLayoutPanel tLPXml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBXmlPath;
        private System.Windows.Forms.ComboBox cBoxDriveLetters;
        private System.Windows.Forms.Label lNoSaveInfo;
        private System.Windows.Forms.CheckBox checkBAutoLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBAutoLogout;
        private System.Windows.Forms.TabControl tabCSettings;
        private System.Windows.Forms.TabPage tabPGeneral;
        private System.Windows.Forms.TabPage tabPLogin;
        private System.Windows.Forms.TabPage tabPToDo;
        private System.Windows.Forms.TabPage tabPNode;
        private System.Windows.Forms.TabPage tabPExpanses;
    }
}