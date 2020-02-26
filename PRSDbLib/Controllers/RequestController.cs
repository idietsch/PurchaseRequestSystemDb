using PRSDbLib.Folder;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Controllers {
    public class RequestController {
        static void AddRequest(AppDbContext context) {
            var req = new Request {
                Id = 0,
                Description = "Request 1",
                Justification = "Justification 1",
                RejectionReason = null,
                DeliveryMode = default,
                Status = default,
                Total = 100,
                UserId = 1
            };
            context.Requests.Add(req);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Request Add Failed");
            else { Console.WriteLine("Request Add Successful"); }
        }
        static void DeleteRequest(AppDbContext context) {
            var keytodelete = 1;
            var requesttodelete = context.Requests.Find(keytodelete);
            if (requesttodelete == null) throw new Exception("Not Found");
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete Failed");
        }
    }
}
