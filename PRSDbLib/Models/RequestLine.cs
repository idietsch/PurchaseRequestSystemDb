using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PRSDbLib.Folder {
    public class RequestLine {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        public virtual Request Requestx { get; set; }
        public virtual Product Productx { get; set; }

        public override string ToString() => $"{Id}|{RequestId}|{ProductId}|{Quantity}";
        public RequestLine() {

        }
    }
}
