using System;

namespace Username
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Your full name is:" +name+" "+surname+);
        }
    }
}