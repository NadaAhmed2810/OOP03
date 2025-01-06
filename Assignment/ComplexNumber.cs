using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ComplexNumber
    {
        #region property
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion
        #region Binary Operator
       
        public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };

        }
        public static ComplexNumber operator -(ComplexNumber Left, ComplexNumber Right)
        {
            return new ComplexNumber()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };

        }


        #endregion
  
        #region Methods
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        #endregion
    }
}
