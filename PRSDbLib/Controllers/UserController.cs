using PRSDbLib.Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRSDbLib.Controllers {
    public class UserController {
        public static void AddUser(AppDbContext context) {
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
        //Alt AddUser
        //public User Insert(User user) {
        //  if(user == null) throw new Exception ("User cannot be null")
        //  context.User.Add(request)
        //  try {
        //      context.SaveChanges();
        //} catch(DbUpdateException ex) {
        //      throw new Exception("Username must be unique", ex);
        //} catch(Exception ex) {
        //      throw;
        //}
        //return request;
        public static void DeleteUser(AppDbContext context) {
            var keytodelete = 1;
            var usertodelete = context.Users.Find(keytodelete);
            if (usertodelete == null) throw new Exception("Not Found");
            context.Remove(usertodelete);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
            Console.WriteLine("Delete Successful");
        }
        //Alt DeleteUser
        //public bool Delete(int id) {
        //  if(id <= 0) throw new Exception("Id Must Be Above 0");
        //  var user = context.Users.Find(id);
        //  context.Users.remove(); 
        //  return Delete(user); }
        //public bool Delete(User user){
        //  context.Users.Remove(user);
        //  context.SaveChanges();
        //  return true;
        public static void GetAllUsers(AppDbContext context) {
            var usrs = context.Users.ToList();
            foreach(var u in usrs) {
                Console.WriteLine(u);
            }
        }
        public static void GetUserByPk(AppDbContext context) {
            var usrpk = 1;
            var usr = context.Users.Find(usrpk);
            if(usr == null) throw new Exception ("User Not Found");
            Console.WriteLine(usr);
        }
        public static void UpdateUser(AppDbContext context) {
            var usrpk = 1;
            var usr = context.Users.Find(usrpk);
            if (usr == null) throw new Exception("User Not Found");
            usr.IsReviewer = true;
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Update Failed");
            Console.WriteLine("Update Successful");
        }
        //Alt UpdateUser
        //public bool Update(int id, User user) {
        //  if(user == null) throw new Exception ("User cannot be null");
        //  if(id != user.Id) throw new Exception ("Id and User.Id must match");
        //  context.Entry(user).State = EntityState.Modified;
        //  try{
        //      context.SaveChanges();
        //} catch(DbUpdateException ex) {
        //      throw new Exception("Username Must Be Unique", ex);
        //} catch(Exception ex) {
        //      throw; }
    }
}
