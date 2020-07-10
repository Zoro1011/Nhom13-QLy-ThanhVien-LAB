using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_13
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if((!rbNV.Checked)&&(!rbQL.Checked))
            {
                return;
            }
            if((tbusername is null)||(tbpass is null))
            {
                return;
            }
            if ((tbusername.Text == "admin") && (tbpass.Text == "admin"))
            {
                int key = 0;
                if (rbQL.Checked)
                    key = 1;
                this.Hide();
                using (formMain Form = new formMain(key))
                {
                    Form.ShowDialog();
                }
                //this.Show();
                
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.tbpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)Keys.Enter)
            {
                if ((!rbNV.Checked) && (!rbQL.Checked))
                {
                    return;
                }
                if ((tbusername is null) || (tbpass is null))
                {
                    return;
                }
                if ((tbusername.Text == "admin") && (tbpass.Text == "admin"))
                {
                    int key = 0;
                    if (rbQL.Checked)
                        key = 1;
                    this.Hide();
                    using (formMain Form = new formMain(key))
                    {
                        Form.ShowDialog();
                    }
                    //this.Show();

                }
            }
        }

        private void tbusername_Enter(object sender, EventArgs e)
        {
            if (tbusername.Text == "Username") tbusername.Text = "";
            tbusername.ForeColor = Color.Silver;
        }

        private void tbusername_Leave(object sender, EventArgs e)
        {
            if (tbusername.Text == "") tbusername.Text = "Username";
            tbusername.ForeColor = Color.Silver;
        }

        private void tbpass_Enter(object sender, EventArgs e)
        {
            if (tbpass.Text == "Password")
            {
                tbpass.PasswordChar = '*';
                tbpass.Text = "";
            }
            tbpass.ForeColor = Color.Silver;


        }

        private void tbpass_Leave(object sender, EventArgs e)
        {
            if (tbpass.Text == "")
            {
                tbpass.PasswordChar = '\0';
                tbpass.Text = "Password";
            }
            tbpass.ForeColor = Color.Silver;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
