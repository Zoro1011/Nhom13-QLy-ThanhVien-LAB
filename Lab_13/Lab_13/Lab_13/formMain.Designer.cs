namespace Lab_13
{
    partial class formMain
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
            this.gpnMAIN = new System.Windows.Forms.Panel();
            this.tt_cv_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_TTNV = new System.Windows.Forms.Button();
            this.bt_ttduan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gpnMAIN
            // 
            this.gpnMAIN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpnMAIN.Location = new System.Drawing.Point(14, 128);
            this.gpnMAIN.Margin = new System.Windows.Forms.Padding(2);
            this.gpnMAIN.Name = "gpnMAIN";
            this.gpnMAIN.Size = new System.Drawing.Size(944, 475);
            this.gpnMAIN.TabIndex = 10;
            // 
            // tt_cv_btn
            // 
            this.tt_cv_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tt_cv_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tt_cv_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tt_cv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_cv_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tt_cv_btn.Location = new System.Drawing.Point(484, 0);
            this.tt_cv_btn.Margin = new System.Windows.Forms.Padding(0);
            this.tt_cv_btn.Name = "tt_cv_btn";
            this.tt_cv_btn.Size = new System.Drawing.Size(223, 78);
            this.tt_cv_btn.TabIndex = 10;
            this.tt_cv_btn.Text = "     DỰ ÁN      HIỆN TẠI";
            this.tt_cv_btn.UseVisualStyleBackColor = false;
            this.tt_cv_btn.Click += new System.EventHandler(this.tt_cv_btn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(707, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 78);
            this.button1.TabIndex = 9;
            this.button1.Text = "THÔNG TIN PHẦN MỀM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TB_TTNV);
            this.panel1.Controls.Add(this.tt_cv_btn);
            this.panel1.Controls.Add(this.bt_ttduan);
            this.panel1.Location = new System.Drawing.Point(11, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 78);
            this.panel1.TabIndex = 6;
            // 
            // TB_TTNV
            // 
            this.TB_TTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_TTNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TB_TTNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TB_TTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TTNV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TB_TTNV.Image = global::Lab_13.Properties.Resources.icons8_user_48;
            this.TB_TTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_TTNV.Location = new System.Drawing.Point(0, 0);
            this.TB_TTNV.Margin = new System.Windows.Forms.Padding(0);
            this.TB_TTNV.Name = "TB_TTNV";
            this.TB_TTNV.Size = new System.Drawing.Size(236, 78);
            this.TB_TTNV.TabIndex = 1;
            this.TB_TTNV.Text = "THÔNG TIN NHÂN VIÊN";
            this.TB_TTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TB_TTNV.UseVisualStyleBackColor = false;
            this.TB_TTNV.Click += new System.EventHandler(this.TB_TTNV_Click);
            // 
            // bt_ttduan
            // 
            this.bt_ttduan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ttduan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bt_ttduan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_ttduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ttduan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_ttduan.Image = global::Lab_13.Properties.Resources.id__1_;
            this.bt_ttduan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_ttduan.Location = new System.Drawing.Point(236, 0);
            this.bt_ttduan.Margin = new System.Windows.Forms.Padding(0);
            this.bt_ttduan.Name = "bt_ttduan";
            this.bt_ttduan.Size = new System.Drawing.Size(248, 78);
            this.bt_ttduan.TabIndex = 6;
            this.bt_ttduan.Text = "   THÔNG TIN DỰ ÁN";
            this.bt_ttduan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ttduan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ttduan.UseVisualStyleBackColor = false;
            this.bt_ttduan.Click += new System.EventHandler(this.bt_ttduan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ DỰ ÁN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Lab_13.Properties.Resources.power_off_button;
            this.pictureBox2.Location = new System.Drawing.Point(907, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(969, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gpnMAIN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "formMain";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel gpnMAIN;
        private System.Windows.Forms.Button tt_cv_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_ttduan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TB_TTNV;
        private System.Windows.Forms.Label label1;
    }
}