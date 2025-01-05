using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int A) {
            this.A = A;

        }
        public void MyFun01()
        {
            Console.WriteLine("MyFun01= I am Base[Parent]");
        }
        public virtual  void  MyFun02()
        {
            Console.WriteLine($"MyFun02=TypeA:{A}");
        }
    }
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int A,int B):base(A)
        {
           this .B = B;

        }
        //Apply Overriding Using "new" Keyword =>Hiding/Masking OLD Method
        public new void MyFun01() /*static Binding method[early in compltion time] */
        {
            Console.WriteLine("MyFun01= I am Child [Derived]");
        }
        //There the same idea
        //public new  string MyFun01(int x)
        //{
        //    return "MyFun01= I am Child [Derived]";
        //}

        //Apply overriding Using "overriding" [Must be not Private and virtual in first occur]
        //Add extra Behavior 
        public override void MyFun02()/*Dynamic Binding method [late in run time]*/
        {
            Console.WriteLine($"MyFun02=TypeA:{A},TypeB:{B}");
        }
    }
}
