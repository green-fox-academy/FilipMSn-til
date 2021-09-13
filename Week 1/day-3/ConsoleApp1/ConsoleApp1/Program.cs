using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Please provide the second number:");
            double input1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please provide the second number:");
            double input2 = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("What math operation you want? Plus, minus, multiple divide");
            string what = (Console.ReadLine());

            double result = 0;
            string plus;
            

           switch (what)
            {
                case "plus":
                    result = input1 + input2;
                    break;

                case "minus":
                    result = input1 - input2;
                    break;

                case "multiple":
                    result = input1 * input2;
                    break;

                case "divide":
                    result = input1 / input2;
                    break;










            }

            Console.WriteLine(result);



        }
    }
}
