using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MVCCountriesLab
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>
            {
                new Country("USA", "North America", new List<string> {"Red", "White","Blue"}),
                new Country("Germany", "Europe", new List<string> {"Black", "Gold","Red" }),
                new Country("France", "Europe", new List<string> {"Red", "White","Black"}),
                new Country("India", "Asia", new List<string> {"Orange", "White","Green"}),
                new Country("China", "Asia", new List<string> {"Red", "Yellow", }),
                new Country("Nigeria", "Africa", new List<string> {"Green", "White",})

            }; 
         
        }


        public void CountryAction(Country country)
        {
            CountryView countryView = new CountryView(country);

            countryView.Display();

        }

        public void WelcomeAction()
        {
            CountryListView countryListView = new CountryListView(CountryDb);

            Console.WriteLine("Hi! Please select a country...");

            countryListView.Display();

            int userSelection = int.Parse(Console.ReadLine());

            Country country = CountryDb[userSelection];

            CountryAction(country);                           



        }

      
        
    }
}
