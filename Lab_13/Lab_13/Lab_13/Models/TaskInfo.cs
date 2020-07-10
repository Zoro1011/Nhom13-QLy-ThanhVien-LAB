using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_13.Models
{
    public class TaskInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key, Column(Order = 0)]
        public int ID { set; get; }
        [Key, Column(Order = 1)]
        public string Viec { set; get; }
        public string Info { set; get; }
        public string User { set; get; }
        public string TienDo { set; get; }
    }
}
