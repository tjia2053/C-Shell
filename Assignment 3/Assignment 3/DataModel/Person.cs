using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.DataModel
{
    public class Person
    {
        public string Id { get; set; }
        public DateTime Birthday { get; set; }
        public List<string> Address { get; set; }

        private decimal salary;
        public decimal Salary
        {

            get { return salary; }
            set
            {
                if (value > 0) salary = value;
                else Console.WriteLine("Salary can not be negative");
            }
        }

    }
}
