using PRSDbLib;
using PRSDbLib.Folder;
using System;
using System.Linq;

namespace PurchaseRequestSystemDb {
    class Program {
        static void Main(string[] args) {
            




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
            }
            static void CheckForUser(AppDbContext context) {
                var usrs = context.Users.ToList();
                if (usrs.Exists()) {

                }
            }
        }
    }
}
