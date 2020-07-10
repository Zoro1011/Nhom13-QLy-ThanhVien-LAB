namespace Lab_13
{
    partial class frmPC
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTiendo = new Guna.UI2.WinForms.Guna2Button();
            this.pbTiendo1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.rtbInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddPC = new Guna.UI2.WinForms.Guna2Button();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listUser = new System.Windows.Forms.ListBox();
            this.listSearch = new System.Windows.Forms.ListBox();
            this.listPC = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTiendo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btnTiendo);
            this.splitContainer1.Panel1.Controls.Add(this.pbTiendo1);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.rtbInfo);
            this.splitContainer1.Panel1.Controls.Add(this.tbName);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddPC);
            this.splitContainer1.Panel1.Controls.Add(this.lblTaskID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listUser);
            this.splitContainer1.Panel1.Controls.Add(this.listSearch);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listPC);
            this.splitContainer1.Size = new System.Drawing.Size(783, 406);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Lab_13.Properties.Resources.power_off_button;
            this.pictureBox2.Location = new System.Drawing.Point(736, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnTiendo
            // 
            this.btnTiendo.AutoRoundedCorners = true;
            this.btnTiendo.BorderRadius = 13;
            this.btnTiendo.BorderThickness = 1;
            this.btnTiendo.CheckedState.Parent = this.btnTiendo;
            this.btnTiendo.CustomImages.Parent = this.btnTiendo;
            this.btnTiendo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendo.ForeColor = System.Drawing.Color.White;
            this.btnTiendo.HoverState.Parent = this.btnTiendo;
            this.btnTiendo.Location = new System.Drawing.Point(385, 115);
            this.btnTiendo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTiendo.Name = "btnTiendo";
            this.btnTiendo.ShadowDecoration.Parent = this.btnTiendo;
            this.btnTiendo.Size = new System.Drawing.Size(67, 28);
            this.btnTiendo.TabIndex = 16;
            this.btnTiendo.Text = "Xong";
            this.btnTiendo.Click += new System.EventHandler(this.btnTiendo_Click);
            // 
            // pbTiendo1
            // 
            this.pbTiendo1.BackColor = System.Drawing.Color.Transparent;
            this.pbTiendo1.BorderRadius = 1;
            this.pbTiendo1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbTiendo1.Location = new System.Drawing.Point(457, 115);
            this.pbTiendo1.Name = "pbTiendo1";
            this.pbTiendo1.ShadowDecoration.Parent = this.pbTiendo1;
            this.pbTiendo1.Size = new System.Drawing.Size(318, 28);
            this.pbTiendo1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTiendo1.TabIndex = 15;
            this.pbTiendo1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // tbSearch
            // 
            this.tbSearch.Animated = true;
            this.tbSearch.AutoRoundedCorners = true;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.Location = new System.Drawing.Point(583, 45);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(192, 23);
            this.tbSearch.TabIndex = 14;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Animated = true;
            this.rtbInfo.AutoRoundedCorners = true;
            this.rtbInfo.BorderRadius = 10;
            this.rtbInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbInfo.DefaultText = "";
            this.rtbInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rtbInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rtbInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtbInfo.DisabledState.Parent = this.rtbInfo;
            this.rtbInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rtbInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbInfo.FocusedState.Parent = this.rtbInfo;
            this.rtbInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbInfo.HoverState.Parent = this.rtbInfo;
            this.rtbInfo.Location = new System.Drawing.Point(110, 68);
            this.rtbInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.PasswordChar = '\0';
            this.rtbInfo.PlaceholderText = "";
            this.rtbInfo.SelectedText = "";
            this.rtbInfo.ShadowDecoration.Parent = this.rtbInfo;
            this.rtbInfo.Size = new System.Drawing.Size(237, 23);
            this.rtbInfo.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.AutoRoundedCorners = true;
            this.tbName.BorderRadius = 10;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(148, 45);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(199, 23);
            this.tbName.TabIndex = 12;
            // 
            // btnAddPC
            // 
            this.btnAddPC.AutoRoundedCorners = true;
            this.btnAddPC.BorderRadius = 24;
            this.btnAddPC.BorderThickness = 1;
            this.btnAddPC.CheckedState.Parent = this.btnAddPC;
            this.btnAddPC.CustomImages.Parent = this.btnAddPC;
            this.btnAddPC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPC.ForeColor = System.Drawing.Color.White;
            this.btnAddPC.HoverState.Parent = this.btnAddPC;
            this.btnAddPC.Location = new System.Drawing.Point(155, 93);
            this.btnAddPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPC.Name = "btnAddPC";
            this.btnAddPC.ShadowDecoration.Parent = this.btnAddPC;
            this.btnAddPC.Size = new System.Drawing.Size(192, 51);
            this.btnAddPC.TabIndex = 11;
            this.btnAddPC.Text = "Phân công";
            this.btnAddPC.Click += new System.EventHandler(this.btnAddPC_Click_2);
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTaskID.Location = new System.Drawing.Point(303, 8);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(94, 31);
            this.lblTaskID.TabIndex = 9;
            this.lblTaskID.Text = "DỰ ÁN ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên phần việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Người thực hiện";
            // 
            // listUser
            // 
            this.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUser.FormattingEnabled = true;
            this.listUser.Location = new System.Drawing.Point(385, 71);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(192, 39);
            this.listUser.TabIndex = 2;
            this.listUser.DoubleClick += new System.EventHandler(this.listUser_DoubleClick);
            // 
            // listSearch
            // 
            this.listSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSearch.FormattingEnabled = true;
            this.listSearch.Location = new System.Drawing.Point(583, 71);
            this.listSearch.Name = "listSearch";
            this.listSearch.Size = new System.Drawing.Size(192, 39);
            this.listSearch.TabIndex = 1;
            this.listSearch.DoubleClick += new System.EventHandler(this.listSearch_DoubleClick);
            // 
            // listPC
            // 
            this.listPC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cName,
            this.cInfo,
            this.cUser,
            this.cTiendo});
            this.listPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPC.GridLines = true;
            this.listPC.HideSelection = false;
            this.listPC.Location = new System.Drawing.Point(0, 0);
            this.listPC.Name = "listPC";
            this.listPC.Size = new System.Drawing.Size(783, 255);
            this.listPC.TabIndex = 0;
            this.listPC.UseCompatibleStateImageBehavior = false;
            this.listPC.View = System.Windows.Forms.View.Details;
            this.listPC.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listPC_ItemChecked);
            this.listPC.Click += new System.EventHandler(this.listPC_Click);
            // 
            // cID
            // 
            this.cID.Text = "Dự án";
            // 
            // cName
            // 
            this.cName.Text = "Tên phần việc";
            this.cName.Width = 111;
            // 
            // cInfo
            // 
            this.cInfo.Text = "Nội dung";
            this.cInfo.Width = 249;
            // 
            // cUser
            // 
            this.cUser.Text = "Người thực hiện";
            this.cUser.Width = 184;
            // 
            // cTiendo
            // 
            this.cTiendo.Text = "Tiến độ";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // frmPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 406);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPC";
            this.Text = "PHÂN CÔNG DỰ ÁN";
            this.Load += new System.EventHandler(this.frmPC_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPC_MouseDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.ListBox listSearch;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cInfo;
        private System.Windows.Forms.ColumnHeader cUser;
        public System.Windows.Forms.ListView listPC;
        private System.Windows.Forms.ColumnHeader cTiendo;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2TextBox rtbInfo;
        private Guna.UI2.WinForms.Guna2ProgressBar pbTiendo1;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2Button btnAddPC;
        public Guna.UI2.WinForms.Guna2Button btnTiendo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}