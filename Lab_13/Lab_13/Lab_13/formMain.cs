using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_13.Controllers;
using Lab_13.Models;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;

namespace Lab_13
{
    public partial class formMain : Form
    {
        int key;
        public formMain(int Key)
        {
            InitializeComponent();
            key = Key;
        }
        private Form activeForm = null;
        public void openchildform(Form childform)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            gpnMAIN.Controls.Add(childform);
            gpnMAIN.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void TB_TTNV_Click(object sender, EventArgs e)
        {
            openchildform(new frmUser(key));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void formMain_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }

        private void bt_ttduan_Click(object sender, EventArgs e)
        {
            openchildform(new frmTask(key));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new frmAppInfo());
        }

        private void tt_cv_btn_Click(object sender, EventArgs e)
        {
            openchildform(new frmRecent());
        }
    }
}
