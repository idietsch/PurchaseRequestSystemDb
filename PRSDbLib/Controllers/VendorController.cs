using PRSDbLib.Folder;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Controllers {
    public class VendorController {
        public static void AddVendor(AppDbContext context) {
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
        public static void DeleteVendor(AppDbContext context) {
            var keytodelete = 1;
            var vendortodelete = context.Vendors.Find(keytodelete);
            if (vendortodelete == null) throw new Exception("Not Found");
            context.Remove(vendortodelete);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
            Console.WriteLine("Delete Successful");
        }
        public static void GetVendorByPk(AppDbContext context) {
            var vendpk = 1;
            var vend = context.Vendors.Find(vendpk);
            if (vend == null) throw new Exception("Not Found");
            Console.WriteLine(vend);
        }
        public static void GetAllVendors(AppDbContext context) {
            var vends = context.Vendors.ToList();
            foreach(var v in vends) {
                Console.WriteLine(v);
            }
        }
        public static void UpdateVendors(AppDbContext context) {
            var vendpk = 1;
            var vend = context.Vendors.Find(vendpk);
                if (vend == null) throw new Exception("Vendor Not Found");
            vend.Zip = "01010";
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Update Failed");
            Console.WriteLine("Update Successful");
            
        }
    }
}
