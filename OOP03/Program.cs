using OOP03.Casting_Operator_Overloadig;
using OOP03.Operators_Overloading;
using OOP03.Overriding;
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


            #region Binary Operator

            //Complex C1 = new Complex() { Real = 6, Imag = 4 };
            //Complex C2 = new Complex() { Real = 8, Imag = 10 };
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
            //int Y = (int)C1;//Explicit Casting
            //Console.WriteLine(Y);
            //#endregion
            //#region Ex02
            //string s = C1;//implicit Casting
            //Console.WriteLine(s);
            #endregion
            #endregion
            #region CASTING OPERATOR [NEED IN BUSSINESS]
            //User user = new User() {
            //   Id=10,
            //   Name="Nour",
            //   Email="Nour@gmail",
            //   Password="Nour123"};
            //  UserView userView = (UserView)user;
            //    Console.WriteLine(userView.Id);
            //    Console.WriteLine(userView.FName);
            //    Console.WriteLine(userView.LName);
            //    Console.WriteLine(userView.Email);
            //    Console.WriteLine(userView.Password);

            #endregion
            #region Overriding
            //TypeA typeA = new TypeA(1);
            //typeA.A = 5;
            //typeA.MyFun01();//I am Base [Parent]
            //typeA.MyFun02();// TypeA:{5}
            //TypeB typeB =new TypeB(1, 2);
            //typeB.A = 3;
            //typeB.B = 4;
            //typeB.MyFun01();
            //typeB.MyFun02();

            //static binding 
            //TypeA typeA = new TypeB(3,4 );
            //typeA.A = 6;
            //typeA.MyFun01();
            //typeA.MyFun02();



            #endregion
            #region What is Binding?
            //Binding: Is Behavior
            //1.Static Binding
            //2.Dynamic Binding اسناد بعتمد ع حد 
            //Reference from parent refer object from child
            //TypeA RefBase=new TypeB(1,2);
            //RefBase.A = 4;
            //RefBase.MyFun01();//static Binding[early]
            //Complier Will Bind Function Call Based on Reference not Object 
            //at Compilation Time[IL]
            //RefBase.MyFun02();//Dynamic Binding[late]
            //CLR Will Bind Function Call Based on Object 
            //at Run Time
            #endregion
            #region Child is parent 
            //TypeA typeA;
            //typeA = new TypeA(1);
            //typeA = new TypeC(1,2,3);
            //TypeB typeB =(TypeB)typeA;//CLR Casting operator  
            #endregion

        }
    }
}
