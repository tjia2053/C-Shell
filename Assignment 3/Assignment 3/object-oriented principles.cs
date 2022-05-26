using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Point1
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
    public abstract class Shape
    {
        public Point1 Center { get; set; }

        public int Len { get; set; }


        public abstract void area();
    }

    public class Cycle : Shape
    {


        public override void area()
        {
            Console.WriteLine($"The area will be {Len * Len * 3.14 / 2 / 2}");
        }
    }

    public class Rectangle : Shape
    {
        public override void area()
        {
            Console.WriteLine($"The area will be {Len * Len}");
        }
    }

    public class Person
    {
        public string Id { get; set; }
        public DateTime Birthday { get; set; }

        private decimal salary;

        public List<string> Address { get; set; }

        public decimal Salary
        {

            get { return salary; }
            set
            {
                if (value > 0) salary = value;
                else Console.WriteLine("Salary can not be negative");
            }
        }

        public void Getage()
        {
            Console.WriteLine(DateTime.Now.Year - Birthday.Year);
        }





    }

    public class Student : Person
    {
        public string ID { get; set; }
        public Dictionary<Course, Grade> Grades { get; set; }

        public void Getgpa(Dictionary<Course, Grade> input)
        {
            int sum = 0;
            int totalcredit = 0;
            foreach (var course in input)
            {
                sum = sum + course.Key.credit * ((int)course.Value);
                totalcredit = totalcredit + ((int)course.Value);
            }
            Console.WriteLine(sum / totalcredit);

        }


        public class Instructor : Person
        {
            public int ID { get; set; }
            public string Department { set; get; }

            public DateTime Joindata { get; set; }



        }

        public class Course
        {
            public int ID { get; set; }
            public int Name { get; set; }

            public int credit { set; get; }

            public List<Student> enrolled { get; set; }
        }

        public class Department
        {
            public int ID { set; get; }
            public Instructor Head { get; set; }

            public Decimal Budget { get; set; }

            public List<Course> Offer { get; set; }
        }

        public enum Grade
        {
            F = 0, E = 0, D, C, B, A
        }


    } }
