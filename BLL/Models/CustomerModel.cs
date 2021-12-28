using System;
using DAL;

namespace BLL.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthDates { get; set; }
        public DateTime RegDate { get; set; }
        public string RegDates { get; set; }
        public double? MoneySpent { get; set; }
        public string Login { get; set; }

        public void UpdateDates()
        {
            BirthDates = BirthDate.ToString("dd/MM/yyyy");
            RegDates = RegDate.ToString("dd/MM/yyyy");
        }

        public CustomerModel(Customer c)
        {
            Id = c.Id;
            CustomerName = c.CustomerName;
            PhoneNumber = c.PhoneNumber;
            BirthDate = c.BirthDate;
            BirthDates = BirthDate.ToString("dd/MM/yyyy");
            RegDate = c.RegDate;
            RegDates = RegDate.ToString("dd/MM/yyyy");
            MoneySpent = c.MoneySpent;
            Login = c.Login;
        }

        public CustomerModel()
        {

        }
    }
}
