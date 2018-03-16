using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample
{
    public enum Status
    {
        PartTime,
        FullTime
    }

    public class Student
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private double _gpa;
        private Status _status;
        private List<Course> _courseList;

        public Student(int studentID, string firstName, string lastName, double gpa, Status status)
        {
            _id = studentID;
            _firstName = firstName;
            _lastName = lastName;
            _gpa = gpa;
            _status = status;
            _courseList = new List<Course>();
        }

        public Student()
        {
            //Blank Contructor
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public double GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                if(value < 0 || value > 100)
                {
                    throw new Exception("GPA should be between 0 and 100");
                }
                _gpa = value;
            }
        }

        public Status Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public List<Course> CourseList
        {
            get
            {
                return _courseList;
            }
        }

        public string GetStudentName()
        {
            string fullName;
            fullName = $"{_firstName} {_lastName}";

            return fullName;
        }

        public void SetStudentStatus(Status newStatus)
        {
            _status = newStatus;
        }

        public void addCourse(Course newCourse)
        {
            _courseList.Add(newCourse);
        }

        public void SaveToDatabase()
        {
            //TODO: Save to Database
        }
    }
}