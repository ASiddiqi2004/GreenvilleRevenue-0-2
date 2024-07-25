using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****************************************");
        Console.WriteLine("*     The stars shine in Greenville.        *");
        Console.WriteLine("*****************************************");
        while (true)
        {
            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. Calculate Greenville Revenue year-over-year");
            Console.WriteLine("2. Exit");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                CalculateRevenue();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }

    static void CalculateRevenue()
    {
        Console.WriteLine("\nEnter the number of contestants in the previous year:");
        int previousYearContestants = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of contestants in the current year:");
        int currentYearContestants = Convert.ToInt32(Console.ReadLine());
        int ticketPrice = 25;
        int expectedRevenue = currentYearContestants * ticketPrice;
        Console.WriteLine($"\nLast year's competition had {previousYearContestants} contestants, and this year's has {currentYearContestants} contestants");
        Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");

        if (currentYearContestants > previousYearContestants * 2)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (currentYearContestants > previousYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        Console.WriteLine("\n*****************************************");
        Console.WriteLine("*     The stars shine in Greenville.        *");
        Console.WriteLine("********************************************");
        }
    }