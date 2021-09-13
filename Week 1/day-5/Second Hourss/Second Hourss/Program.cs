using System;

namespace Second_Hourss
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above

            int currenth = currentHours * 60 * 60;
            int currentM = currentMinutes * 60;

            Console.WriteLine(currentM + currenth + currentSeconds);
           
        }
    }
}
