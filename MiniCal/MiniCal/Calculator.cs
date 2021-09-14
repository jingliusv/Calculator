using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCal
{
    class Calculator
    {
        public double Caculate(string inputOperation, double inputNum1, double inputNum2)
        {
            double result;

            switch (inputOperation.ToLower().Trim())
            {
                case "+":
                case "plus":
                    result = inputNum1 + inputNum2;
                    break;
                case "-":
                case "minus":
                    result = inputNum1 - inputNum2;
                    break;
                case "*":
                case "gånger":
                    result = inputNum1 * inputNum2;
                    break;
                case "/":
                case "dela":
                    result = inputNum1 / inputNum2;
                    break;
                default:
                    throw new InvalidOperationException("Du har matat in fel operation.");
            }

            return result;
        }
    }
}
