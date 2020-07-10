using Lab_13.Models;
using Lab_13.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13.Controllers
{
    public class PcController
    {
        public static void AddPc(TaskInfo taskinfo)
        {
            using (var _context = new DBLabContext())
            {
                _context.TasksInfo.Add(taskinfo);
                _context.SaveChanges();
            }
        }
        public static List<TaskInfo> getAllInfo()
        {
            using (var _context = new DBLabContext())
            {
                var info = (from i in _context.TasksInfo.AsEnumerable()
                            select new
                            {
                                Id = i.ID,
                                VIEC = i.Viec,
                                info = i.Info,
                                user = i.User,
                                tiendo = i.TienDo
                            }).Select(x => new TaskInfo
                            {
                                ID = x.Id,
                                Viec = x.VIEC,
                                Info = x.info,
                                User = x.user,
                                TienDo = x.tiendo                                
                            });
                return info.ToList();
            }
        }
        public static TaskInfo GetTaskInfo(int ID, string name)
        {
            using (var _context = new DBLabContext())
            {
                var task = (from t in _context.TasksInfo
                            where ((t.ID == ID)&&(t.Viec == name))
                            select t).ToList();
                if (task.Count() == 1)
                {
                    return task[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool UpdateInfo(TaskInfo task)
        {
            try
            {
                using (var _context = new DBLabContext())
                {
                    _context.TasksInfo.AddOrUpdate(task);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
