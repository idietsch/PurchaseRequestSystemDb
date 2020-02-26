using PRSDbLib;
using PRSDbLib.Folder;
using System;
using System.Linq;

namespace PurchaseRequestSystemDb {
    class Program {
        static void Main(string[] args) {
            
            static string formatPhone(string phoneNum, string phoneFormat) {
                if (phoneFormat == "") 
                  return  phoneFormat = "(###-###-####)";
                

            }



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
            }  //Add a user into the database
            static bool CheckForUser(AppDbContext context, int userId) {   //Check database to see if user exists
                var user = context.Users.Where(u => u.Id == userId).FirstOrDefault();
                if (user == null)
                    return false;
                
                //var usrs = context.Users.ToList();
                //if (usrs.Exists()) {

                //}
            }
        }
    }
}
