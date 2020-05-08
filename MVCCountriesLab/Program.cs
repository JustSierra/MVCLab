using System;
using System.Runtime.CompilerServices;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();

            string input = "y";
            while (input == "y")
            {
                cc.WelcomeAction();


                Console.WriteLine("Would you like to continue? Y or yes");
                input = Console.ReadLine();

            }

        }
    }
}
