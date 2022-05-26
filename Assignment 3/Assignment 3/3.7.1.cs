using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Color

    {
        public byte Red { get; set; }
        public byte Green { get; set; }

        public byte Blue { get; set; }

        public byte Alpha { get; set; }
    }

    public class Ball
    {
        public int Size { get; set; }

        public Color color { get; set; }

        public int NumberofThrown { get; set; }

        public void pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            NumberofThrown++;
        }

        public int GetThrown()
        {
            return NumberofThrown;
        }
    }
}
