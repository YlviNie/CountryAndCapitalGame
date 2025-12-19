namespace CountryGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            SelectGameMode();
        }

        void DisplayMenu()
        {
            Console.WriteLine("Game options:");
            Console.WriteLine("1. Country to capital");
            Console.WriteLine("2. Capital to country");
            Console.WriteLine("3. Exit");
        }

        void DisplayContinents()
        {
            Console.WriteLine("Select a continent (or world):");
            int count = 1;

            Console.WriteLine($"{count}. World");
            count++;

            foreach (Continent continent in Enum.GetValues(typeof(Continent)))
            {
                Console.WriteLine($"{count}. {continent}");
                count++;
            }
        }

        void SelectGameMode()
        {
            DisplayMenu();
            Console.WriteLine();

            // Get user input for menu selection until valid input is received
            int gameOption = 0;
            int continentOption = 0;
            bool validMenuInput = false;
            bool validContinentInput = false;

            while (!validMenuInput)
            {
                try
                {
                    Console.Write("Enter number to select an option: ");
                    gameOption = int.Parse(Console.ReadLine());
                    if (gameOption >= 1 && gameOption <= 3)
                    {
                        validMenuInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number corresponding to the menu options.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                switch (gameOption)
                {
                    case 1:
                        Console.WriteLine("You selected 'Country to capital'.");
                        break;
                    case 2:
                        Console.WriteLine("You selected 'Capital to country'.");
                        break;
                    case 3:
                        Console.WriteLine("Exiting the game. Goodbye!");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please select a valid number from the menu.");
                        Console.WriteLine();
                        Console.ResetColor();
                        break;
                }
            }

            Console.WriteLine();

            while (!validContinentInput)
            {
                
                try
                {
                    DisplayContinents();
                    Console.WriteLine();
                    Console.Write("Enter number to select a continent: ");
                    continentOption = int.Parse(Console.ReadLine());
                    validContinentInput = true;

                    switch (continentOption)
                    {
                        case 1:
                            Console.WriteLine("You selected 'World'.");
                            break;
                        case 2:
                            Console.WriteLine("You selected 'Europe'.");
                            break;
                        case 3:
                            Console.WriteLine("You selected 'Asia'.");
                            break;
                        case 4:
                            Console.WriteLine("You selected 'Africa'.");
                            break;
                        case 5:
                            Console.WriteLine("You selected 'South America'.");
                            break;
                        case 6:
                            Console.WriteLine("You selected 'North America'.");
                            break;
                        case 7:
                            Console.WriteLine("You selected 'Oceania'.");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option. Please select a valid number from the continent options.");
                            Console.WriteLine();
                            validContinentInput = false;
                            Console.ResetColor();
                            break;
                    }
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number corresponding to the continent options.");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            Games game = new Games(gameOption, continentOption - 2);
            game.WhichGame();
        }
    }
}
