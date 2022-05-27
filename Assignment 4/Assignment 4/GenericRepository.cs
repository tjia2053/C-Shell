using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_4
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        
        List<T> lst = new List<T>();
        public void Add(T item)
        {
            lst.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return lst;
        }

        public T GetbyId(int id)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Id == id)
                {
                    return lst[i];
                }
                
            }
            return null;
        }

        public void Remove(T item)
        {
            lst.Remove(item);
        }

        public void Save()
        {
            
            throw new NotImplementedException();
        }
    }
}
