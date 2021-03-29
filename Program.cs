using System;

namespace MyFirstCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(number1 + number2);
            } else if (op == "-")
            {
                Console.WriteLine(number1 - number2);
            } else if (op == "*")
            {
                Console.WriteLine(number1 * number2);
            } else if (op == "/")
            {
                Console.WriteLine(number1 / number2);
            } else
            {
                Console.WriteLine("You have entered an invalid operator.");
            }

            Console.ReadLine();
        }
    }
}
