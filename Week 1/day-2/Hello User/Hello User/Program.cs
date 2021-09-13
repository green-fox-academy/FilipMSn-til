using System;

namespace Hello_User
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet the User instead of the World!
            // The program should ask for the name of the User
            Console.WriteLine("Hello, write your name");
            string name = Console.ReadLine();

            
            Console.WriteLine("Hello" + name);

            Console.WriteLine("How old are you");
            string age = Console.ReadLine();

            
            Console.WriteLine(age + "it´s great");




        }
    }
}
