using Lab_13.Controllers;
using Lab_13.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Drawing.Imaging;
using System.Windows.Threading;

namespace Lab_13
{
    public partial class frmPC : Form
    {
        int taskid, key;
        public int N = 0;
        public frmPC(ref int taskID, int Key)
        {
            InitializeComponent();
            key = Key;
            taskid = taskID;
            lblTaskID.Text += taskid.ToString();
            if(Key == 0)
            {
                btnAddPC.Enabled = false;
                btnTiendo.Enabled = false;
            }


        }
        private void TienDo()
        {
            N = 0;
            foreach (ListViewItem Item in listPC.Items)
            {
                if (Item.SubItems[4].Text.Contains("Xong"))
                {
                    N++;
                }
            }
            var Total = listPC.Items.Count;
            pbTiendo1.Minimum = 0;
            pbTiendo1.Maximum = Total;
            pbTiendo1.Value = N;
            if (N == Total)
            {
                Models.Task task = new Models.Task();
                task = TaskController.GetTask(taskid);
                task.tienDo = "100%";
                TaskController.UpdateTask(task);
                var i = 100;
                pbTiendo1.CreateGraphics().DrawString(i.ToString() + "%", new Font("Arial",(float)10.25, FontStyle.Bold),
                                          Brushes.Red, new PointF(pbTiendo1.Width / 2 - 10, pbTiendo1.Height / 2 - 7));
            }
            else
            {
                Models.Task task = new Models.Task();
                task = TaskController.GetTask(taskid);
                var x = (double)N/Total*100;
                var i = (Math.Round(x));
                task.tienDo = i.ToString() + "%";
                TaskController.UpdateTask(task);
                pbTiendo1.CreateGraphics().DrawString(i.ToString() + "%", new Font("Arial", (float)10.25, FontStyle.Bold),
                                          Brushes.Red, new PointF(pbTiendo1.Width / 2 - 10, pbTiendo1.Height / 2 - 7));
            }
            pbTiendo1.BeginInvoke(new Action(delegate () { pbTiendo1.Value = N; }));
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listSearch_DoubleClick(object sender, EventArgs e)
        {
            if (this.listUser.Items.Count >= 1)
            {
                return;
            }
            if (listUser.Items.Contains(this.listSearch.SelectedItem))
            {
                MessageBox.Show("Username trùng!");
                return;
            }
            else if (this.listSearch.SelectedIndex >= 0)
            {
                this.listUser.Items.Add(this.listSearch.SelectedItem);
            }
        }

        private void listUser_DoubleClick(object sender, EventArgs e)
        {
            if (this.listUser.SelectedIndex >= 0)
            {

                this.listUser.Items.RemoveAt(this.listUser.SelectedIndex);
            }
        }
        private void DisplayTask()
        {
            foreach (ListViewItem Item in listPC.Items) 
                listPC.Items.Remove(Item);
            List<TaskInfo> lsttaskinfo = PcController.getAllInfo();
            foreach (TaskInfo taskinfo in lsttaskinfo)
            {
                if(taskid == taskinfo.ID)
                {
                    ListViewItem eVent = new ListViewItem(taskinfo.ID.ToString());
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, taskinfo.Viec));
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, taskinfo.Info));
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, taskinfo.User));
                    eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, taskinfo.TienDo));
                    this.listPC.Items.Add(eVent);
                }
                
            }
        }


        private void listPC_Click(object sender, EventArgs e)
        {
            this.tbName.Text = this.listPC.SelectedItems[0].SubItems[1].Text.Trim();
            this.rtbInfo.Text = this.listPC.SelectedItems[0].SubItems[2].Text.Trim();
            string user = this.listPC.SelectedItems[0].SubItems[3].Text.Trim();
            if (listUser.Items.Count >= 1)
            {
                listUser.Items.Clear();
            }
            if(!listUser.Items.Contains(user)) listUser.Items.Add(user);
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            this.listSearch.Items.Clear();
            //tim username
            List<User> searchUsers = UserController.getListUser(this.tbSearch.Text.Trim());

            if (searchUsers.Count > 0)
            {
                this.listSearch.Visible = true;
            }
            else
            {
                this.listSearch.Visible = false;
            }
            for (int i = 0; i < searchUsers.Count; i++)
            {
                this.listSearch.Items.Add(searchUsers[i]);
            }
        }

        private void btnAddPC_Click_2(object sender, EventArgs e)
        {
            TaskInfo TaskPC = new TaskInfo();
            TaskPC.ID = taskid;
            //if (listUser.Items.Count == 0)
            //{
            //    return;
            //}
            try
            {
                TaskPC.User = listUser.Items[0].ToString();
                TaskPC.Viec = tbName.Text.Trim();
                TaskPC.Info = rtbInfo.Text.Trim();
            }
            catch { return; }
            TaskPC.TienDo = "";
            PcController.AddPc(TaskPC);
            listUser.Items.Clear();
            listSearch.Items.Clear();
            tbSearch.Clear();
            tbName.Clear();
            rtbInfo.Clear();
            
            DisplayTask();
            TienDo();
            //using (frmTask task = new frmTask())
            //{
            //    for (int i = 0; i < listPC.Items.Count; i++)
            //    {
            //        //if (!(task.lstUsers.Items.Contains(listPC.Items[i].SubItems[2].Text.Trim())))
            //        //{

            //            task.lstUsers.Items[i] = listPC.Items[i].SubItems[2].Text.Trim();
            //        //}
            //    }
            //}
        }

        private void btnTiendo_Click(object sender, EventArgs e)
        {
            var name = tbName.Text.Trim();
            TaskInfo task = PcController.GetTaskInfo(taskid, name);
            task.TienDo = "Xong";
            listPC.SelectedItems[0].SubItems[4].Text = "Xong";
            PcController.UpdateInfo(task);
            TienDo();
        }

        private void frmPC_Load(object sender, EventArgs e)
        { 
            DisplayTask();

            TienDo();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (pbTiendo1.Value < N) pbTiendo1.Value = pbTiendo1.Value + 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void frmPC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void listPC_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //foreach (ListViewItem Item in listPC.Items)
            //{
            //    if (Item != null)
            //    {
            //        if (Item.Checked == true)
            //        {
            //            N++;
            //            var name = this.listPC.CheckedItems[0].SubItems[1].ToString();
            //            TaskInfo task = PcController.GetTaskInfo(taskid, name);
            //            task.TienDo = 1;
            //            PcController.UpdateInfo(task);
            //        }
            //    }
            //}

            //pbTiendo.Value = N;
        }
    }
}
