using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21529664_HW06.Models
{
    public class OrderVM
    {
        public int OrderID{ get; set; }
        public product Product { get; set; }
        public decimal GrandTotal { get; set; }
        public int Quantity { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string CategoryName { get; set; }
    }
}