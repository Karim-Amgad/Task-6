using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Type_A
    {
        private int F; // can only be accessed within scope so it will need a getter setter to modify
        internal int G; // as long as we are within the same project, it won't need a getter setter
        public int H; // it can be reached anywhere

        public Type_A(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }
        public int Get_Set_f
        {
            get { return F; }
            set { F = value; }
        }


    }
}
