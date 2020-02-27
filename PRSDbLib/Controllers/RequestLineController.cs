using PRSDbLib.Folder;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Controllers {
    public class RequestLineController {
        public static void AddRequestLine(AppDbContext context) {
            var reql = new RequestLine {
                Id = 0,
                ProductId = 2,
                RequestId = 2,
                Quantity = 4
            };
            context.RequestLines.Add(reql);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("RequestLine Add Failed");
            else { Console.WriteLine("RequestLine Add Successful"); }
        }

        public static void DeleteRequestLine(AppDbContext context) {
            var keytodelete = 1;
            var requestlinetodelete = context.RequestLines.Find(keytodelete);
            if (requestlinetodelete == null) throw new Exception("RequestLine Not Found");
            context.Remove(requestlinetodelete);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
            Console.WriteLine("Delete Successful");
        }
        public static void GetAllRequestLines(AppDbContext context) {
            var reqls = context.RequestLines.ToList();
            foreach (var r in reqls) {
                Console.WriteLine(r);
            }
        }
        public static void GetRequestLinesByPk(AppDbContext context) {
            var reqlpk = 1;
            var reql = context.RequestLines.Find(reqlpk);
            if (reql == null) throw new Exception("RequestLine Not Found");
            Console.WriteLine(reql);
        }
        public static void UpdateRequestLines(AppDbContext context) {
            var reqpk = 1;
            var req = context.RequestLines.Find(reqpk);
            if (req == null) throw new Exception("RequestLine Not Found");
            req.Quantity = 5;
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Update Failed");
            Console.WriteLine("Update Successful");
        }
    }
}
