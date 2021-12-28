using System;
using DAL;

namespace BLL.Models
{
    public class StatusTypeModel
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public StatusTypeModel(StatusType s)
        {
            Id = s.Id;
            StatusName = s.StatusName;
        }
        public StatusTypeModel() { }
    }
}
