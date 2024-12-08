using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem-1
            //Point P1 = new Point();
            //Console.WriteLine(P1);
            //Point P11 = new Point(2, 6);
            //Console.WriteLine(P11);
            #endregion

            #region Question-1
            // because it is a value type that can't inherite from a reference type
            #endregion

            #region Problem-2
            //Type_A P2 = new Type_A(9,8,7);
            //Console.WriteLine(P2.Get_Set_f);
            //Console.WriteLine(P2.G);
            //Console.WriteLine(P2.H);
            //P2.Get_Set_f = 77;
            //Console.WriteLine(P2.Get_Set_f);
            #endregion

            #region Question-2
            // it has 6 AM can be written in it:

            // private can be reached only within the same scope and class it was declared in it.
            // private protected can be reached within same scope and classes inherite from it within same project
            // protected can be reached in classes inherite from it either same project or different one
            // internal protected can be reached in same project and classes inherite from it in same project or different one
            // internal can be reached in the same project
            // public can be reached anywhere
            #endregion

            #region Problem-3
            //Employee P3 = new Employee(10,"Ali",4672);
            //P3.SetName("Karim"); // can be edited
            ////P3.empid = 125; // can't be edited
            ////P3.salary = 60000; // can't be edited
            //Console.WriteLine(P3.empId);
            //Console.WriteLine(P3.GetName());
            //Console.WriteLine(P3.salary);
            #endregion

            #region Question-3
            // to ensure data safety as it forbiddens methods to direct access the data inside it
            #endregion

            #region Problem-4
            //Point1 P4 = new Point1();
            //P4.Disp();
            //Point1 P44 = new Point1(5);
            //P44.Disp();
            //Point1 P444 = new Point1(22,67);
            //P444.Disp();
            #endregion

            #region Question-4
            // It's a special method that is automatically called when an instance of a class or struct is created or can be user defined.
            // it's the same as in classes but the main difference is it can't inherite from others as structs cannot inherit from
            // other structs or classes as it is value type not reference type
            #endregion

            #region Problem-5
            //Point1 P5 = new Point1(154322);
            //Point1 P55 = new Point1(15235436,77800);
            //Point1 P555 = new Point1(12135);
            //Point1 P5555 = new Point1(154325);
            //Point1 P55555 = new Point1();
            //Console.WriteLine(P5.ToString());
            //Console.WriteLine(P55.ToString());
            //Console.WriteLine(P555.ToString());
            //Console.WriteLine(P5555.ToString());
            //Console.WriteLine(P55555.ToString());
            #endregion

            #region Question-5
            //because it provides a way to change its behaviour into a wanted and clearer one to ease readability
            // instead of showing the project name and type, it can be changed into anything I want
            #endregion
        }
    }
}
