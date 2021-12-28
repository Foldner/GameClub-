using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class IncomeCountModel
    {
        public int Id { get; set; }

        public double? TotalCost { get; set; }

        public double Income { get; set; }
    }
}
