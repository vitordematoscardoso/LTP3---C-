using System;

namespace yourAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date birth:");
            int dateBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the current year:");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            int yourAge = dateBirth - currentYear;
            Console.WriteLine("Your age is:" +yourAge+);
        }
    }
}
