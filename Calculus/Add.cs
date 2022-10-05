using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculus
{
    internal class Add : Program
    {
        public decimal Addresult { get; set; }
        public decimal addiresult { get; set;  }
        public Add(decimal number1, decimal number2)
        {           
            decimal additresult = number1 + number2;
            Console.WriteLine($"Number: ({number1} + {number2}) = {additresult}.");
        }
    }
}
