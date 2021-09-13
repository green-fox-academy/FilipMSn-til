using System;

namespace Party_Indikator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second represents the number of boys
            //
            // If the the number of girls and boys are equal and 20 or more people are coming to the party
            // it should print: The party is excellent!
            //
            // If there are 20 or more people coming to the party but the girl - boy ratio is not 1-1
            // it should print: Quite a cool party!
            //
            // If there are less people coming than 20
            // it should print: Average party...
            //
            // If no girls are coming, regardless the count of the people
            // it should print: Sausage party

            Console.WriteLine("How many girl are here?");
            double numGRL = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many boys are here?");
            double numBOY = Convert.ToInt32(Console.ReadLine());

            if ((numGRL + numBOY == 20) && (numGRL == numBOY))
            {
                Console.WriteLine("The party is excellent!"); 
            }

            if (numGRL + numBOY >= 20)
            {
                Console.WriteLine("Quite a cool party!!");
            }

            if (numGRL + numBOY < 20)
            {
                Console.WriteLine("Average party...");
            }

            if (numGRL == 0)
            {
                Console.WriteLine("Average party...");
            }





        }
    }
}
