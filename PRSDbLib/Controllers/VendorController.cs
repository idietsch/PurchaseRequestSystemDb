using PRSDbLib.Folder;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Controllers {
    public class VendorController {
        static void AddVendor(AppDbContext context) {
            var vend = new Vendor {
                Id = 0,
                Code = "vnd1",
                Name = "Vendor 1",
                Address = "888 Parkway Ave",
                City = "Boston",
                State = "MA",
                Zip = "10101",
                Phone = "5555555555",
                Email = "email@email.com"
            };
            context.Vendors.Add(vend);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Vendor Add Failed");
            else { Console.WriteLine("Vendor Add Successful"); }
        }
        static void DeleteVendor(AppDbContext context) {
            var keytodelete = 1;
            var vendortodelete = context.Vendors.Find(keytodelete);
            if (vendortodelete == null) throw new Exception("Not Found");
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
        }
        static void 
    }
}
