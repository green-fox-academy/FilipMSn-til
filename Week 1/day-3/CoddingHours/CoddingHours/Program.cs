using System;

namespace CoddingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double Hoursperday = 6;
            double semesterweek = 17;
            double day = (7);
            double result = Hoursperday * semesterweek * day;
            double workdays = (5);
            double hoursperweek = Hoursperday * semesterweek * workdays;
            double worktime = (52);
            double percentsem = ((Hoursperday * workdays) / worktime) * 100;
        


            Console.WriteLine(result);
            Console.WriteLine(hoursperweek);
            Console.WriteLine(percentsem);




        }
    }
}
