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
    public partial class frmUser : Form
    {
        public frmUser(int Key)
        {
            InitializeComponent();
            if(Key == 0)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Trim()==null||tbUser.Text.Length<=0)
            {
                return;
            }

            User user = new User();

            user.username = tbUser.Text.Trim();
            if (tbName.Text == null) user.fullname = "";
                else user.fullname = tbName.Text.Trim();
            if (dtpBirthday.Value == null) user.bday = DateTime.Now;
                else user.bday = DateTime.Parse(dtpBirthday.Value.ToString());
            if (tbLevel.Text == null) user.level = "";
                else user.level = tbLevel.Text.Trim();
            if (tbEmail.Text == null) user.email = "";
                else user.email = tbEmail.Text.Trim();
            if (tbPhone.Text == null) user.phone = "";
                else user.phone = tbPhone.Text.Trim();
            if (tbSalary.Text == null || tbSalary.Text == "") tbSalary.Text = "0";
                else user.salary = Int64.Parse(tbSalary.Text.Trim());

            //converting photo to binary data
            if(pictureBox1.Image==null || pictureBox1.Image == Lab_13.Properties.Resources.default_avatar)
            {
                pictureBox1.Image = Lab_13.Properties.Resources.default_avatar;
                return;
            }
                
            if (pictureBox1.Image != null && pictureBox1.Image != Lab_13.Properties.Resources.default_avatar)
            {
                MemoryStream ms = new MemoryStream();

                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@cPhoto", photo_aray);

                user.photo_aray = photo_aray;
            }

            UserController.AddUser(user);
            GridUser.DataSource = UserController.GetListUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (tbUser.Text == null || tbUser.Text.Length <= 0) 
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Lỗi");
                return;
            }
            user.username = tbUser.Text.Trim();
            if (tbName.Text == null) user.fullname = "";
            else user.fullname = tbName.Text.Trim();
            if (dtpBirthday.Value == null) user.bday = DateTime.Now;
            else user.bday = DateTime.Parse(dtpBirthday.Value.ToString());
            if (tbLevel.Text == null) user.level = "";
            else user.level = tbLevel.Text.Trim();
            if (tbEmail.Text == null) user.email = "";
            else user.email = tbEmail.Text.Trim();
            if (tbPhone.Text == null) user.phone = "";
            else user.phone = tbPhone.Text.Trim();
            if (tbSalary.Text == null) user.salary = 0;
            else user.salary = Int64.Parse(tbSalary.Text.Trim());

            //convert photo to binary data
            if (pictureBox1.Image == null || pictureBox1.Image == Lab_13.Properties.Resources.default_avatar)
            {
                pictureBox1.Image = Lab_13.Properties.Resources.default_avatar;
            }
            if (pictureBox1.Image != Lab_13.Properties.Resources.default_avatar)
                {
                    MemoryStream ms = new MemoryStream();
                    using (Bitmap tempImage = new Bitmap(pictureBox1.Image))
                {
                    tempImage.Save(ms, ImageFormat.Jpeg); 
                }
                        



                    byte[] photo_aray = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_aray, 0, photo_aray.Length);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cPhoto", photo_aray);

                    user.photo_aray = photo_aray;
                }

            if (UserController.UpdateUser(user) == -1)
            {
                MessageBox.Show("Username không tồn tại!");
            }
            GridUser.DataSource = UserController.GetListUser();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if (GridUser.SelectedRows.Count == 0)
            //{
            //    return;
            //}
            //using (var _context = new DBLabContext())
            //{
            //    for (int i = 0; i < GridUser.SelectedRows.Count; i++)
            //    {
            //        string str = GridUser.SelectedRows[i].Cells["cName"].Value.ToString();
            //        User user = _context.Users.Find(str);
            //        UserController.DeleteUser(user);
            //    }
            //}
            //GridUser.DataSource = UserController.GetListUser();
            if (this.GridUser.SelectedRows.Count <= 0)
            {
                return;
            }
            try
            {
                User user = UserController.GetUser(this.GridUser.CurrentRow.Cells[1].Value.ToString());
                UserController.DeleteUser(user);
            }
            catch { return;
            }
            BindingSource source = new BindingSource();
            source.DataSource = UserController.GetListUser();
            this.GridUser.DataSource = source;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (frmSearchUser frmSearch = new frmSearchUser())
            {
                if (frmSearch.ShowDialog() == DialogResult.OK)
                {
                    GridUser.DataSource = ListUserController.GetListSearch(frmSearch.tbUserName.Text,
                        frmSearch.tbFullName.Text, frmSearch.tbDay.Text,
                        frmSearch.tbMonth.Text, frmSearch.tbYear.Text);
                }
            }
        }

        Image ConvertBinToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {

                    return Image.FromStream(ms);

            }
        }
        private void GridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //GridUser.AllowUserToAddRows = false;
            btnAdd.Enabled = false;
            if (e.RowIndex < 0)
            {
                return;
            }
            if (GridUser.Rows[e.RowIndex].Cells["cUser"].Value == null) tbUser.Text = "";
            else tbUser.Text = GridUser.Rows[e.RowIndex].Cells["cUser"].Value.ToString();
            if (GridUser.Rows[e.RowIndex].Cells["cPhone"].Value == null) tbPhone.Text = "";
            else tbPhone.Text = GridUser.Rows[e.RowIndex].Cells["cPhone"].Value.ToString();
            if (GridUser.Rows[e.RowIndex].Cells["cName"].Value == null) tbName.Text = "";
            else tbName.Text = GridUser.Rows[e.RowIndex].Cells["cName"].Value.ToString();
            if (GridUser.Rows[e.RowIndex].Cells["cEmail"].Value == null) tbEmail.Text = "";
            else tbEmail.Text = GridUser.Rows[e.RowIndex].Cells["cEmail"].Value.ToString();
            if (GridUser.Rows[e.RowIndex].Cells["cLevel"].Value == null) tbLevel.Text = "";
            else tbLevel.Text = GridUser.Rows[e.RowIndex].Cells["cLevel"].Value.ToString();
            if (GridUser.Rows[e.RowIndex].Cells["cSalary"].Value == null) tbSalary.Text = "";
            else tbSalary.Text = GridUser.Rows[e.RowIndex].Cells["cSalary"].Value.ToString();
            if (GridUser.Rows[e.RowIndex].Cells["CBirthday"].Value == null) dtpBirthday.Value = DateTime.Now;
            else dtpBirthday.Value = Convert.ToDateTime(GridUser.Rows[e.RowIndex].Cells["cBirthday"].Value);


            //LOAD HINH ANH
            string usernametemp = tbUser.Text.Trim();
            using (DBLabContext db = new DBLabContext())
            {
                User user = db.Users.Where(u => u.username == usernametemp).SingleOrDefault();
                pictureBox1.Image = ConvertBinToImage(user.photo_aray);
            }
           
            
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            cUser.DataPropertyName = nameof(User.username);
            cName.DataPropertyName = nameof(User.fullname);
            cLevel.DataPropertyName = nameof(User.level);
            cBirthday.DataPropertyName = nameof(User.bday);
            cPhone.DataPropertyName = nameof(User.phone);
            cEmail.DataPropertyName = nameof(User.email);
            cSalary.DataPropertyName = nameof(User.salary);
            GridUser.DataSource = UserController.GetListUser();
            GridUser.Columns[7].Visible = false;
            GridUser.Columns[9].Visible = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            tbEmail.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbUser.Text = "";
            tbSalary.Text = "";
            tbLevel.Text = "";
            dtpBirthday.Value = DateTime.Now;
            pictureBox1.Image = Lab_13.Properties.Resources.default_avatar;
            GridUser.DataSource = UserController.GetListUser();
        }
    }
}
