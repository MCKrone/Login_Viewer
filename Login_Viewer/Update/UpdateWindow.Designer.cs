namespace Workplace_Viewer
{
    partial class UpdateWindow
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
            this.pMain = new System.Windows.Forms.Panel();
            this.pAction = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tLPUpdates = new System.Windows.Forms.TableLayoutPanel();
            this.pPBar = new System.Windows.Forms.Panel();
            this.pBarUpdates = new System.Windows.Forms.ProgressBar();
            this.lCurrentV = new System.Windows.Forms.Label();
            this.lLatestV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tViewChanges = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.pAction.SuspendLayout();
            this.tLPUpdates.SuspendLayout();
            this.pPBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.pPBar);
            this.pMain.Controls.Add(this.tLPUpdates);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(284, 302);
            this.pMain.TabIndex = 0;
            // 
            // pAction
            // 
            this.pAction.Controls.Add(this.label4);
            this.pAction.Controls.Add(this.btCancel);
            this.pAction.Controls.Add(this.btStart);
            this.pAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAction.Location = new System.Drawing.Point(0, 265);
            this.pAction.Name = "pAction";
            this.pAction.Size = new System.Drawing.Size(284, 37);
            this.pAction.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(122, 7);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(203, 7);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tLPUpdates
            // 
            this.tLPUpdates.ColumnCount = 2;
            this.tLPUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPUpdates.Controls.Add(this.lCurrentV, 0, 0);
            this.tLPUpdates.Controls.Add(this.lLatestV, 1, 0);
            this.tLPUpdates.Controls.Add(this.label3, 0, 1);
            this.tLPUpdates.Controls.Add(this.tViewChanges, 0, 2);
            this.tLPUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPUpdates.Location = new System.Drawing.Point(0, 0);
            this.tLPUpdates.Name = "tLPUpdates";
            this.tLPUpdates.RowCount = 4;
            this.tLPUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tLPUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tLPUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tLPUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPUpdates.Size = new System.Drawing.Size(284, 302);
            this.tLPUpdates.TabIndex = 1;
            // 
            // pPBar
            // 
            this.pPBar.Controls.Add(this.label1);
            this.pPBar.Controls.Add(this.pBarUpdates);
            this.pPBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPBar.Location = new System.Drawing.Point(0, 236);
            this.pPBar.Name = "pPBar";
            this.pPBar.Size = new System.Drawing.Size(284, 66);
            this.pPBar.TabIndex = 0;
            // 
            // pBarUpdates
            // 
            this.pBarUpdates.Location = new System.Drawing.Point(57, 4);
            this.pBarUpdates.Name = "pBarUpdates";
            this.pBarUpdates.Size = new System.Drawing.Size(224, 22);
            this.pBarUpdates.TabIndex = 0;
            // 
            // lCurrentV
            // 
            this.lCurrentV.AutoSize = true;
            this.lCurrentV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lCurrentV.Location = new System.Drawing.Point(3, 0);
            this.lCurrentV.Name = "lCurrentV";
            this.lCurrentV.Size = new System.Drawing.Size(81, 35);
            this.lCurrentV.TabIndex = 0;
            this.lCurrentV.Text = "Current version:";
            this.lCurrentV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lLatestV
            // 
            this.lLatestV.AutoSize = true;
            this.lLatestV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lLatestV.Location = new System.Drawing.Point(145, 0);
            this.lLatestV.Name = "lLatestV";
            this.lLatestV.Size = new System.Drawing.Size(76, 35);
            this.lLatestV.TabIndex = 1;
            this.lLatestV.Text = "Latest version:";
            this.lLatestV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Changes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tViewChanges
            // 
            this.tLPUpdates.SetColumnSpan(this.tViewChanges, 2);
            this.tViewChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tViewChanges.Location = new System.Drawing.Point(3, 73);
            this.tViewChanges.Name = "tViewChanges";
            this.tViewChanges.Size = new System.Drawing.Size(278, 156);
            this.tViewChanges.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Image = global::Login_Viewer.Properties.Resources.sign_warning_icon;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(101, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Obligatory!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "State:";
            // 
            // UpdateWindow
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.pAction);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateWindow";
            this.TopMost = true;
            this.pMain.ResumeLayout(false);
            this.pAction.ResumeLayout(false);
            this.tLPUpdates.ResumeLayout(false);
            this.tLPUpdates.PerformLayout();
            this.pPBar.ResumeLayout(false);
            this.pPBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pPBar;
        private System.Windows.Forms.ProgressBar pBarUpdates;
        private System.Windows.Forms.TableLayoutPanel tLPUpdates;
        private System.Windows.Forms.Label lCurrentV;
        private System.Windows.Forms.Label lLatestV;
        private System.Windows.Forms.Panel pAction;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tViewChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}