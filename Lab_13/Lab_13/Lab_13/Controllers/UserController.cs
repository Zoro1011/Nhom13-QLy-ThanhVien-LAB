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
    public class UserController
    {
        //public static void initializeDB()
        //{
        //    using (var _context = new DBLabContext())
        //    {
        //        var user = new User();

        //    }    
        //}
        public static List<User> GetListUser()
        {
            using (var _context = new DBLabContext())
            {
                var listuser = (from u in _context.Users
                                select u).ToList();
                return listuser;
            }
        }
        public static void AddUser(User user)
        {
            using (var _context = new DBLabContext())
            {
                _context.Users.Add(user);
                try
                {
                    _context.SaveChanges();
                }
                catch { return; }
            }
        }
        public static void DeleteUser(User user)
        {
            using (var _context = new DBLabContext())
            {
                var dbUser = (from u in _context.Users.AsEnumerable()
                              where u.username == user.username
                              select u).SingleOrDefault();
                _context.Users.Remove(dbUser);
                _context.SaveChanges();
            }
        }
        public static int UpdateUser(User user)
        {
            using (var _context = new DBLabContext())
            {

                if (GetUser(user.username) == null)
                {
                    return -1;
                }
                _context.Users.AddOrUpdate(user);
                _context.SaveChanges();
                return 1;
            }
        }
        public static User GetUser(string username)
        {
            using (var _context = new DBLabContext())
            {
                User user = _context.Users.Where(u => u.username == username).SingleOrDefault();
                return user;
            }
        }
        public static List<User> getListUser(string usernamesearch)
        {
            using (var _context = new DBLabContext())
            {
                var user = (from u in _context.Users.AsEnumerable()
                            where u.username.Contains(usernamesearch)
                            select new
                            {
                                username = u.username,
                                fullname = u.fullname,
                                bday = u.bday,
                                level = u.level,
                                phone = u.phone,
                                email = u.email,
                                photo = u.photo_aray,
                                salary = u.salary
                            })
                            .Select(x => new User
                            {
                                username = x.username,
                                fullname = x.fullname,
                                bday = x.bday,
                                level = x.level,
                                phone = x.phone,
                                email = x.email,
                                photo_aray = x.photo,
                                salary = x.salary
                            }).ToList();
                return user;

            }
        }
    }
}
