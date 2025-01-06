using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Manager:Employees
    {
        public override void Fun()
        {
            base.Fun();
            Console.WriteLine("Manager is managing");
        }
    }
}
