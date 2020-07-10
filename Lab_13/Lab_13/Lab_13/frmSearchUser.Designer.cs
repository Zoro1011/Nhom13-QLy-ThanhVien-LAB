namespace Lab_13
{
    partial class frmSearchUser
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Day";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.btSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btSearch.Location = new System.Drawing.Point(83, 155);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(168, 45);
            this.btSearch.TabIndex = 29;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Birthday:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Full name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Username:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(250, 108);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(63, 20);
            this.tbYear.TabIndex = 23;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(181, 108);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(28, 20);
            this.tbMonth.TabIndex = 22;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(96, 108);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(28, 20);
            this.tbDay.TabIndex = 21;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(96, 57);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(217, 20);
            this.tbFullName.TabIndex = 18;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(96, 14);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(217, 20);
            this.tbUserName.TabIndex = 17;
            // 
            // frmSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(329, 214);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbUserName);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchUser";
            this.Text = "TÌM KIẾM NGƯỜI DÙNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbYear;
        public System.Windows.Forms.TextBox tbMonth;
        public System.Windows.Forms.TextBox tbDay;
        public System.Windows.Forms.TextBox tbFullName;
        public System.Windows.Forms.TextBox tbUserName;
    }
}