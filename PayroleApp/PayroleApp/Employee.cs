using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayroleApp
{
    public abstract class Employee
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string MyProperty
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _SIN;

        public int SINNumber
        {
            get { return _SIN; }
            set { _SIN = value; }
        }

        public Employee(String firstName, String lastName, int SIN)
        {
            _firstName = firstName;
            _lastName = lastName;
            _SIN = SIN;
        }

        public Employee()
        {
            //Blank Constructor
        }

        public abstract double GetPay();
    }
}
