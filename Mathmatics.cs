using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Mathmatics
    {
        public int Calculation(int num1, int num2, out int Sum, out int Multiply)
        {
            Sum = num1 + num2;
            Multiply = num1 * num2;
            return Sum;
        }
    }
}
