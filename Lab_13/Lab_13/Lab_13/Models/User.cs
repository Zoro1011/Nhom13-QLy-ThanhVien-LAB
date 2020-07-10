using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace Lab_13.Models
{
    [Table("User")]
    public class User
    {
            [Key]
            public string username { set; get; }
            public string fullname { set; get; }
            public string level { set; get; }
            public DateTime? bday { set; get; }
            public string phone { set; get; }
            public string email { set; get; }
            public byte[] photo_aray { set; get; }
            public Int64 salary { set; get; }
            public ICollection<Task> listTask { set; get; }
            public override string ToString()
            {
                return this.username;
            }
    }
}
