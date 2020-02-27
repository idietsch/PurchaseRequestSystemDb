using PRSDbLib;
using PRSDbLib.Controllers;
using PRSDbLib.Folder;
using System;
using System.Linq;

namespace PurchaseRequestSystemDb {
    class Program {
        static void Main(string[] args) {
            var context = new AppDbContext();
            UserController.AddUser(context);
            VendorController.AddVendor(context);
            ProductController.AddProduct(context);
            RequestController.AddRequest(context);

            UserController.GetUserByPk(context);
            VendorController.GetVendorByPk(context);
            ProductController.GetProductByPk(context);
            RequestController.GetRequestsByPk(context);

            UserController.GetAllUsers(context);
            VendorController.GetAllVendors(context);
            ProductController.GetAllProducts(context);
            RequestController.GetAllRequests(context);

            UserController.UpdateUser(context);
            VendorController.UpdateVendors(context);
            ProductController.UpdateProduct(context);
            RequestController.UpdateRequests(context);

            RequestLineController.AddRequestLine(context);
            RequestLineController.GetRequestLinesByPk(context);
            RequestLineController.GetAllRequestLines(context);
            RequestLineController.UpdateRequestLines(context);

            RequestLineController.DeleteRequestLine(context);
            RequestController.DeleteRequest(context);
            ProductController.DeleteProduct(context);
            VendorController.DeleteVendor(context);
            UserController.DeleteUser(context);

           
        }
    }
}
