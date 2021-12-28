using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
{
    public class ReportRepository : IReportsReprository
    {
        private GCdb db;

        public ReportRepository(GCdb dbcontext)
        {
            db = dbcontext;
        }

        public class preIncome
        {
            public int Id { get; set; }
            public double Income { get; set; }
        }

        public List<IncomeCountModel> IncomeCount(DateTime s, DateTime f)
        {
            var PreRes = (from ord in db.Order                         
                          where (s <= ord.OrderDate && f >= ord.OrderDate)
                          select new preIncome
                          {
                              Id = ord.Id,
                              Income = (double)ord.TotalCost,
                          }).ToList();

            List<Order> allorders = db.Order.ToList();
            double incomeCount = 0;

            foreach (preIncome ps in PreRes)
            {
                incomeCount += ps.Income;
            }

            //var TotalIncome = new IncomeCountModel { Id = 1, Income = incomeCount};

            var TotalIncome = (from pr in PreRes
                           where (pr.Id == 1)
                           select new IncomeCountModel
                           {
                               Id = 1,
                               Income = incomeCount
                           }
                          ).ToList();
            return TotalIncome;
        }
    }
}