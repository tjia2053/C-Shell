using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.DataModel
{
    public class Student:Person
    {
        public string ID { get; set; }
        public Dictionary<Course, Grade> Grades { get; set; }
    }
}
