using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void  Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetbyId(int id);
    }
}
