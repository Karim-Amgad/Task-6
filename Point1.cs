using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal struct Point1
    {
        private int X;
        private int Y;

        public Point1(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point1(int x)
        {
            X =x;
            Y =0;
        }
        public void Disp() 
        {
            Console.WriteLine($"{X},{Y}");
        }

        public override string ToString()
        {
            return $"The first coord is {X}, the second coord is {Y}";
        }
        // we have 3 constructors, the 2 declared and the parameterless built-in one
    }
}
