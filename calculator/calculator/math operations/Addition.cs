using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.math_operations
{
    public class Addition : ITwoCalculator
    {
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}
