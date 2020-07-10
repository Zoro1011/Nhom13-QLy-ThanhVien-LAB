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

namespace Lab_13
{
    public partial class frmTask : Form
    {
        int key;
        public frmTask(int Key)
        {
            InitializeComponent();

            key = Key;
            if(Key == 0)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if ((tbTaskID.Text.Trim() == null)||(!int.TryParse(tbTaskID.Text, out parsedValue)))
            {
                return;
            }
            Models.Task task = new Models.Task();
            task.ID = Int32.Parse(tbTaskID.Text.Trim());
            task.title = tbTaskName.Text.Trim();
            task.description = tbDescription.Text.Trim();
            task.fromDate = dtpFrom.Value;
            task.toDate = dtpTo.Value;
            task.tienDo = "0%";
            //user
            task.listUser = new List<User>();
            string displayuser = "";
            for (int i = 0; i < lstUsers.Items.Count; i++)
            {
                displayuser += this.lstUsers.Items[i] + " ";
                task.listUser.Add(this.lstUsers.Items[i] as User);
            }
            TaskController.AddTask(task);
            GridTask.DataSource = TaskController.GetListTask();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if((tbTaskID == null) || (tbTaskID.Text == ""))
            {
                return;
            }
            int taskId = Int32.Parse(tbTaskID.Text.Trim());
            using (frmPC frmpc = new frmPC(ref taskId, key))
            {
                frmpc.ShowDialog();
            }
            GridTask.DataSource = TaskController.GetListTask();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Models.Task task = new Models.Task();
            task = TaskController.GetTask(Int32.Parse(tbTaskID.Text.Trim()));
            task.ID = Int32.Parse(tbTaskID.Text.Trim());
            task.title = tbTaskName.Text.Trim();
            task.fromDate = dtpFrom.Value;
            task.toDate = dtpTo.Value;
            task.description = tbDescription.Text.Trim();
            task.tienDo = task.tienDo;
            //add user
            //task.listUser = lstUsers.Text;
            if (TaskController.UpdateTask(task) == -1)
            {
                MessageBox.Show("Task khong ton tai");
            }
            GridTask.DataSource = TaskController.GetListTask();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.GridTask.SelectedRows.Count <= 0)
            {
                return;
            }
            Models.Task task = TaskController.GetTask(Int32.Parse(this.GridTask.CurrentRow.Cells[0].Value.ToString()));
            TaskController.DeleteTask(task);



            BindingSource source = new BindingSource();
            source.DataSource = TaskController.GetListTask();
            this.GridTask.DataSource = source;
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            cTaskID.DataPropertyName = nameof(Models.Task.ID);
            cTaskName.DataPropertyName = nameof(Models.Task.title);
            cDescription.DataPropertyName = nameof(Models.Task.description);
            cFrom.DataPropertyName = nameof(Models.Task.fromDate);
            cTo.DataPropertyName = nameof(Models.Task.toDate);
            cTiendo.DataPropertyName = nameof(Models.Task.tienDo);
            GridTask.DataSource = TaskController.GetListTask();
            GridTask.Columns[5].Visible = false;
        }

        private void GridTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            tbTaskID.Text = GridTask.Rows[e.RowIndex].Cells["cTaskID"].Value.ToString();
            if (GridTask.Rows[e.RowIndex].Cells["cTaskName"].Value == null)
            {
                tbTaskName.Text = "";
            }
            else
                tbTaskName.Text = GridTask.Rows[e.RowIndex].Cells["cTaskName"].Value.ToString();
            if (GridTask.Rows[e.RowIndex].Cells["cDescription"].Value == null)
            {
                tbDescription.Text = "";
            }
            else
                tbDescription.Text = GridTask.Rows[e.RowIndex].Cells["cDescription"].Value.ToString();
            if (GridTask.Rows[e.RowIndex].Cells["cFrom"].Value == null)
            {
                dtpFrom.Value = DateTime.Now;
            }
            else
                dtpFrom.Value = Convert.ToDateTime(GridTask.Rows[e.RowIndex].Cells["cFrom"].Value);
            if (GridTask.Rows[e.RowIndex].Cells["cTo"].Value == null)
            {
                dtpTo.Value = DateTime.Now;
            }
            else
                dtpTo.Value = Convert.ToDateTime(GridTask.Rows[e.RowIndex].Cells["cTo"].Value);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if((tbSearch.Text == "")||(tbSearch is null))
            {
                GridTask.DataSource = TaskController.GetListTask();
                return;
            }
            else
                GridTask.DataSource = ListUserController.GetTaskSearch(tbSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser(key);
            user.Show();
        }

        private void frmTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
