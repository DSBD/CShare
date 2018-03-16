using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayroleApp
{
    class HourlyEmployee : Employee
    {
        private double _basePayRate;

        public double BasePayRate
        {
            get { return _basePayRate; }
            set { _basePayRate = value; }
        }

        private double _OTPayRate;

        public double OTPayRate
        {
            get { return _OTPayRate; }
            set { _OTPayRate = value; }
        }

        private double _HoursWorked;

        public double HoursWorked
        {
            get { return _HoursWorked; }
            set { _HoursWorked = value; }
        }

        public HourlyEmployee(double baseRate, double otRate, double hoursWorked, string firstName, string lastName, int SIN) : base(firstName, lastName, SIN)
        {
            BasePayRate = baseRate;
            OTPayRate = otRate;
            HoursWorked = hoursWorked;
        }

        public override double GetPay()
        {
            if(HoursWorked < 40)
            {
                return HoursWorked * BasePayRate;
            }
            else
            {
                return (40 * BasePayRate) + ((HoursWorked - 40) * OTPayRate);
            }
        }
    }
}
