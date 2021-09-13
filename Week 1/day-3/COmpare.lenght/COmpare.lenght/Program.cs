using System;

namespace COmpare.lenght
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`
            // - Otherwise print: "firstArrayOfNumbers is the longer one"


            int[] fNumbers = { 1, 2, 3 };
            int[] sNumbers = { 4,5 };
            if ( sNumbers.Length < fNumbers.Length)
            {
                Console.WriteLine("firstArrayOfNumbers is the longer one");
            }
            
           








        }
    }
}
