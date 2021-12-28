using System;
using DAL;

namespace BLL.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public double Cost { get; set; }

        public ProductModel(Product p)
        {
            Id = p.Id;
            ProductName = p.ProductName;
            Cost = p.Cost;
        }
        public ProductModel() { }
    }
}
