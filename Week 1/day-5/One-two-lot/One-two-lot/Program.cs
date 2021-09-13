using System;

namespace One_two_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            double userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput <= 0)
            {
                Console.WriteLine("Not enought");
            }
            if(userinput == 1) 
            {
                Console.WriteLine("One");
            }
            if (userinput == 2)
            {
                Console.WriteLine("two");
            }
            if (userinput > 2) 
            {
                Console.WriteLine("A lot");
            }
                
            


        }
    }
}
