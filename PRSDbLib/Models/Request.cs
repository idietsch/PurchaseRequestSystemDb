using System;
using System.Collections.Generic;
using System.Text;

namespace PRSDbLib.Folder {
    public class Request {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public string RejectionReason { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; private set; }
        public decimal Total { get; private set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<RequestLine> RequestLines { get; set; }
        public Request() {

        }
    }
}
