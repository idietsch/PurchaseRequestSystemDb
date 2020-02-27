﻿using PRSDbLib.Folder;
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
        static void GetAllRequests(AppDbContext context) {
            var reqs = context.Requests.ToList();
            foreach(var r in reqs) {
                Console.WriteLine(r);
            }
        }
        //Alt GetAllRequests
        //public IEnumerable<Request> GetAll(){
        //  return context.Requests.ToList();
        //}
        static void GetRequestsByPk(AppDbContext context) {
            var reqpk = 1;
            var req = context.Requests.Find(reqpk);
            if (req == null) throw new Exception("Request Not Found");
            Console.WriteLine(req);
        }
        //Alt GetByPk
        //public Request GetByPk(int id) {
        //  if(id < 1) throw new Exception("Id must be > 0");
        //  return context.Requests.Find(id);
        static void UpdateRequests(AppDbContext context) {
            var reqpk = 1;
            var req = context.Requests.Find(reqpk);
            if (req == null) throw new Exception("Request Not Found");
            req.Justification = "Want";
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Update Failed");
            Console.WriteLine("Update Successful");
        }
    }
}
