namespace Wedding.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public string  OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Username { get; set; }

        [StringLength(160)]

        public string Email { get; set; }

        public decimal Total { get; set; }

        public string  Address { get; set; }

        public int  Count { get; set; }

        public int ProuductId { get; set; }

        public int LeiBieId { get; set; }
    }
}
