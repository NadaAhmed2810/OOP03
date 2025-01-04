using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Operators_Overloading
{
    internal class Complex
    {
        #region property
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion
        #region Binary Operator
        //Overloading Operator:Must Be Not_Private And Class Member Function By logic:)
        public static Complex operator +(Complex Left, Complex Right) {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };

        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real??0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };

        }


        #endregion
        #region Unary Operator
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0)+1 ,
                Imag = (C?.Imag ?? 0) 
            };


        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };


        }

        #endregion
        #region Compersion Operator
        public static bool operator>(Complex Left ,Complex Right)
            {
            if ((Left?.Real ?? 0) == (Right?.Real ?? 0))
            {
                return (Left?.Imag ?? 0) > (Right?.Imag ?? 0);
            }

            return (Left?.Real ?? 0) > (Right?.Real ?? 0);

            }
        public static bool operator <(Complex Left, Complex Right)
        {
            if ((Left?.Real ?? 0) == (Right?.Real ?? 0))
            {
                return (Left?.Imag ?? 0) < (Right?.Imag ?? 0);
            }

            return (Left?.Real ?? 0) < (Right?.Real ?? 0);

        }
        #endregion
        #region Casting Operator Overloading
        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real??0;
        }
        public static  implicit operator string(Complex C)
        {
            return C?.ToString()??"";
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
