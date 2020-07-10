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
    public class TaskController
    {
        public static List<Models.Task> GetListTask()
        {
            using (var _context = new DBLabContext())
            {
                var listtask = (from t in _context.Tasks
                                select t).ToList();
                return listtask;
            }
        }
        public static void AddTask(Models.Task task)
        {
            using (var _context = new DBLabContext())
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
            }
        }
        public static void DeleteTask(Models.Task task)
        {
            using (var _context = new DBLabContext())
            {
                var dbTask = (from t in _context.Tasks
                              where t.ID == task.ID
                              select t).SingleOrDefault();
                _context.Tasks.Remove(dbTask);
                _context.SaveChanges();
                try
                {

                    var dbTaskInfo = (from t in _context.TasksInfo
                                      where t.ID == task.ID
                                      select t).SingleOrDefault();
                    _context.TasksInfo.Remove(dbTaskInfo);
                    _context.SaveChanges();
                }
                catch { return; }
                
            }
        }
        public static int UpdateTask(Models.Task task)
        {
            using (var _context = new DBLabContext())
            {

                if (GetTask(task.ID) == null)
                {
                    return -1;
                }
                _context.Tasks.AddOrUpdate(task);
                _context.SaveChanges();
                return 1;
            }
        }
        public static Models.Task GetTask(int id)
        {
            using (var _context = new DBLabContext())
            {
                Models.Task task = _context.Tasks.Where(t => t.ID == id).SingleOrDefault();
                return task;
            }
        }
    }
}
