using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Mathmatics
    {
        public int Calculation(int num1, int num2, out int Sum, ref int Multiply)
        {
            /*In Case of Out Variables, We need to initialize it,
             *inside the callee method, Whatever the request came from the caller it is
             *discarded, did some manulipation and change Out variable, 
             *pass it to the caller by out reference.
            */
            Sum = 10;
            Sum = num1 + num2 + Sum;
            Multiply = num1 * num2;
            return Sum;
        }
    }
}
