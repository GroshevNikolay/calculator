﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.math_operations
{
    public class Division : ITwoCalculator
    {
        public double Calculate(double a, double b)
        {
            return a / b;
        }
    }
}