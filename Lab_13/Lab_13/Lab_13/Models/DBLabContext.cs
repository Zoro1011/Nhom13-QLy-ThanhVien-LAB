using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Models
{
    public class DBLabContext: DbContext
    {
        public DBLabContext(): base("name = LabContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskInfo> TasksInfo { get; set; }
    }
}
