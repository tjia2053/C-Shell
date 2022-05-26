using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.DataModel
{
    public class Course
    {
        public int ID { get; set; }
        public int Name { get; set; }

        public int credit { set; get; }

        public List<Student> enrolled { get; set; }
    }
}
