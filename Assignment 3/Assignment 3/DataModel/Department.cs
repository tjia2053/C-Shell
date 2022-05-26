using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.DataModel
{
    internal class Department
    {
        public int ID { set; get; }
        public Instructor Head { get; set; }

        public Decimal Budget { get; set; }

        public List<Course> Offer { get; set; }
    }
}
