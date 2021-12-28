using System;
using DAL;

namespace BLL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDates { get; set; }
        public double? TotalCost { get; set; }
        public int CustomerId { get; set; }
        public int? DeviceId { get; set; }
        public int? ProductId { get; set; }
        public int OrderTypeId { get; set; }

        public void UpdateDates()
        {
            OrderDates = OrderDate.ToString("dd/MM/yyyy");
        }

        public OrderModel(Order o)
        {
            Id = o.Id;
            OrderDate = o.OrderDate;
            OrderDates = OrderDate.ToString("dd/MM/yyyy");
            TotalCost = o.TotalCost;
            CustomerId = o.CustomerId;
            DeviceId = o.DeviceId;
            ProductId = o.ProductId;
            OrderTypeId = o.OrderTypeId;
        }
        public OrderModel() { }
    }
}
