using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter ic = new InputConverter();
                Calculator c = new Calculator();
                Console.Write("Tal 1: ");
                double num1 = ic.ConvertInputToNum(Console.ReadLine());
                Console.Write("Tal 2: ");
                double num2 = ic.ConvertInputToNum(Console.ReadLine());
                Console.Write("Operation: ");
                string operation = Console.ReadLine();

                double result = c.Caculate(operation, num1, num2);
                Console.WriteLine($"Resultat: {result}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
