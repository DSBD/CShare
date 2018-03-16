using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayroleApp
{
    class CommisionEmployee : Employee
    {
        private double _sale;

        public double Sales
        {
            get { return _sale; }
            set { _sale = value; }
        }

        private double _CommisionPercentage;

        public double CommisionPercentage
        {
            get { return _CommisionPercentage; }
            set { _CommisionPercentage = value; }
        }

        public CommisionEmployee(double sales, double commisionPercentage, string firstName, string lastName, int SIN) : base(firstName, lastName, SIN)
        {
            Sales = sales;
            CommisionPercentage = commisionPercentage;
        }

        public override double GetPay()
        {
            return Sales * (1 + CommisionPercentage);
        }
    }
}
