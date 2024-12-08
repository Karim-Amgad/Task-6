using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal struct Point
    {
        private int X;
        private int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //public Point()
        //{
        //    X = default;
        //    Y = default;
        //}
        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }

}
