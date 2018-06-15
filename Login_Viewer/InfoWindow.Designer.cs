namespace Login_Viewer
{
    partial class InfoWindows
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
            this.lChanges = new System.Windows.Forms.Label();
            this.flowLPActions = new System.Windows.Forms.FlowLayoutPanel();
            this.pInfo = new System.Windows.Forms.Panel();
            this.bImport = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.dataGVChanges = new System.Windows.Forms.DataGridView();
            this.Export = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flowLPActions.SuspendLayout();
            this.pInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // lChanges
            // 
            this.lChanges.AutoSize = true;
            this.lChanges.Location = new System.Drawing.Point(5, 5);
            this.lChanges.Name = "lChanges";
            this.lChanges.Size = new System.Drawing.Size(52, 13);
            this.lChanges.TabIndex = 2;
            this.lChanges.Text = "Changes:";
            // 
            // flowLPActions
            // 
            this.flowLPActions.Controls.Add(this.bClose);
            this.flowLPActions.Controls.Add(this.bImport);
            this.flowLPActions.Controls.Add(this.bExport);
            this.flowLPActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLPActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLPActions.Location = new System.Drawing.Point(10, 253);
            this.flowLPActions.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLPActions.Name = "flowLPActions";
            this.flowLPActions.Size = new System.Drawing.Size(664, 30);
            this.flowLPActions.TabIndex = 4;
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.lChanges);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInfo.Location = new System.Drawing.Point(10, 10);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(664, 23);
            this.pInfo.TabIndex = 5;
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(508, 3);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 0;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(427, 3);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 23);
            this.bExport.TabIndex = 1;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Location = new System.Drawing.Point(589, 3);
            this.bClose.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // dataGVChanges
            // 
            this.dataGVChanges.AllowUserToAddRows = false;
            this.dataGVChanges.AllowUserToDeleteRows = false;
            this.dataGVChanges.AllowUserToOrderColumns = true;
            this.dataGVChanges.AllowUserToResizeRows = false;
            this.dataGVChanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGVChanges.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGVChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGVChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Export});
            this.dataGVChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVChanges.Location = new System.Drawing.Point(10, 33);
            this.dataGVChanges.MultiSelect = false;
            this.dataGVChanges.Name = "dataGVChanges";
            this.dataGVChanges.RowHeadersVisible = false;
            this.dataGVChanges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGVChanges.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVChanges.ShowEditingIcon = false;
            this.dataGVChanges.Size = new System.Drawing.Size(664, 220);
            this.dataGVChanges.TabIndex = 3;
            // 
            // Export
            // 
            this.Export.HeaderText = "";
            this.Export.Name = "Export";
            this.Export.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Export.Width = 19;
            // 
            // InfoWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(684, 293);
            this.Controls.Add(this.dataGVChanges);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.flowLPActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InfoWindows";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Infos";
            this.flowLPActions.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVChanges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lChanges;
        private System.Windows.Forms.FlowLayoutPanel flowLPActions;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.DataGridView dataGVChanges;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Export;
    }
}