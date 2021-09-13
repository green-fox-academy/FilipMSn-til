using System;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.s l



            double userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput % 2 )
            {
                Console.WriteLine("even");
            }
            else Console.WriteLine("odd");





            double cx = Convert.ToInt32(Console.ReadLine());
            double result = cx * 1.609;
            Console.WriteLine(result);







        }
    }
}
