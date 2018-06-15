namespace Login_Viewer
{
    partial class Login_V
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_V));
            this.pListNames = new System.Windows.Forms.Panel();
            this.gBoxLogs = new System.Windows.Forms.GroupBox();
            this.lViewLogs = new System.Windows.Forms.ListView();
            this.pOrder = new System.Windows.Forms.Panel();
            this.btOrderZa = new System.Windows.Forms.Button();
            this.btOrderGroups = new System.Windows.Forms.Button();
            this.btOrderAz = new System.Windows.Forms.Button();
            this.pAddLog = new System.Windows.Forms.Panel();
            this.btAddLog = new System.Windows.Forms.Button();
            this.pSearch = new System.Windows.Forms.Panel();
            this.btCancelSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pSets = new System.Windows.Forms.Panel();
            this.bInfo = new System.Windows.Forms.Button();
            this.pLoginAction = new System.Windows.Forms.Panel();
            this.pCustomAction = new System.Windows.Forms.Panel();
            this.pFavorites = new System.Windows.Forms.Panel();
            this.gBoxFavs = new System.Windows.Forms.GroupBox();
            this.lViewFavorites = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.iListLog16 = new System.Windows.Forms.ImageList(this.components);
            this.pListNames.SuspendLayout();
            this.gBoxLogs.SuspendLayout();
            this.pOrder.SuspendLayout();
            this.pAddLog.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.pSets.SuspendLayout();
            this.pLoginAction.SuspendLayout();
            this.pFavorites.SuspendLayout();
            this.gBoxFavs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pListNames
            // 
            this.pListNames.BackColor = System.Drawing.Color.Transparent;
            this.pListNames.Controls.Add(this.gBoxLogs);
            this.pListNames.Controls.Add(this.pSets);
            this.pListNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.pListNames.ForeColor = System.Drawing.Color.Black;
            this.pListNames.Location = new System.Drawing.Point(0, 0);
            this.pListNames.Name = "pListNames";
            this.pListNames.Padding = new System.Windows.Forms.Padding(5);
            this.pListNames.Size = new System.Drawing.Size(163, 541);
            this.pListNames.TabIndex = 5;
            // 
            // gBoxLogs
            // 
            this.gBoxLogs.BackColor = System.Drawing.Color.Transparent;
            this.gBoxLogs.Controls.Add(this.lViewLogs);
            this.gBoxLogs.Controls.Add(this.pOrder);
            this.gBoxLogs.Controls.Add(this.pAddLog);
            this.gBoxLogs.Controls.Add(this.pSearch);
            this.gBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxLogs.Location = new System.Drawing.Point(5, 56);
            this.gBoxLogs.Name = "gBoxLogs";
            this.gBoxLogs.Size = new System.Drawing.Size(153, 480);
            this.gBoxLogs.TabIndex = 8;
            this.gBoxLogs.TabStop = false;
            this.gBoxLogs.Text = "Logins";
            // 
            // lViewLogs
            // 
            this.lViewLogs.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lViewLogs.BackColor = System.Drawing.SystemColors.Control;
            this.lViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lViewLogs.FullRowSelect = true;
            this.lViewLogs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lViewLogs.Location = new System.Drawing.Point(3, 65);
            this.lViewLogs.MultiSelect = false;
            this.lViewLogs.Name = "lViewLogs";
            this.lViewLogs.Size = new System.Drawing.Size(147, 375);
            this.lViewLogs.SmallImageList = this.iListLog16;
            this.lViewLogs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lViewLogs.TabIndex = 2;
            this.lViewLogs.UseCompatibleStateImageBehavior = false;
            this.lViewLogs.View = System.Windows.Forms.View.SmallIcon;
            this.lViewLogs.Click += new System.EventHandler(this.showLogin);
            // 
            // pOrder
            // 
            this.pOrder.Controls.Add(this.btOrderZa);
            this.pOrder.Controls.Add(this.btOrderGroups);
            this.pOrder.Controls.Add(this.btOrderAz);
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.Location = new System.Drawing.Point(3, 34);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(147, 31);
            this.pOrder.TabIndex = 5;
            // 
            // btOrderZa
            // 
            this.btOrderZa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderZa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btOrderZa.FlatAppearance.BorderSize = 0;
            this.btOrderZa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderZa.Image = global::Login_Viewer.Properties.Resources.order_za;
            this.btOrderZa.Location = new System.Drawing.Point(59, 3);
            this.btOrderZa.Name = "btOrderZa";
            this.btOrderZa.Size = new System.Drawing.Size(35, 25);
            this.btOrderZa.TabIndex = 2;
            this.btOrderZa.UseVisualStyleBackColor = true;
            this.btOrderZa.Click += new System.EventHandler(this.btOrderZa_Click);
            // 
            // btOrderGroups
            // 
            this.btOrderGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderGroups.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btOrderGroups.FlatAppearance.BorderSize = 0;
            this.btOrderGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderGroups.Image = global::Login_Viewer.Properties.Resources.order_group;
            this.btOrderGroups.Location = new System.Drawing.Point(110, 3);
            this.btOrderGroups.Name = "btOrderGroups";
            this.btOrderGroups.Size = new System.Drawing.Size(35, 25);
            this.btOrderGroups.TabIndex = 1;
            this.btOrderGroups.UseVisualStyleBackColor = true;
            this.btOrderGroups.Click += new System.EventHandler(this.btOrderGroups_Click);
            // 
            // btOrderAz
            // 
            this.btOrderAz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOrderAz.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btOrderAz.FlatAppearance.BorderSize = 0;
            this.btOrderAz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrderAz.Image = global::Login_Viewer.Properties.Resources.order_az;
            this.btOrderAz.Location = new System.Drawing.Point(2, 3);
            this.btOrderAz.Name = "btOrderAz";
            this.btOrderAz.Size = new System.Drawing.Size(35, 25);
            this.btOrderAz.TabIndex = 0;
            this.btOrderAz.UseVisualStyleBackColor = true;
            this.btOrderAz.Click += new System.EventHandler(this.btOrderAz_Click);
            // 
            // pAddLog
            // 
            this.pAddLog.Controls.Add(this.btAddLog);
            this.pAddLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAddLog.Location = new System.Drawing.Point(3, 440);
            this.pAddLog.Name = "pAddLog";
            this.pAddLog.Padding = new System.Windows.Forms.Padding(1);
            this.pAddLog.Size = new System.Drawing.Size(147, 37);
            this.pAddLog.TabIndex = 0;
            // 
            // btAddLog
            // 
            this.btAddLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAddLog.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btAddLog.FlatAppearance.BorderSize = 0;
            this.btAddLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btAddLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btAddLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddLog.Image = global::Login_Viewer.Properties.Resources.Files_Add_File_icon;
            this.btAddLog.Location = new System.Drawing.Point(1, 1);
            this.btAddLog.Margin = new System.Windows.Forms.Padding(6);
            this.btAddLog.Name = "btAddLog";
            this.btAddLog.Padding = new System.Windows.Forms.Padding(5);
            this.btAddLog.Size = new System.Drawing.Size(145, 35);
            this.btAddLog.TabIndex = 0;
            this.btAddLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddLog.UseVisualStyleBackColor = true;
            this.btAddLog.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.White;
            this.pSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSearch.Controls.Add(this.btCancelSearch);
            this.pSearch.Controls.Add(this.textBoxSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(3, 16);
            this.pSearch.Name = "pSearch";
            this.pSearch.Padding = new System.Windows.Forms.Padding(1);
            this.pSearch.Size = new System.Drawing.Size(147, 18);
            this.pSearch.TabIndex = 4;
            // 
            // btCancelSearch
            // 
            this.btCancelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancelSearch.FlatAppearance.BorderSize = 0;
            this.btCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelSearch.Image = global::Login_Viewer.Properties.Resources.cancelSearch;
            this.btCancelSearch.Location = new System.Drawing.Point(130, 1);
            this.btCancelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btCancelSearch.Name = "btCancelSearch";
            this.btCancelSearch.Size = new System.Drawing.Size(14, 14);
            this.btCancelSearch.TabIndex = 3;
            this.btCancelSearch.TabStop = false;
            this.btCancelSearch.Text = "x";
            this.btCancelSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelSearch.UseVisualStyleBackColor = true;
            this.btCancelSearch.Click += new System.EventHandler(this.btCancelSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(1, 1);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(143, 13);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.Text = "Search...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // pSets
            // 
            this.pSets.BackColor = System.Drawing.Color.Transparent;
            this.pSets.Controls.Add(this.bInfo);
            this.pSets.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSets.Location = new System.Drawing.Point(5, 5);
            this.pSets.Name = "pSets";
            this.pSets.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pSets.Size = new System.Drawing.Size(153, 51);
            this.pSets.TabIndex = 7;
            // 
            // bInfo
            // 
            this.bInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.bInfo.FlatAppearance.BorderSize = 0;
            this.bInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInfo.Image = global::Login_Viewer.Properties.Resources.Info_icon_32;
            this.bInfo.Location = new System.Drawing.Point(102, 5);
            this.bInfo.Name = "bInfo";
            this.bInfo.Size = new System.Drawing.Size(51, 41);
            this.bInfo.TabIndex = 8;
            this.bInfo.UseVisualStyleBackColor = true;
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // pLoginAction
            // 
            this.pLoginAction.BackColor = System.Drawing.Color.Transparent;
            this.pLoginAction.Controls.Add(this.pCustomAction);
            this.pLoginAction.Controls.Add(this.pFavorites);
            this.pLoginAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoginAction.Location = new System.Drawing.Point(163, 0);
            this.pLoginAction.Name = "pLoginAction";
            this.pLoginAction.Padding = new System.Windows.Forms.Padding(5);
            this.pLoginAction.Size = new System.Drawing.Size(367, 541);
            this.pLoginAction.TabIndex = 7;
            // 
            // pCustomAction
            // 
            this.pCustomAction.BackColor = System.Drawing.Color.Transparent;
            this.pCustomAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCustomAction.Location = new System.Drawing.Point(5, 77);
            this.pCustomAction.Name = "pCustomAction";
            this.pCustomAction.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pCustomAction.Size = new System.Drawing.Size(357, 459);
            this.pCustomAction.TabIndex = 5;
            // 
            // pFavorites
            // 
            this.pFavorites.BackColor = System.Drawing.Color.Transparent;
            this.pFavorites.Controls.Add(this.gBoxFavs);
            this.pFavorites.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFavorites.Location = new System.Drawing.Point(5, 5);
            this.pFavorites.Name = "pFavorites";
            this.pFavorites.Size = new System.Drawing.Size(357, 72);
            this.pFavorites.TabIndex = 3;
            // 
            // gBoxFavs
            // 
            this.gBoxFavs.BackColor = System.Drawing.Color.Transparent;
            this.gBoxFavs.Controls.Add(this.lViewFavorites);
            this.gBoxFavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxFavs.Location = new System.Drawing.Point(0, 0);
            this.gBoxFavs.Name = "gBoxFavs";
            this.gBoxFavs.Padding = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.gBoxFavs.Size = new System.Drawing.Size(357, 72);
            this.gBoxFavs.TabIndex = 1;
            this.gBoxFavs.TabStop = false;
            this.gBoxFavs.Text = "Favorites";
            // 
            // lViewFavorites
            // 
            this.lViewFavorites.BackColor = System.Drawing.SystemColors.Control;
            this.lViewFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lViewFavorites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lViewFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lViewFavorites.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lViewFavorites.Location = new System.Drawing.Point(1, 14);
            this.lViewFavorites.Name = "lViewFavorites";
            this.lViewFavorites.ShowGroups = false;
            this.lViewFavorites.Size = new System.Drawing.Size(355, 56);
            this.lViewFavorites.SmallImageList = this.iListLog16;
            this.lViewFavorites.TabIndex = 0;
            this.lViewFavorites.UseCompatibleStateImageBehavior = false;
            this.lViewFavorites.View = System.Windows.Forms.View.SmallIcon;
            this.lViewFavorites.Click += new System.EventHandler(this.showLogin);
            // 
            // iListLog16
            // 
            this.iListLog16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListLog16.ImageStream")));
            this.iListLog16.TransparentColor = System.Drawing.Color.Transparent;
            this.iListLog16.Images.SetKeyName(0, "16_none_keyring-icon.png");
            this.iListLog16.Images.SetKeyName(1, "16_event_City-Building-icon.png");
            this.iListLog16.Images.SetKeyName(2, "16_fun_Smiley-9-icon.png");
            this.iListLog16.Images.SetKeyName(3, "16_game_games-icon.png");
            this.iListLog16.Images.SetKeyName(4, "16_health_flag-red-cross-icon.png");
            this.iListLog16.Images.SetKeyName(5, "16_home_1-Normal-Home-icon.png");
            this.iListLog16.Images.SetKeyName(6, "16_knowledge_Books-icon.png");
            this.iListLog16.Images.SetKeyName(7, "16_mail_mail-icon.png");
            this.iListLog16.Images.SetKeyName(8, "16_management_App-package-icon.png");
            this.iListLog16.Images.SetKeyName(9, "16_mobile_iPhone-icon.png");
            this.iListLog16.Images.SetKeyName(10, "16_music_AoA-Audio-Extractor-icon.png");
            this.iListLog16.Images.SetKeyName(11, "16_payment_money-icon.png");
            this.iListLog16.Images.SetKeyName(12, "16_service_info-icon.png");
            this.iListLog16.Images.SetKeyName(13, "16_shop_shop-cart-down-icon.png");
            this.iListLog16.Images.SetKeyName(14, "16_social_Windows-Messenger-icon.png");
            this.iListLog16.Images.SetKeyName(15, "16_software_Very-Basic-Code-icon.png");
            this.iListLog16.Images.SetKeyName(16, "16_student_Users-Student-Filled-icon.png");
            this.iListLog16.Images.SetKeyName(17, "16_travel_Transport-Airplane-Take-Off-icon.png");
            this.iListLog16.Images.SetKeyName(18, "16_tv_Tv-icon.png");
            this.iListLog16.Images.SetKeyName(19, "16_work_briefcase-icon.png");
            this.iListLog16.Images.SetKeyName(20, "16_food_burger-icon.png");
            this.iListLog16.Images.SetKeyName(21, "16_tu_dd.png");
            // 
            // Login_V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pLoginAction);
            this.Controls.Add(this.pListNames);
            this.Name = "Login_V";
            this.Size = new System.Drawing.Size(530, 541);
            this.pListNames.ResumeLayout(false);
            this.gBoxLogs.ResumeLayout(false);
            this.pOrder.ResumeLayout(false);
            this.pAddLog.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pSets.ResumeLayout(false);
            this.pLoginAction.ResumeLayout(false);
            this.pFavorites.ResumeLayout(false);
            this.gBoxFavs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pListNames;
        private System.Windows.Forms.GroupBox gBoxLogs;
        private System.Windows.Forms.ListView lViewLogs;
        private System.Windows.Forms.Panel pOrder;
        private System.Windows.Forms.Button btOrderZa;
        private System.Windows.Forms.Button btOrderGroups;
        private System.Windows.Forms.Button btOrderAz;
        private System.Windows.Forms.Panel pAddLog;
        private System.Windows.Forms.Button btAddLog;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Button btCancelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel pSets;
        private System.Windows.Forms.Button bInfo;
        private System.Windows.Forms.Panel pLoginAction;
        private System.Windows.Forms.Panel pCustomAction;
        private System.Windows.Forms.Panel pFavorites;
        private System.Windows.Forms.GroupBox gBoxFavs;
        private System.Windows.Forms.ListView lViewFavorites;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ImageList iListLog16;
    }
}
