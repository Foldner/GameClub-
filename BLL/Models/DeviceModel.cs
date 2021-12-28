using System;
using DAL;

namespace BLL.Models
{
    public class DeviceModel
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public DateTime? ReleaseTime { get; set; }
        public string ReleaseTimes { get; set; }
        public int DeviceTypeId { get; set; }
        public int? StatusTypeId { get; set; }

        public void UpdateDates()
        {
            //ReleaseTimes = ReleaseTime.ToString();
            ReleaseTimes = ReleaseTime.HasValue? ReleaseTime.Value.ToString("yyyy/MM/dd hh:mm:ss") : "[N/A]";
        }

        public DeviceModel(Device d)
        {
            Id = d.Id;
            DeviceName = d.DeviceName;
            ReleaseTime = d.ReleaseTime;
            ReleaseTimes = ReleaseTime.HasValue ? ReleaseTime.Value.ToString("yyyy/MM/dd hh:mm:ss") : "[N/A]";
            DeviceTypeId = d.DeviceTypeId;
            StatusTypeId = d.StatusTypeId;
        }

        public DeviceModel()
        {

        }
    }
}
