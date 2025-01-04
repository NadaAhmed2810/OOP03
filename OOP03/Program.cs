using OOP03.Operators_Overloading;
using System;


namespace OOP03 
{
    internal class Program
    {
        #region Overloading
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        static double Sum(double x, double y)
        {
            return x + y;
        }
        static double Sum(int x, double y)
        {
            return x + y;
        }

        #endregion
        static void Main(string[] args)
        {
            #region OOP Paller 3 Polymorphism 1.Overloading

            //dynamic obj = "Nada";
            //obj = 5;
            //obj = 5.5;
            //dynamic result =Sum(1,2);
            //Console.WriteLine(result);
            //result =       Sum(1, 2,3);
            //Console.WriteLine(result);
            //Console.WriteLine("Nada");//19 overload
            //Console.WriteLine('A'); 
            //Console.WriteLine(1);
            //Console.WriteLineString(1);
            //Console.WriteLineBool(1);
            //Console.WriteLineChar(1);
            //Console.WriteLineInt(1);

            #endregion

            Complex C1 = new Complex(){ Real=6,Imag=4};
            Complex C2 = new Complex() { Real =8 , Imag =10 };

            #region Binary Operator
            //Complex C3=default;//null
            //C3 = C1 + C2;
            //C2 += C1;
            //Complex C4 = C1 + C2 + C3;
            //Console.WriteLine($"C1:{C1}");
            //Console.WriteLine($"C2:{C2}");
            //Console.WriteLine("---------");
            //Console.WriteLine($"C3:{C3}"); 
            #endregion
            #region Unary Operator
            //Console.WriteLine($"Before:{C1}");
            //Complex C3 = C1++;
            //Console.WriteLine($"After:{C1}");
            //Console.WriteLine($"C3:{C3}");
            #endregion
            #region Compersion Operator
            //if (C1 > C2)
            //{
            //    Console.WriteLine("C1 is Greater Than C2");
            //}
            //else if (C1 < C2)
            //{
            //    Console.WriteLine("C1 is Less Than  C2");
            //}
            //else
            //{
            //    Console.WriteLine("C1 is Equal  C2");
            //}


            #endregion
            #region Casting Operator
            #region Ex01
            int Y = (int)C1;//Explicit Casting
            Console.WriteLine(Y);
            #endregion
            #region Ex02
            string s = C1;//implicit Casting
            Console.WriteLine(s);
            #endregion
            #endregion   

        }
    }
}
