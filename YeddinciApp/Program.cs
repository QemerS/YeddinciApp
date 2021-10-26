using System;

namespace YeddinciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program that takes two numbers as input
            and perform an operatinon (+ - * /) on them
            and displays the result of that operation.
             */

            Console.WriteLine("Input first number: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input operationr: "); string c = Console.ReadLine();
            Console.WriteLine("Input second number: "); int b = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case "+":
                    Console.WriteLine(Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + "=" + (a + b));
                    break;
                case "-":
                    Console.WriteLine(Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + "=" + (a - b));
                    break;
                case "*" :
                    Console.WriteLine(Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + "=" + (a * b));
                    break;
                case "/" :
                    Console.WriteLine(Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b) + "=" + (a / b));
                    break;
            } Console.WriteLine("You entered something wrong");
        }
    }
}
