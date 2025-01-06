using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle
    {
   
        public int Height { get;  }
        public int Width{ get;  }
        #region Constructors
        public Rectangle()
        {
            Height = 0;
            Width = 0;
        }

        public Rectangle(int Height)
        {
            this.Height = Height;
            this.Width = Height;
        }

        public Rectangle(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Height:{Height}\nWidth:{Width}";
        }
        #endregion
    }
}
