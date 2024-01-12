using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string guessNumberString = Console.ReadLine();
        int guessNumber = int.Parse(guessNumberString);
        int attemps = 1;

        while (magicNumber != guessNumber)
        {
            if (magicNumber < guessNumber) 
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is the magic number? ");
            guessNumberString = Console.ReadLine();
            guessNumber = int.Parse(guessNumberString);
            attemps++;
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Your number of attemp(s) is {attemps}");
    }
}