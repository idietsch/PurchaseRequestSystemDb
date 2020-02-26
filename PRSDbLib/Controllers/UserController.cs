using PRSDbLib.Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRSDbLib.Controllers {
    public class UserController {
        static void AddUser(AppDbContext context) {
            var use = new User {
                Id = 0,
                Username = "Username1",
                Password = "Password1",
                Firstname = "John",
                Lastname = "Johnson",
                Phone = null,
                Email = "email1@email1.com",
                IsReviewer = true,
                IsAdmin = false
            };
            context.Users.Add(use);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("User Add Failed");
            else { Console.WriteLine("User Add Successful"); }
            Console.WriteLine("User Added");
        }  //Add a user into the database
        static void DeleteUser(AppDbContext context) {
            var keytodelete = 1;
            var usertodelete = context.Users.Find(keytodelete);
            if (usertodelete == null) throw new Exception("Not Found");
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
            Console.WriteLine("Delete Successful");
        }
        static void GetAllUsers(AppDbContext context) {
            var usrs = context.Users.ToList();
            foreach(var u in usrs) {
                Console.WriteLine(u);
            }
        }
        static void GetUserByPk(AppDbContext context) {
            var usrpk = 1;
            var usr = context.Users.Find(usrpk);
            if(usr == null) throw new Exception ("User Not Found");
            Console.WriteLine(usr);
        }
        static void UpdateUser(AppDbContext context) {
            var usrpk = 1;
            var usr = context.Users.Find(usrpk);
            if (usr == null) throw new Exception("User Not Found");
            usr.IsReviewer = true;
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Update Failed");
            Console.WriteLine("Update Successful");
        }
    }
}
