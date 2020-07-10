namespace Lab_13
{
    partial class frmRecent
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
            this.GridRecent = new System.Windows.Forms.DataGridView();
            this.cTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTiendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // GridRecent
            // 
            this.GridRecent.AllowUserToAddRows = false;
            this.GridRecent.AllowUserToDeleteRows = false;
            this.GridRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTaskID,
            this.cTaskName,
            this.cDescription,
            this.cFrom,
            this.cTo,
            this.cTiendo});
            this.GridRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRecent.Location = new System.Drawing.Point(0, 0);
            this.GridRecent.Name = "GridRecent";
            this.GridRecent.Size = new System.Drawing.Size(800, 450);
            this.GridRecent.TabIndex = 0;
            // 
            // cTaskID
            // 
            this.cTaskID.HeaderText = "Mã dự án";
            this.cTaskID.Name = "cTaskID";
            // 
            // cTaskName
            // 
            this.cTaskName.HeaderText = "Tên dự án";
            this.cTaskName.Name = "cTaskName";
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Mô tả";
            this.cDescription.Name = "cDescription";
            // 
            // cFrom
            // 
            this.cFrom.HeaderText = "Bắt đầu";
            this.cFrom.Name = "cFrom";
            // 
            // cTo
            // 
            this.cTo.HeaderText = "Kết thúc";
            this.cTo.Name = "cTo";
            // 
            // cTiendo
            // 
            this.cTiendo.HeaderText = "Trạng thái";
            this.cTiendo.Name = "cTiendo";
            // 
            // frmRecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridRecent);
            this.Name = "frmRecent";
            this.Text = "frmRecent";
            ((System.ComponentModel.ISupportInitialize)(this.GridRecent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GridRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTiendo;
    }
}