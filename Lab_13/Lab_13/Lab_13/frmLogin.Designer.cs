namespace Lab_13
{
    partial class frmLogin
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
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.rbQL = new System.Windows.Forms.RadioButton();
            this.rbNV = new System.Windows.Forms.RadioButton();
            this.tbusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLOGIN.Location = new System.Drawing.Point(39, 200);
            this.btnLOGIN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(199, 39);
            this.btnLOGIN.TabIndex = 25;
            this.btnLOGIN.Text = "Đăng nhập";
            this.btnLOGIN.UseVisualStyleBackColor = false;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // rbQL
            // 
            this.rbQL.AutoSize = true;
            this.rbQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rbQL.Location = new System.Drawing.Point(83, 177);
            this.rbQL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbQL.Name = "rbQL";
            this.rbQL.Size = new System.Drawing.Size(61, 17);
            this.rbQL.TabIndex = 22;
            this.rbQL.TabStop = true;
            this.rbQL.Text = "Quản lý";
            this.rbQL.UseVisualStyleBackColor = true;
            // 
            // rbNV
            // 
            this.rbNV.AutoSize = true;
            this.rbNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.rbNV.Location = new System.Drawing.Point(169, 177);
            this.rbNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbNV.Name = "rbNV";
            this.rbNV.Size = new System.Drawing.Size(74, 17);
            this.rbNV.TabIndex = 21;
            this.rbNV.TabStop = true;
            this.rbNV.Text = "Nhân viên";
            this.rbNV.UseVisualStyleBackColor = true;
            // 
            // tbusername
            // 
            this.tbusername.AutoRoundedCorners = true;
            this.tbusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbusername.BorderRadius = 9;
            this.tbusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbusername.DefaultText = "Username";
            this.tbusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.DisabledState.Parent = this.tbusername;
            this.tbusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.FocusedState.Parent = this.tbusername;
            this.tbusername.ForeColor = System.Drawing.Color.White;
            this.tbusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.HoverState.Parent = this.tbusername;
            this.tbusername.Location = new System.Drawing.Point(105, 103);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbusername.Name = "tbusername";
            this.tbusername.PasswordChar = '\0';
            this.tbusername.PlaceholderForeColor = System.Drawing.Color.White;
            this.tbusername.PlaceholderText = "";
            this.tbusername.SelectedText = "";
            this.tbusername.SelectionStart = 8;
            this.tbusername.ShadowDecoration.Parent = this.tbusername;
            this.tbusername.Size = new System.Drawing.Size(141, 21);
            this.tbusername.TabIndex = 27;
            this.tbusername.Enter += new System.EventHandler(this.tbusername_Enter);
            this.tbusername.Leave += new System.EventHandler(this.tbusername_Leave);
            // 
            // tbpass
            // 
            this.tbpass.Animated = true;
            this.tbpass.AutoRoundedCorners = true;
            this.tbpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbpass.BorderRadius = 9;
            this.tbpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpass.DefaultText = "Password";
            this.tbpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpass.DisabledState.Parent = this.tbpass;
            this.tbpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpass.FocusedState.Parent = this.tbpass;
            this.tbpass.ForeColor = System.Drawing.Color.White;
            this.tbpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpass.HoverState.Parent = this.tbpass;
            this.tbpass.Location = new System.Drawing.Point(105, 135);
            this.tbpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '\0';
            this.tbpass.PlaceholderForeColor = System.Drawing.Color.White;
            this.tbpass.PlaceholderText = "";
            this.tbpass.SelectedText = "";
            this.tbpass.SelectionStart = 8;
            this.tbpass.ShadowDecoration.Parent = this.tbpass;
            this.tbpass.Size = new System.Drawing.Size(141, 21);
            this.tbpass.TabIndex = 28;
            this.tbpass.Enter += new System.EventHandler(this.tbpass_Enter);
            this.tbpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpass_KeyPress);
            this.tbpass.Leave += new System.EventHandler(this.tbpass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(105, 156);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 1);
            this.panel3.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(105, 127);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 1);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_13.Properties.Resources.icons8_password_48;
            this.pictureBox1.Location = new System.Drawing.Point(31, 130);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_13.Properties.Resources.icons8_user_481;
            this.pictureBox2.Location = new System.Drawing.Point(31, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Lab_13.Properties.Resources.free_user_login_icon_305_thumb;
            this.guna2PictureBox1.Location = new System.Drawing.Point(95, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(84, 75);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 29;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::Lab_13.Properties.Resources.power_off_button;
            this.pictureBox3.Location = new System.Drawing.Point(217, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(256, 251);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.rbQL);
            this.Controls.Add(this.rbNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "ĐĂNG NHẬP";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.RadioButton rbQL;
        private System.Windows.Forms.RadioButton rbNV;
        private Guna.UI2.WinForms.Guna2TextBox tbusername;
        private Guna.UI2.WinForms.Guna2TextBox tbpass;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}