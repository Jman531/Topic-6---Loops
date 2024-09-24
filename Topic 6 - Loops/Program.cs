using Topic_5._5___More_Classes;

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
                    Console.Clear();

                    Console.WriteLine("Loading program...");

                    Thread.Sleep(500);

                    Console.Clear();

                    SimpleBankingMachine();
                }
                else if (programChoice == "3" || programChoice.ToLower() == "doubles roller")
                {
                    Console.Clear();

                    Console.WriteLine("Loading program...");

                    Thread.Sleep(500);

                    Console.Clear();

                    DoublesRoller();
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

        static void SimpleBankingMachine()
        {
            string userChoice;
            double depositAmount = 0, accountBalance = 150, withdrawlAmount = 0, cash = 0, bills = 100, billPayAmount = 0;
            bool done = false;

            Console.WriteLine("Welcome to the BoB (Bank of Blorb) ATM, you will be charged a fee of $0.75 everytime you do a transaction, checking your account balance also charges you the fee...");

            Console.WriteLine();

            while (!done)
            {
                Console.WriteLine("What do you want to do: (You have " + cash.ToString("C") + " of Blobian cash on you)");

                Console.WriteLine();

                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawl");
                Console.WriteLine("3. Bill payment");
                Console.WriteLine("4. Account balance update");
                Console.WriteLine("5. Quit");
                userChoice = Console.ReadLine();

                Console.WriteLine();
                if (accountBalance < 0.75)
                {
                    Console.WriteLine("You don't have enough money in your account to do any of these actions!");

                    if (cash > 0.75)
                    {
                        Console.WriteLine();

                        Console.WriteLine("You do have enough cash though... So we'll just take away from that instead!");

                        cash -= 0.75;
                        accountBalance += 0.75;
                    }
                }
                else
                {
                    if (userChoice == "1" || userChoice.ToLower() == "deposit")
                    {
                        accountBalance -= 0.75;
                        Console.WriteLine("How much money do you want to deposit:");
                        while (!Double.TryParse(Console.ReadLine(), out depositAmount))
                            Console.WriteLine("Invalid input, try again");

                        Console.WriteLine();

                        if (depositAmount <= 0)
                        {
                            Console.WriteLine("Transaction failed, you can't deposit a zero or negative amount...");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else if (depositAmount > cash)
                        {
                            Console.WriteLine("Transaction failed, you can't deposit more than the amount of cash on you...");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have " + accountBalance.ToString("C") + " in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Starting deposit...");

                            Console.WriteLine();

                            Thread.Sleep(500);

                            accountBalance += depositAmount;
                            cash -= depositAmount;

                            Console.WriteLine("Deposit completed!");

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                    }
                    else if (userChoice == "2" || userChoice.ToLower() == "withdrawl")
                    {
                        accountBalance -= 0.75;
                        Console.WriteLine("How much do you want to withdrawl:");
                        while (!Double.TryParse(Console.ReadLine(), out withdrawlAmount))
                            Console.WriteLine("Invalid input, try again...");

                        Console.WriteLine();

                        if (withdrawlAmount <= 0)
                        {
                            Console.WriteLine("Transaction failed, you can't withdrawl a zero or negative amount...");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else if (withdrawlAmount > accountBalance)
                        {
                            Console.WriteLine("Transaction failed, you can't withdrawl more money than you have in your account...");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Starting withdrawl...");

                            Console.WriteLine();

                            Thread.Sleep(500);

                            accountBalance -= withdrawlAmount;
                            cash += withdrawlAmount;

                            Console.WriteLine("Withdrawl completed!");

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                    }
                    else if (userChoice == "3" || userChoice.ToLower() == "bill payment")
                    {
                        accountBalance -= 0.75;
                        Console.WriteLine("The total cost of your bills is " + bills.ToString("C") + "... How much of it do you want to pay off?");
                        while (!Double.TryParse(Console.ReadLine(), out billPayAmount))
                            Console.WriteLine("Invalid input, try again...");

                        Console.WriteLine();

                        if (billPayAmount <= 0)
                        {
                            Console.WriteLine("Transaction failed, you can't pay a zero or negative amount...");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else if (billPayAmount > bills)
                        {
                            Console.WriteLine("Transaction failed, you can't pay more than the cost your bills");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else if (billPayAmount > accountBalance)
                        {
                            Console.WriteLine("Transaction failed, you can't pay more money than you have in your account...");

                            Console.WriteLine();

                            Console.WriteLine("You wont be charged and we'll show your account balance update!");
                            accountBalance += 0.75;

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Starting bill payment...");

                            Console.WriteLine();

                            Thread.Sleep(500);

                            accountBalance -= billPayAmount;
                            bills -= billPayAmount;

                            Console.WriteLine("Bill payment completed!");

                            Console.WriteLine();

                            Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                            Console.Write("Press ENTER to continue...");
                            Console.ReadLine();
                        }
                    }
                    else if (userChoice == "4" || userChoice.ToLower() == "account balance update")
                    {
                        accountBalance -= 0.75;
                        Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                        Console.Write("Press ENTER to continue...");
                        Console.ReadLine();
                    }
                    else if (userChoice == "5" || userChoice.ToLower() == "quit")
                    {
                        Console.WriteLine("Okay, quitting the program!");
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not one of the options... We'll just give you the accound balance update instead!");

                        Console.WriteLine();

                        Console.WriteLine("You currently have a balance of " + accountBalance.ToString("C") + " Blorbian Dollars in your BoB account!");
                        Console.Write("Press ENTER to continue...");
                        Console.ReadLine();
                    }
                }

                Console.WriteLine();
            }
        }

        static void DoublesRoller()
        {
            Die die1 = new Die();
            Die die2 = new Die();

            int rollAmount = 0;

            Console.WriteLine("It's time to start rolling dice until you get doubles! Press ENTER to begin.");
            Console.ReadLine();

            Console.WriteLine();

            rollAmount += 1;

            Console.WriteLine($"Dice 1 rolled a {die1}");

            die1.DrawRoll();

            Console.WriteLine();

            Console.WriteLine($"Dice 2 rolled a {die2}");

            die2.DrawRoll();

            Console.WriteLine();

            while (die1.ToString() != die2.ToString())
            {
                Console.WriteLine("Not a double! Let's roll the dice again! Press ENTER to roll the dice");
                Console.ReadLine();

                die1.RollDie();
                die2.RollDie();

                Console.WriteLine();

                rollAmount += 1;

                Console.WriteLine($"Dice 1 rolled a {die1}");

                die1.DrawRoll();

                Console.WriteLine();

                Console.WriteLine($"Dice 2 rolled a {die2}");

                die2.DrawRoll();

                Console.WriteLine();
            }
            Console.WriteLine($"You managed to roll a double in only {rollAmount} rolls! Press ENTER to exit");
            Console.ReadLine();

            Console.Clear();
        }
    }
}
