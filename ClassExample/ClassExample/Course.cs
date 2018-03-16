using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample
{
    public class Course
    {
        private string _code;
        private string _title;

        public Course (string code, string title)
        {
            _code = code;
            _title = title;
        }

        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
    }
}
