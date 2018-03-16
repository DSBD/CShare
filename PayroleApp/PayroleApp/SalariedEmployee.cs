using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayroleApp
{
    class SalariedEmployee : Employee
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public SalariedEmployee(double salary, string firstName, string lastName, int SIN) : base(firstName, lastName, SIN)
        {
            Salary = salary;
        }

        public override double GetPay()
        {
            return Salary;
        }
    }
}
