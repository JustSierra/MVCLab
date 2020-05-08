using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;

        }


        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);

            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }


        }
    }
}
