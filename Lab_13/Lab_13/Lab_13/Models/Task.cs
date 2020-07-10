using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_13.Models
{
    [Table("Task")]
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { set; get; }
        public string title { set; get; }
        public string description { set; get; }
        public DateTime? fromDate { set; get; }
        public DateTime? toDate { set; get; }
        public ICollection<User> listUser { set; get; }
        public string tienDo { set; get; }
    }
}
