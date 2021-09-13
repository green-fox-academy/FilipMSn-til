using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI");
            double masskgt = 81.2;
            double heightm = 1.78;
            double heightexp = heightm * heightm;
            double BMI = masskgt / heightexp;

            Console.WriteLine(BMI ) ;

        }
    }
}
