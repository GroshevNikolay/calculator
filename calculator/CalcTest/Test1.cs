using System;
using NUnit.Framework;

namespace calc.Test
{
    [TestFixture]
    public class TestAddition
    {
        [TestCase(2, 3, 5)]
        [TestCase(6, 7, 13)]
        [TestCase(14, 15, 29)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            math_operations.Addition addition = new math_operations.Addition();
            double fullanswer = addition.Calculate(firstNum, secondNum);
            Assert.AreEqual(answer, fullanswer);
        }
    }

    public class TestSubtraction
    {
        [TestCase(6, 3, 3)]
        [TestCase(9, 14, -5)]
        [TestCase(5, 9, -4)]

        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            math_operations.Subtraction subtraction = new math_operations.Subtraction();
            double fullanswer = subtraction.Calculate(firstNum, secondNum);
            Assert.AreEqual(answer, fullanswer);
        }
    }
}