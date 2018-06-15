namespace Login_Viewer.Login_Content
{
    partial class Content
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBoxLog_Content = new System.Windows.Forms.GroupBox();
            this.pLog_Content = new System.Windows.Forms.Panel();
            this.flowLPContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pLog_Actions = new System.Windows.Forms.Panel();
            this.btFavorite_Add = new System.Windows.Forms.Button();
            this.btFavorite_Remove = new System.Windows.Forms.Button();
            this.btLog_Edit = new System.Windows.Forms.Button();
            this.btLog_Remove = new System.Windows.Forms.Button();
            this.toolTipContent = new System.Windows.Forms.ToolTip(this.components);
            this.gBoxLog_Content.SuspendLayout();
            this.pLog_Content.SuspendLayout();
            this.pLog_Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxLog_Content
            // 
            this.gBoxLog_Content.BackColor = System.Drawing.Color.White;
            this.gBoxLog_Content.Controls.Add(this.pLog_Content);
            this.gBoxLog_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxLog_Content.Location = new System.Drawing.Point(0, 0);
            this.gBoxLog_Content.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.gBoxLog_Content.Name = "gBoxLog_Content";
            this.gBoxLog_Content.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.gBoxLog_Content.Size = new System.Drawing.Size(402, 454);
            this.gBoxLog_Content.TabIndex = 22;
            this.gBoxLog_Content.TabStop = false;
            this.gBoxLog_Content.Text = "Login - None";
            // 
            // pLog_Content
            // 
            this.pLog_Content.BackColor = System.Drawing.Color.Transparent;
            this.pLog_Content.Controls.Add(this.flowLPContent);
            this.pLog_Content.Controls.Add(this.pLog_Actions);
            this.pLog_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLog_Content.Location = new System.Drawing.Point(1, 13);
            this.pLog_Content.Name = "pLog_Content";
            this.pLog_Content.Padding = new System.Windows.Forms.Padding(2);
            this.pLog_Content.Size = new System.Drawing.Size(400, 440);
            this.pLog_Content.TabIndex = 1;
            // 
            // flowLPContent
            // 
            this.flowLPContent.BackColor = System.Drawing.Color.White;
            this.flowLPContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLPContent.Location = new System.Drawing.Point(2, 38);
            this.flowLPContent.Name = "flowLPContent";
            this.flowLPContent.Size = new System.Drawing.Size(396, 400);
            this.flowLPContent.TabIndex = 22;
            // 
            // pLog_Actions
            // 
            this.pLog_Actions.Controls.Add(this.btFavorite_Add);
            this.pLog_Actions.Controls.Add(this.btFavorite_Remove);
            this.pLog_Actions.Controls.Add(this.btLog_Edit);
            this.pLog_Actions.Controls.Add(this.btLog_Remove);
            this.pLog_Actions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLog_Actions.Location = new System.Drawing.Point(2, 2);
            this.pLog_Actions.Name = "pLog_Actions";
            this.pLog_Actions.Size = new System.Drawing.Size(396, 36);
            this.pLog_Actions.TabIndex = 21;
            // 
            // btFavorite_Add
            // 
            this.btFavorite_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFavorite_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btFavorite_Add.FlatAppearance.BorderSize = 0;
            this.btFavorite_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btFavorite_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btFavorite_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFavorite_Add.Image = global::Login_Viewer.Properties.Resources.fav_add_icon;
            this.btFavorite_Add.Location = new System.Drawing.Point(4, 5);
            this.btFavorite_Add.Name = "btFavorite_Add";
            this.btFavorite_Add.Size = new System.Drawing.Size(50, 27);
            this.btFavorite_Add.TabIndex = 1;
            this.toolTipContent.SetToolTip(this.btFavorite_Add, "Add Favorite");
            this.btFavorite_Add.UseVisualStyleBackColor = true;
            this.btFavorite_Add.Click += new System.EventHandler(this.btFavorite_Add_Click);
            // 
            // btFavorite_Remove
            // 
            this.btFavorite_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFavorite_Remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btFavorite_Remove.FlatAppearance.BorderSize = 0;
            this.btFavorite_Remove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btFavorite_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btFavorite_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFavorite_Remove.Image = global::Login_Viewer.Properties.Resources.fav_delete_icon;
            this.btFavorite_Remove.Location = new System.Drawing.Point(68, 5);
            this.btFavorite_Remove.Name = "btFavorite_Remove";
            this.btFavorite_Remove.Size = new System.Drawing.Size(50, 27);
            this.btFavorite_Remove.TabIndex = 2;
            this.toolTipContent.SetToolTip(this.btFavorite_Remove, "Remove Favorite");
            this.btFavorite_Remove.UseVisualStyleBackColor = true;
            this.btFavorite_Remove.Click += new System.EventHandler(this.btFavorite_Remove_Click);
            // 
            // btLog_Edit
            // 
            this.btLog_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btLog_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLog_Edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLog_Edit.FlatAppearance.BorderSize = 0;
            this.btLog_Edit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLog_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btLog_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLog_Edit.Image = global::Login_Viewer.Properties.Resources.Files_Edit_File_icon;
            this.btLog_Edit.Location = new System.Drawing.Point(150, 5);
            this.btLog_Edit.Name = "btLog_Edit";
            this.btLog_Edit.Size = new System.Drawing.Size(50, 27);
            this.btLog_Edit.TabIndex = 0;
            this.btLog_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipContent.SetToolTip(this.btLog_Edit, "Edit Login");
            this.btLog_Edit.UseVisualStyleBackColor = false;
            this.btLog_Edit.Click += new System.EventHandler(this.btLog_Edit_Click);
            // 
            // btLog_Remove
            // 
            this.btLog_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btLog_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLog_Remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLog_Remove.FlatAppearance.BorderSize = 0;
            this.btLog_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btLog_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLog_Remove.Image = global::Login_Viewer.Properties.Resources.Files_Delete_File_icon;
            this.btLog_Remove.Location = new System.Drawing.Point(213, 5);
            this.btLog_Remove.Name = "btLog_Remove";
            this.btLog_Remove.Size = new System.Drawing.Size(50, 27);
            this.btLog_Remove.TabIndex = 3;
            this.btLog_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipContent.SetToolTip(this.btLog_Remove, "Remove Login");
            this.btLog_Remove.UseVisualStyleBackColor = false;
            this.btLog_Remove.Click += new System.EventHandler(this.btLog_Remove_Click);
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBoxLog_Content);
            this.Name = "Content";
            this.Size = new System.Drawing.Size(402, 454);
            this.gBoxLog_Content.ResumeLayout(false);
            this.pLog_Content.ResumeLayout(false);
            this.pLog_Actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxLog_Content;
        private System.Windows.Forms.Panel pLog_Content;
        private System.Windows.Forms.Panel pLog_Actions;
        private System.Windows.Forms.Button btFavorite_Add;
        private System.Windows.Forms.Button btFavorite_Remove;
        private System.Windows.Forms.Button btLog_Edit;
        private System.Windows.Forms.Button btLog_Remove;
        private System.Windows.Forms.ToolTip toolTipContent;
        private System.Windows.Forms.FlowLayoutPanel flowLPContent;
    }
}
