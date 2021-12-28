using System;
using DAL;

namespace BLL.Models
{
    public class OrderTypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public OrderTypeModel(OrderType o)
        {
            Id = o.Id;
            TypeName = o.TypeName;          
        }
        public OrderTypeModel() { }
    }
}
