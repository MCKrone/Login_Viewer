namespace Login_Viewer
{
    partial class Content_Line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content_Line));
            this.lName = new System.Windows.Forms.Label();
            this.pContent = new System.Windows.Forms.Panel();
            this.bt1 = new System.Windows.Forms.Button();
            this.iListBt1 = new System.Windows.Forms.ImageList(this.components);
            this.bt2 = new System.Windows.Forms.Button();
            this.iListBt2 = new System.Windows.Forms.ImageList(this.components);
            this.pRight = new System.Windows.Forms.Panel();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pRight.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(4, 11);
            this.lName.Margin = new System.Windows.Forms.Padding(0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(44, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Default:";
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.Transparent;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(67, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(229, 35);
            this.pContent.TabIndex = 1;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Transparent;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt1.FlatAppearance.BorderSize = 0;
            this.bt1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.bt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.ImageList = this.iListBt1;
            this.bt1.Location = new System.Drawing.Point(5, 3);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(41, 29);
            this.bt1.TabIndex = 2;
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // iListBt1
            // 
            this.iListBt1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListBt1.ImageStream")));
            this.iListBt1.TransparentColor = System.Drawing.Color.Transparent;
            this.iListBt1.Images.SetKeyName(0, "copy-icon_24.png");
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Transparent;
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt2.FlatAppearance.BorderSize = 0;
            this.bt2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.bt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.ImageList = this.iListBt2;
            this.bt2.Location = new System.Drawing.Point(58, 3);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(41, 29);
            this.bt2.TabIndex = 3;
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // iListBt2
            // 
            this.iListBt2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListBt2.ImageStream")));
            this.iListBt2.TransparentColor = System.Drawing.Color.Transparent;
            this.iListBt2.Images.SetKeyName(0, "Programming-Open-In-Browser-icon_24.png");
            this.iListBt2.Images.SetKeyName(1, "eye-icon_24.png");
            this.iListBt2.Images.SetKeyName(2, "eye-icon-hide_24.png");
            // 
            // pRight
            // 
            this.pRight.Controls.Add(this.bt1);
            this.pRight.Controls.Add(this.bt2);
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(296, 0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(104, 35);
            this.pRight.TabIndex = 4;
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.lName);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(67, 35);
            this.pLeft.TabIndex = 5;
            // 
            // Content_Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pRight);
            this.Name = "Content_Line";
            this.Size = new System.Drawing.Size(400, 35);
            this.pRight.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.ImageList iListBt1;
        private System.Windows.Forms.ImageList iListBt2;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.Panel pLeft;
    }
}
