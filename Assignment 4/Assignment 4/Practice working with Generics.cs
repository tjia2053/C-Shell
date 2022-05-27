using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Mystack<T>
    {
        private Stack<T> lis;
        public Mystack()
        {
            lis = new Stack<T>();
        }

        public int Count()
        {
            return lis.Count;
        }

        public T Pop(T input)
        {
            return lis.Pop();
        }

        public void Push(T input)
        {
            lis.Push(input);
        }
    }

    public class MyList<T>
    {
        private List<T> lis;
        public MyList()
        {
            lis = new List<T>();
        }

        public void Add(T element)
        {
            lis.Add(element);
        }

        public void Romove(T element)
        {
            lis.Remove(element);
        }

        public bool Contaion(T element)
        {
            return lis.Contains(element); 
        }

        public void Clear()
        {
            lis.Clear();
        }

        public void InsertAT(T element, int index)
        {
            lis.Insert(index, element);
        }

        public void DeleteAT(int index)
        {
            lis.RemoveAt(index);
        }

        public T Find(int index)
        {
            return lis[index];
        }
    }
}
