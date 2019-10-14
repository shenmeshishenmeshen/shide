using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wedding.ViewModels
{
    public class OrderViewModel
    {
        public DateTime OrderDate { get; set; }

        public int Count { get; set; }

        public string  Name { get; set; }

        public string   UserName { get; set; }

        public decimal  Total { get; set; }

        public string   OrderId { get; set; }

    }
    public class OrderTotal
    {
        public decimal Total { get; set; }

        public List<OrderViewModel>  OrderViewModels { get; set; }
    }
}