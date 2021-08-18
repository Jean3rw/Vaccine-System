using System;

namespace Vaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Register for Vaccine Enter Name");
            string UserName = Console.ReadLine();

            Console.WriteLine("Enter your ID");
            string ID = Console.ReadLine();

            Console.WriteLine("Have you ever been exposed or infected by COVID-19? Enter Yes OR No");
            string Vaccine = Console.ReadLine();

            Console.WriteLine("Enter Your Province");
            string Province = Console.ReadLine();

            Console.WriteLine("Enter your Gender");
            string Gender = Console.ReadLine();

            Console.WriteLine(UserName +" "+ ID + " " + Vaccine + " " + Province + " " + Gender);

        }
    }
}
