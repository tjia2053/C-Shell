using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_3;

namespace Assignment_3
{
    public interface IPersonService<Person> where Person : class
    {
        public void Getage()
        {
            Console.WriteLine(DateTime.Now.Year - Person.Birthday.Year);
        }
    }
}
