using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArithmeticCalculatorApi.Services
{
    public class ArithmeticService : IArithmeticService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            return (double)num1 / num2;
        }
    }
}