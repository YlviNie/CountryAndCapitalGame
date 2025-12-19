using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CountryGame1
{
    internal class Country
    {
        public string CapitalName { get; set; }
        public string CountryName { get; set; }
        public Continent Continent { get; set; }

        public Country(string capital, string country, string continent)
        {
            CapitalName = capital;
            CountryName = country;
            Continent = Enum.Parse<Continent>(continent);
        }
    }
}
