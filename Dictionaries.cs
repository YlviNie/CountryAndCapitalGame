using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryGame1
{
    internal class Dictionaries
    {

        Dictionary<string, Country> worldCountries = new Dictionary<string, Country>()
        {
            // --- EUROPE ---
            {"Tirana", new Country("Tirana", "Albania", "Europe")},
            {"Andorra la Vella", new Country("Andorra la Vella", "Andorra", "Europe")},
            {"Yerevan", new Country("Yerevan", "Armenia", "Europe")},
            {"Vienna", new Country("Vienna", "Austria", "Europe")},
            {"Baku", new Country("Baku", "Azerbaijan", "Europe")},
            {"Minsk", new Country("Minsk", "Belarus", "Europe")},
            {"Brussels", new Country("Brussels", "Belgium", "Europe")},
            {"Sarajevo", new Country("Sarajevo", "Bosnia and Herzegovina", "Europe")},
            {"Sofia", new Country("Sofia", "Bulgaria", "Europe")},
            {"Zagreb", new Country("Zagreb", "Croatia", "Europe")},
            {"Nicosia", new Country("Nicosia", "Cyprus", "Europe")},
            {"Prague", new Country("Prague", "Czech Republic", "Europe")},
            {"Copenhagen", new Country("Copenhagen", "Denmark", "Europe")},
            {"Tallinn", new Country("Tallinn", "Estonia", "Europe")},
            {"Helsinki", new Country("Helsinki", "Finland", "Europe")},
            {"Paris", new Country("Paris", "France", "Europe")},
            {"Tbilisi", new Country("Tbilisi", "Georgia", "Europe")},
            {"Berlin", new Country("Berlin", "Germany", "Europe")},
            {"Athens", new Country("Athens", "Greece", "Europe")},
            {"Budapest", new Country("Budapest", "Hungary", "Europe")},
            {"Reykjavik", new Country("Reykjavik", "Iceland", "Europe")},
            {"Dublin", new Country("Dublin", "Ireland", "Europe")},
            {"Rome", new Country("Rome", "Italy", "Europe")},
            {"Astana", new Country("Astana", "Kazakhstan", "Europe")},
            {"Pristina", new Country("Pristina", "Kosovo", "Europe")},
            {"Riga", new Country("Riga", "Latvia", "Europe")},
            {"Vaduz", new Country("Vaduz", "Liechtenstein", "Europe")},
            {"Vilnius", new Country("Vilnius", "Lithuania", "Europe")},
            {"Luxembourg City", new Country("Luxembourg City", "Luxembourg", "Europe")},
            {"Valletta", new Country("Valletta", "Malta", "Europe")},
            {"Chisinau", new Country("Chisinau", "Moldova", "Europe")},
            {"Monaco", new Country("Monaco", "Monaco", "Europe")},
            {"Podgorica", new Country("Podgorica", "Montenegro", "Europe")},
            {"Amsterdam", new Country("Amsterdam", "Netherlands", "Europe")},
            {"Skopje", new Country("Skopje", "North Macedonia", "Europe")},
            {"Oslo", new Country("Oslo", "Norway", "Europe")},
            {"Warsaw", new Country("Warsaw", "Poland", "Europe")},
            {"Lisbon", new Country("Lisbon", "Portugal", "Europe")},
            {"Bucharest", new Country("Bucharest", "Romania", "Europe")},
            {"Moscow", new Country("Moscow", "Russia", "Europe")},
            {"San Marino", new Country("San Marino", "San Marino", "Europe")},
            {"Belgrade", new Country("Belgrade", "Serbia", "Europe")},
            {"Bratislava", new Country("Bratislava", "Slovakia", "Europe")},
            {"Ljubljana", new Country("Ljubljana", "Slovenia", "Europe")},
            {"Madrid", new Country("Madrid", "Spain", "Europe")},
            {"Stockholm", new Country("Stockholm", "Sweden", "Europe")},
            {"Bern", new Country("Bern", "Switzerland", "Europe")},
            {"Ankara", new Country("Ankara", "Turkey", "Europe")},
            {"Kyiv", new Country("Kyiv", "Ukraine", "Europe")},
            {"London", new Country("London", "United Kingdom", "Europe")},
            {"Vatican City", new Country("Vatican City", "Vatican City", "Europe")},

            // --- ASIA ---
            {"Kabul", new Country("Kabul", "Afghanistan", "Asia")},
            {"Manama", new Country("Manama", "Bahrain", "Asia")},
            {"Dhaka", new Country("Dhaka", "Bangladesh", "Asia")},
            {"Thimphu", new Country("Thimphu", "Bhutan", "Asia")},
            {"Bandar Seri Begawan", new Country("Bandar Seri Begawan", "Brunei", "Asia")},
            {"Phnom Penh", new Country("Phnom Penh", "Cambodia", "Asia")},
            {"Beijing", new Country("Beijing", "China", "Asia")},
            {"Dili", new Country("Dili", "East Timor", "Asia")},
            {"New Delhi", new Country("New Delhi", "India", "Asia")},
            {"Jakarta", new Country("Jakarta", "Indonesia", "Asia")},
            {"Tehran", new Country("Tehran", "Iran", "Asia")},
            {"Baghdad", new Country("Baghdad", "Iraq", "Asia")},
            {"Jerusalem", new Country("Jerusalem", "Israel", "Asia")},
            {"Tokyo", new Country("Tokyo", "Japan", "Asia")},
            {"Amman", new Country("Amman", "Jordan", "Asia")},
            {"Kuwait City", new Country("Kuwait City", "Kuwait", "Asia")},
            {"Bishkek", new Country("Bishkek", "Kyrgyzstan", "Asia")},
            {"Vientiane", new Country("Vientiane", "Laos", "Asia")},
            {"Beirut", new Country("Beirut", "Lebanon", "Asia")},
            {"Kuala Lumpur", new Country("Kuala Lumpur", "Malaysia", "Asia")},
            {"Malé", new Country("Malé", "Maldives", "Asia")},
            {"Ulaanbaatar", new Country("Ulaanbaatar", "Mongolia", "Asia")},
            {"Naypyidaw", new Country("Naypyidaw", "Myanmar", "Asia")},
            {"Kathmandu", new Country("Kathmandu", "Nepal", "Asia")},
            {"Pyongyang", new Country("Pyongyang", "North Korea", "Asia")},
            {"Muscat", new Country("Muscat", "Oman", "Asia")},
            {"Islamabad", new Country("Islamabad", "Pakistan", "Asia")},
            {"Manila", new Country("Manila", "Philippines", "Asia")},
            {"Doha", new Country("Doha", "Qatar", "Asia")},
            {"Riyadh", new Country("Riyadh", "Saudi Arabia", "Asia")},
            {"Singapore", new Country("Singapore", "Singapore", "Asia")},
            {"Seoul", new Country("Seoul", "South Korea", "Asia")},
            {"Sri Jayawardenepura Kotte", new Country("Sri Jayawardenepura Kotte", "Sri Lanka", "Asia")},
            {"Damascus", new Country("Damascus", "Syria", "Asia")},
            {"Taipei", new Country("Taipei", "Taiwan", "Asia")},
            {"Dushanbe", new Country("Dushanbe", "Tajikistan", "Asia")},
            {"Bangkok", new Country("Bangkok", "Thailand", "Asia")},
            {"Ashgabat", new Country("Ashgabat", "Turkmenistan", "Asia")},
            {"Abu Dhabi", new Country("Abu Dhabi", "United Arab Emirates", "Asia")},
            {"Tashkent", new Country("Tashkent", "Uzbekistan", "Asia")},
            {"Hanoi", new Country("Hanoi", "Vietnam", "Asia")},
            {"Sanaa", new Country("Sanaa", "Yemen", "Asia")},

            // --- AFRICA ---
            {"Algiers", new Country("Algiers", "Algeria", "Africa")},
            {"Luanda", new Country("Luanda", "Angola", "Africa")},
            {"Porto-Novo", new Country("Porto-Novo", "Benin", "Africa")},
            {"Gaborone", new Country("Gaborone", "Botswana", "Africa")},
            {"Ouagadougou", new Country("Ouagadougou", "Burkina Faso", "Africa")},
            {"Gitega", new Country("Gitega", "Burundi", "Africa")},
            {"Yaoundé", new Country("Yaoundé", "Cameroon", "Africa")},
            {"Praia", new Country("Praia", "Cape Verde", "Africa")},
            {"Bangui", new Country("Bangui", "Central African Republic", "Africa")},
            {"N'Djamena", new Country("N'Djamena", "Chad", "Africa")},
            {"Moroni", new Country("Moroni", "Comoros", "Africa")},
            {"Kinshasa", new Country("Kinshasa", "DR Congo", "Africa")},
            {"Brazzaville", new Country("Brazzaville", "Republic of the Congo", "Africa")},
            {"Djibouti City", new Country("Djibouti City", "Djibouti", "Africa")},
            {"Cairo", new Country("Cairo", "Egypt", "Africa")},
            {"Malabo", new Country("Malabo", "Equatorial Guinea", "Africa")},
            {"Asmara", new Country("Asmara", "Eritrea", "Africa")},
            {"Mbabane", new Country("Mbabane", "Eswatini", "Africa")},
            {"Addis Ababa", new Country("Addis Ababa", "Ethiopia", "Africa")},
            {"Libreville", new Country("Libreville", "Gabon", "Africa")},
            {"Banjul", new Country("Banjul", "Gambia", "Africa")},
            {"Accra", new Country("Accra", "Ghana", "Africa")},
            {"Conakry", new Country("Conakry", "Guinea", "Africa")},
            {"Bissau", new Country("Bissau", "Guinea-Bissau", "Africa")},
            {"Yamoussoukro", new Country("Yamoussoukro", "Ivory Coast", "Africa")},
            {"Nairobi", new Country("Nairobi", "Kenya", "Africa")},
            {"Maseru", new Country("Maseru", "Lesotho", "Africa")},
            {"Monrovia", new Country("Monrovia", "Liberia", "Africa")},
            {"Tripoli", new Country("Tripoli", "Libya", "Africa")},
            {"Antananarivo", new Country("Antananarivo", "Madagascar", "Africa")},
            {"Lilongwe", new Country("Lilongwe", "Malawi", "Africa")},
            {"Bamako", new Country("Bamako", "Mali", "Africa")},
            {"Nouakchott", new Country("Nouakchott", "Mauritania", "Africa")},
            {"Port Louis", new Country("Port Louis", "Mauritius", "Africa")},
            {"Rabat", new Country("Rabat", "Morocco", "Africa")},
            {"Maputo", new Country("Maputo", "Mozambique", "Africa")},
            {"Windhoek", new Country("Windhoek", "Namibia", "Africa")},
            {"Niamey", new Country("Niamey", "Niger", "Africa")},
            {"Abuja", new Country("Abuja", "Nigeria", "Africa")},
            {"Kigali", new Country("Kigali", "Rwanda", "Africa")},
            {"São Tomé", new Country("São Tomé", "Sao Tome and Principe", "Africa")},
            {"Dakar", new Country("Dakar", "Senegal", "Africa")},
            {"Victoria", new Country("Victoria", "Seychelles", "Africa")},
            {"Freetown", new Country("Freetown", "Sierra Leone", "Africa")},
            {"Mogadishu", new Country("Mogadishu", "Somalia", "Africa")},
            {"Pretoria", new Country("Pretoria", "South Africa", "Africa")},
            {"Juba", new Country("Juba", "South Sudan", "Africa")},
            {"Khartoum", new Country("Khartoum", "Sudan", "Africa")},
            {"Dodoma", new Country("Dodoma", "Tanzania", "Africa")},
            {"Lomé", new Country("Lomé", "Togo", "Africa")},
            {"Tunis", new Country("Tunis", "Tunisia", "Africa")},
            {"Kampala", new Country("Kampala", "Uganda", "Africa")},
            {"Lusaka", new Country("Lusaka", "Zambia", "Africa")},
            {"Harare", new Country("Harare", "Zimbabwe", "Africa")},

            // --- SOUTH AMERICA ---
            {"Buenos Aires", new Country("Buenos Aires", "Argentina", "SouthAmerica")},
            {"Sucre", new Country("Sucre", "Bolivia", "SouthAmerica")},
            {"Brasília", new Country("Brasília", "Brazil", "SouthAmerica")},
            {"Santiago", new Country("Santiago", "Chile", "SouthAmerica")},
            {"Bogotá", new Country("Bogotá", "Colombia", "SouthAmerica")},
            {"Quito", new Country("Quito", "Ecuador", "SouthAmerica")},
            {"Georgetown", new Country("Georgetown", "Guyana", "SouthAmerica")},
            {"Asunción", new Country("Asunción", "Paraguay", "SouthAmerica")},
            {"Lima", new Country("Lima", "Peru", "SouthAmerica")},
            {"Paramaribo", new Country("Paramaribo", "Suriname", "SouthAmerica")},
            {"Montevideo", new Country("Montevideo", "Uruguay", "SouthAmerica")},
            {"Caracas", new Country("Caracas", "Venezuela", "SouthAmerica")},

            // --- NORTH AMERICA ---
            {"Saint John's", new Country("Saint John's", "Antigua and Barbuda", "NorthAmerica")},
            {"Nassau", new Country("Nassau", "Bahamas", "NorthAmerica")},
            {"Bridgetown", new Country("Bridgetown", "Barbados", "NorthAmerica")},
            {"Belmopan", new Country("Belmopan", "Belize", "NorthAmerica")},
            {"Ottawa", new Country("Ottawa", "Canada", "NorthAmerica")},
            {"San José", new Country("San José", "Costa Rica", "NorthAmerica")},
            {"Havana", new Country("Havana", "Cuba", "NorthAmerica")},
            {"Roseau", new Country("Roseau", "Dominica", "NorthAmerica")},
            {"Santo Domingo", new Country("Santo Domingo", "Dominican Republic", "NorthAmerica")},
            {"San Salvador", new Country("San Salvador", "El Salvador", "NorthAmerica")},
            {"St. George's", new Country("St. George's", "Grenada", "NorthAmerica")},
            {"Guatemala City", new Country("Guatemala City", "Guatemala", "NorthAmerica")},
            {"Port-au-Prince", new Country("Port-au-Prince", "Haiti", "NorthAmerica")},
            {"Tegucigalpa", new Country("Tegucigalpa", "Honduras", "NorthAmerica")},
            {"Kingston", new Country("Kingston", "Jamaica", "NorthAmerica")},
            {"Mexico City", new Country("Mexico City", "Mexico", "NorthAmerica")},
            {"Managua", new Country("Managua", "Nicaragua", "NorthAmerica")},
            {"Panama City", new Country("Panama City", "Panama", "NorthAmerica")},
            {"Basseterre", new Country("Basseterre", "Saint Kitts and Nevis", "NorthAmerica")},
            {"Castries", new Country("Castries", "Saint Lucia", "NorthAmerica")},
            {"Kingstown", new Country("Kingstown", "Saint Vincent and the Grenadines", "NorthAmerica")},
            {"Port of Spain", new Country("Port of Spain", "Trinidad and Tobago", "NorthAmerica")},
            {"Washington, D.C.", new Country("Washington, D.C.", "United States", "NorthAmerica")},

            // --- OCEANIA ---
            {"Canberra", new Country("Canberra", "Australia", "Oceania")},
            {"South Tarawa", new Country("South Tarawa", "Kiribati", "Oceania")},
            {"Majuro", new Country("Majuro", "Marshall Islands", "Oceania")},
            {"Palikir", new Country("Palikir", "Micronesia", "Oceania")},
            {"Yaren", new Country("Yaren", "Nauru", "Oceania")},
            {"Wellington", new Country("Wellington", "New Zealand", "Oceania")},
            {"Ngerulmud", new Country("Ngerulmud", "Palau", "Oceania")},
            {"Port Moresby", new Country("Port Moresby", "Papua New Guinea", "Oceania")},
            {"Apia", new Country("Apia", "Samoa", "Oceania")},
            {"Honiara", new Country("Honiara", "Solomon Islands", "Oceania")},
            {"Nuku'alofa", new Country("Nuku'alofa", "Tonga", "Oceania")},
            {"Funafuti", new Country("Funafuti", "Tuvalu", "Oceania")},
            {"Port Vila", new Country("Port Vila", "Vanuatu", "Oceania")},
            {"Suva", new Country("Suva", "Fiji", "Oceania")}
        };

        public Dictionary<string, Country> FilterByContinent(int continentChoice)
        {
            if (continentChoice == -1)
            {
                return worldCountries;
            }

            // Creates a new dictionary to hold the countries belonging to the selected continent
            Dictionary<string , Country> selectedCountries = new Dictionary<string, Country>();

            // Makes continent enum from user choice
            Continent continent = (Continent)continentChoice;

            // Loops through the worldCountries dictionary and adds countries to the selectedCountries dictionary if they belong to the selected continent
            foreach (var country in worldCountries)
            {
                if (country.Value.Continent == continent)
                {
                    selectedCountries.Add(country.Key, country.Value);
                }
            }
            // Returns the filtered dictionary (or the whole world dictionary if continentChoice is 0)
            return selectedCountries;
        }
    }
}
