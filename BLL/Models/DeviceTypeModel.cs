using System;
using DAL;

namespace BLL.Models
{
    public class DeviceTypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double PricePerHour { get; set; }

        public DeviceTypeModel(DeviceType d)
        {
            Id = d.Id;
            TypeName = d.TypeName;
            PricePerHour = d.PricePerHour;
        }
        public DeviceTypeModel() { }
    }
}
