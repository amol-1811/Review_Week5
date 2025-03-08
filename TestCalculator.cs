using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Week5
{
    public class TestCalculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Subtract(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        public int Multiply(int a, int b)
        {
            int mul = a * b;
            return mul;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            double div = a / b;
            return div;
        }
    }
}