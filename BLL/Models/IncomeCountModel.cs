using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Models
{
    public class IncomeCountModel
    {
        public int Id { get; set; }

        public double Income { get; set; }

        public IncomeCountModel(Order o, double m)
        {
            Id = o.Id;
            Income = m;
        }
        public IncomeCountModel() { }

    }
}
