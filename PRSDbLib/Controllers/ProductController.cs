using PRSDbLib.Folder;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Controllers {
    public class ProductController {
        public static void AddProduct(AppDbContext context) {
            var prod = new Product {
                Id = 0,
                PartNbr = "Prod2",
                Name = "Product 2",
                Price = 20,
                Unit = "Dozen",
                PhotoPath = "No Look Over Here",
                VendorId = 2
            };
            context.Products.Add(prod);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Product Add Failed");
            else { Console.WriteLine("Product Add Successful"); }
        }
        public static void DeleteProduct(AppDbContext context) {
            var keytodelete = 1;
            var producttodelete = context.Products.Find(keytodelete);
            if (producttodelete == null) throw new Exception("Not Found");
            context.Remove(producttodelete);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
            Console.WriteLine("Delete Successful");
        }
        public static void GetAllProducts(AppDbContext context) {
            var prods = context.Products.ToList();
            foreach (var p in prods) {
                Console.WriteLine(p);
            }
        }
        public static void GetProductByPk(AppDbContext context) {
            var prodpk = 1;
            var prod = context.Products.Find(prodpk);
            if (prod == null) throw new Exception("Product Not Found");
            Console.WriteLine(prod);
        }
        public static void UpdateProduct(AppDbContext context) {
            var prodpk = 1;
            var prod = context.Products.Find(prodpk);
                if (prod == null) throw new Exception("Product Not Found");
                prod.Price = 250;
                var rowsAffected = context.SaveChanges();
                if (rowsAffected != 1) throw new Exception("Update Failed");
                Console.WriteLine("Update Successful");
        }
    }
}
