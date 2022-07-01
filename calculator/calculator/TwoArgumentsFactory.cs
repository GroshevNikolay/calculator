using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoCalculator Creator (string calculatorName)
        {
            switch (calculatorName)
            {
                case "сложение":
                    math_operations.Addition addition = new math_operations.Addition();
                    return addition;

                case "степень":
                    math_operations.Degree degree = new math_operations.Degree();
                    return degree;

                case "деление":
                    math_operations.Division division = new math_operations.Division();
                    return division;

                case "умножение":
                    math_operations.Multiplication multiplication = new math_operations.Multiplication();
                    return multiplication;

                case "остаток":
                    math_operations.Remainder remainder = new math_operations.Remainder();
                    return remainder;

                case "вычитание":
                    math_operations.Subtraction subtraction = new math_operations.Subtraction();
                    return subtraction;

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
