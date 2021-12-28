using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models;
using DAL;
using DAL.Interfaces;

namespace BLL.Services
{
    public class IncomeCount : IIncomeCount
    {
        IReportsReprository reports;
        public List<IncomeCountModel> CountIncome(DateTime s, DateTime f)
        {
            var inc = reports.IncomeCount(s, f).Select(i => new IncomeCountModel { Id = i.Id, TotalCost = i.TotalCost, Income = i.Income }).ToList();
            return inc;
        }

        public IncomeCount(IReportsReprository rep)
        {
            reports = rep;
        }
    }
}
