using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}
