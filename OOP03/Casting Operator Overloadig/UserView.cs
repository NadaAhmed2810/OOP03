using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Casting_Operator_Overloadig
{
    //View: Is a class that reprecent will render in a view[HTML]
    internal class UserView
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
        public static explicit operator UserView(User user){
            string[]? Names = user?.Name?.Split(" ");
            return new UserView()
            {
                Id = user?.Id ?? 0,
                FName = Names?.Length > 0 ? Names[0]:string.Empty,
                LName = Names?.Length > 1 ? Names[1] : string.Empty,
                Email =user?.Email ??"",
                Password=user?.Password ??""
            };
            }
    }
}
