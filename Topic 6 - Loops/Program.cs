namespace Topic_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programChoice;
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Please pick a program to play:");

                Console.WriteLine();

                Console.WriteLine("1. Number Prompter");
                Console.WriteLine("2. Simple Banking Machine");
                Console.WriteLine("3. Doubles Roller");
                Console.WriteLine("4. Quit");
                programChoice = Console.ReadLine();

                Console.WriteLine();

                if (programChoice == "1" || programChoice.ToLower() == "number prompter")
                {
                    Console.Clear();

                    Console.WriteLine("Loading program...");

                    Thread.Sleep(500);

                    Console.Clear();

                    NumberPrompter();
                }
                else if (programChoice == "2" || programChoice.ToLower() == "simple banking machine")
                {

                }
                else if (programChoice == "3" || programChoice.ToLower() == "doubles roller")
                {

                }
                else if (programChoice == "4" || programChoice.ToLower() == "quit")
                {
                    done = true;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("That's not an option... Please enter a valid option.");

                    Thread.Sleep(1000);

                    Console.Clear();
                }
            }
        }

        static void NumberPrompter()
        {
            string programEnd;
            int minVal, maxVal, userNum;
            bool quitDone, done = false;

            while (!done)
            {
                quitDone = false;

                Console.WriteLine("Give me a minimum value:");
                while (!Int32.TryParse(Console.ReadLine(), out minVal))
                {
                    Console.WriteLine("Invalid input, please try again...");
                }

                Console.WriteLine("Give me a maxiumum value:");
                while (!Int32.TryParse(Console.ReadLine(), out maxVal))
                    Console.WriteLine("Invalid integer, please try again...");

                while (maxVal < minVal)
                {
                    Console.WriteLine("That's more than the minimum value, please enter a valid maximum:");
                    while (!Int32.TryParse(Console.ReadLine(), out maxVal))
                        Console.WriteLine("Invalid integer, please try again...");
                }

                Console.WriteLine();

                Console.WriteLine($"Pick an integer between {minVal} and {maxVal}:");
                while (!Int32.TryParse(Console.ReadLine(), out userNum))
                    Console.WriteLine("Invalid integer, try again...");

                while (userNum < minVal || userNum > maxVal)
                {
                    Console.WriteLine("The integer can't be smaller than the minimum and it can't be bigger than the maximum, please enter a valid integer");
                    while (!Int32.TryParse(Console.ReadLine(), out userNum))
                        Console.WriteLine("Invalid integer, try again...");
                }

                Console.WriteLine();

                Console.WriteLine($"The number you picked between {minVal} and {maxVal} is {userNum}!");

                Console.WriteLine();

                Console.WriteLine("Do you want to:");

                Console.WriteLine();

                while (!quitDone)
                {
                    Console.WriteLine("1. Play again");
                    Console.WriteLine("2. Quit");
                    programEnd = Console.ReadLine();

                    Console.WriteLine();

                    if (programEnd == "1" || programEnd.ToLower() == "play again")
                    {
                        Console.WriteLine("Okay, playing the program again...");

                        Thread.Sleep(500);

                        Console.Clear();

                        quitDone = true;
                    }
                    else if (programEnd == "2" || programEnd.ToLower() == "quit")
                    {
                        Console.WriteLine("Okay, quitting program...");

                        Thread.Sleep(500);

                        Console.Clear();

                        quitDone = true;
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("That's not an option...");
                    }
                }
            }
        }
    }
}
