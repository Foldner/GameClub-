namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public double? TotalCost { get; set; }

        public int CustomerId { get; set; }

        public int? DeviceId { get; set; }

        public int? ProductId { get; set; }

        public int OrderTypeId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Device Device { get; set; }

        public virtual OrderType OrderType { get; set; }

        public virtual Product Product { get; set; }
    }
}
