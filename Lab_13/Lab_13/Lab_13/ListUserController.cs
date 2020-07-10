using Lab_13.Models;
using Lab_13.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class ListUserController
    {
        public static List<User> GetListSearch(string username, string fullname, string day, string month, string year)
        {
            List<User> listuser = UserController.GetListUser();
            if (username != "")
            {
                listuser = listuser.Where(u => u.username.Contains(username)).ToList();
            }
            if (fullname != "")
            {
                listuser = listuser.Where(u => u.fullname.Contains(fullname)).ToList();
            }
            if (day != "")
            {
                //int daay = Int32.Parse(day);
                listuser = listuser.Where(u => u.bday.Value.Day.ToString() == day).ToList();

            }
            return listuser;

        }
        public static List<Models.Task> GetTaskSearch(string search)
        {
            List<Models.Task> listtask = TaskController.GetListTask();
            if(search != null)
            {
                int parsedValue;
                if (!int.TryParse(search, out parsedValue))
                {
                    listtask = listtask.Where(t => t.title.Contains(search)).ToList();
                }
                else
                {
                    List<Models.Task> listtask2 = TaskController.GetListTask(); 
                    listtask2 = listtask2.Where(t => t.title.Contains(search)).ToList();
                    
                    int id = int.Parse(search);
                    List<Models.Task> listtask1 = TaskController.GetListTask();
                    listtask1 = listtask1.Where(t => t.ID == id).ToList();

                    listtask2.AddRange(listtask1);
                    listtask = listtask2.Distinct().ToList();
                }
            }
            
            return listtask;

        }
        public static List<Models.Task> GetTaskSearchRecent(DateTime day)
        {
            List<Models.Task> listtask = TaskController.GetListTask();
            if (day != null)
            {
                listtask = listtask.Where(t => ((t.fromDate <= day)&&(t.toDate >= day)&&(t.tienDo.Trim() != "100%"))|| (t.fromDate >= day)).ToList();
            }
            return listtask;
        }
    }
}
