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
    public partial class frmRecent : Form
    {
        public frmRecent()
        {
            InitializeComponent();
            cTaskID.DataPropertyName = nameof(Models.Task.ID);
            cTaskName.DataPropertyName = nameof(Models.Task.title);
            cDescription.DataPropertyName = nameof(Models.Task.description);
            cFrom.DataPropertyName = nameof(Models.Task.fromDate);
            cTo.DataPropertyName = nameof(Models.Task.toDate);
            cTiendo.DataPropertyName = nameof(Models.Task.tienDo);
            var day = DateTime.Now;
            GridRecent.DataSource = ListUserController.GetTaskSearchRecent(day);
            GridRecent.Columns[5].Visible = false;
        }
    }
}
