using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator
{
    public class Calculator
    {
        public static void Calculate()
        {

            string answer;
            Console.WriteLine("Enter your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation would you like to do?");
            Console.WriteLine("Please type one of the following options:+ or - or * or /");
            answer = Console.ReadLine();

            int result = 0;

            if (answer.Trim() == "+")
            {
                result = num1 + num2;
            }
            else if (answer.Trim() == "-")
            {
                result = num1 - num2;
            }
            else if (answer.Trim() == "*")
            {
                result = num1 * num2;
            }
            else if (answer.Trim() == "/")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Please type one of the following options:+ or - or * or /");
            }

            Console.WriteLine($"The result is: " + result);
        }
    }
}
