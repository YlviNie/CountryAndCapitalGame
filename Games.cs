using System;
using System.Collections.Generic;
using System.Linq;

namespace CountryGame1
{
    internal class Games
    {
        public int GameChoice { get; set; }
        // Fix from previous step: Remove "Continent" type here to access the property correctly
        public Continent ContinentChoice { get; set; }

        public Games(int gameChoice, int continentChoice)
        {
            GameChoice = gameChoice;
            // Fix from previous step: assigning to property
            ContinentChoice = (Continent)continentChoice;
        }

        public void WhichGame()
        {
            // We initialize the dictionary here once
            Dictionary<string, Country> countriesDict = InitializeDictionary();

            // Convert Dictionary Values to a List so we can modify the order dynamically
            List<Country> gamePlaylist = countriesDict.Values.ToList();

            if (GameChoice == 1)
            {
                CountryToCapital(gamePlaylist);
            }
            else if (GameChoice == 2)
            {
                CapitalToCountry(gamePlaylist);
            }
        }

        Dictionary<string, Country> InitializeDictionary()
        {
            Dictionaries dictionaries = new Dictionaries();
            // Cast enum to int for the filter method
            Dictionary<string, Country> countries = dictionaries.FilterByContinent((int)ContinentChoice);

            Random rand = new Random();
            countries = countries.OrderBy(x => rand.Next())
                .ToDictionary(item => item.Key, item => item.Value);

            return countries;
        }

        // Logic to re-insert wrong answers
        void RequeueCountry(List<Country> playlist, Country country, int currentIndex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   -> Don't worry, I'll ask this one again in 5 turns!");
            Console.ResetColor();

            // Calculate where to put it. 
            // We want it 5 steps ahead.
            // Math.Min ensures that if the list is short (e.g., only 2 items left), 
            // we don't crash by trying to insert at index 5. We just insert at the end.
            int newIndex = Math.Min(currentIndex + 5, playlist.Count);

            playlist.Insert(newIndex, country);
        }

        void CountryToCapital(List<Country> playlist)
        {
            string[] endorsements = PositiveEndorsements();

            // We use a while loop so we can keep going as the list grows (from wrong answers)
            int index = 0;
            while (index < playlist.Count)
            {
                var country = playlist[index];

                Console.WriteLine($"Question {index + 1}/{playlist.Count}");
                Console.Write($"What is the capital of {country.CountryName}? ");

                string userAnswer = Console.ReadLine();

                if (userAnswer.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (userAnswer.Trim().Equals(country.CapitalName, StringComparison.OrdinalIgnoreCase))
                {
                    Random rnd = new Random();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(endorsements[rnd.Next(endorsements.Length)]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong! The correct answer is {country.CapitalName}.");
                    Console.ResetColor();

                    // Calls the helper function to add it back to the list
                    RequeueCountry(playlist, country, index);
                }

                Console.WriteLine(); // Spacing
                index++; // Move to next question
            }

            if (index >= playlist.Count)
            {
                Console.WriteLine("Game Over! You've cleared the list.");
            }
            else
            {
                Console.WriteLine("You exited the game.");
            }

            PlayAgain();
        }

        void CapitalToCountry(List<Country> playlist)
        {
            string[] endorsements = PositiveEndorsements();

            int index = 0;
            while (index < playlist.Count)
            {
                var country = playlist[index];

                Console.WriteLine($"Question {index + 1}/{playlist.Count}");
                Console.Write($"What is the country for the capital {country.CapitalName}? ");

                string userAnswer = Console.ReadLine();

                if (userAnswer.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (userAnswer.Trim().Equals(country.CountryName, StringComparison.OrdinalIgnoreCase))
                {
                    Random rnd = new Random();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(endorsements[rnd.Next(endorsements.Length)]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong! The correct answer is {country.CountryName}.");
                    Console.ResetColor();

                    // Calls the helper function to add it back to the list
                    RequeueCountry(playlist, country, index);
                }

                Console.WriteLine();
                index++;
            }

            if (index >= playlist.Count)
            {
                Console.WriteLine("Game Over! You've cleared the list.");
            }
            else
            {
                Console.WriteLine("You exited the game.");
            }

            PlayAgain();
        }

        void PlayAgain()
        {
            Console.WriteLine();
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();
            if (response == "yes" || response == "y")
            {
                Console.Clear();
                Program program = new Program();
                program.Start();
            }
            else
            {
                Console.WriteLine("Thank you for playing! Goodbye!");
            }
        }

        string[] PositiveEndorsements()
        {
            return new string[]
            {
                "Well done!",
                "Great job!",
                "You're on fire!",
                "Keep it up!",
                "Fantastic!",
                "You're a star!",
                "Brilliant work!",
                "Excellent!",
                "Superb!",
                "You're amazing!",
                "It's honestly impressive that you're doing this so well!",
                "Girl, you are slaying this!",
                "You must have studied hard for this!",
                "You're crushing it!",
                "Legitimately unstoppable",
                "I can't believe how good you are at this!",
                "You should be proud of yourself!",
                "I mean look at you! Wow!",
                "You're making this look so easy!",
                "You're a natural!",
                "What else can I say? You're just so good",
                "I don't even have to help you, you're nailing it!",
                "GO GO GO!",
                "Slaying... as usual of course!",
                "Girl you are amazing!",
                "Gaslight, gatekeep, girlboss! Because you're girlbossing this quiz!",
                "Slay all day!",
                "Yaaas queen, you got this!"
            };
        }
    }
}