using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Dragos = new Student(991495458, "Dragos", "Baciu-David", 3.63, Status.FullTime);

            Room S302 = new Room();
            S302.HasWifi = true;
            S302.Size = 30;
            S302.RoomNumber = "S302";

            Room E207F = new Room
            {
                HasWifi = true,
                Size = 35,
                RoomNumber = "E207F"
            };

            Course Prog10065 = new Course("PROG 10065", "Interactive App Development");
            Course Math11044 = new Course("MATH 11044", "Linear Algebra");

            Dragos.addCourse(Prog10065);
            Dragos.addCourse(Math11044);

            List <Course> courseListDragos;
            courseListDragos = Dragos.CourseList;

            foreach (Course curCourse in courseListDragos)
            {
                Console.WriteLine($"Course Code: {curCourse.Code} \nCourse Name: {curCourse.Title}\n");
            }

            Student Matthew = new Student(991485675, "Matthew", "Shibatu", 3.21, Status.FullTime);
        }
    }
}