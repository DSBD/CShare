using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayroleApp
{
    class DualEmployee : CommisionEmployee
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public DualEmployee(double sales, double commisionPercentage, double salary, string firstName, string lastName, int SIN) : base(sales, commisionPercentage,firstName, lastName, SIN)
        {
            Salary = salary;
        }

        public override double GetPay()
        {
            return base.GetPay() + Salary;
        }
    }
}
