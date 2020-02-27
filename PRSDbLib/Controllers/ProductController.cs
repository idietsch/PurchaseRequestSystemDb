using PRSDbLib.Folder;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Controllers {
    public class ProductController {
        static void AddProduct(AppDbContext context) {
            var prod = new Product {
                Id = 0,
                PartNbr = "Prod1",
                Name = "Product 1",
                Price = 10,
                Unit = "Single",
                PhotoPath = "",
                VendorId = 1
            };
            context.Products.Add(prod);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Product Add Failed");
            else { Console.WriteLine("Product Add Successful"); }
        }
        static void DeleteProduct(AppDbContext context) {
            var keytodelete = 1;
            var producttodelete = context.Products.Find(keytodelete);
            if (producttodelete == null) throw new Exception("Not Found");
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
        }
        static void GetAllProducts(AppDbContext context) {
            var prods = context.Users.ToList();
            foreach (var p in prods) {
                Console.WriteLine(p);
            }
        }
        static void GetProductByPk(AppDbContext context) {
            var prodpk = 1;
            var prod = context.Products.Find(prodpk);
            if (prod == null) throw new Exception("Product Not Found");
            Console.WriteLine(prod);
        }
        static void UpdateProduct(AppDbContext context) {
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
