using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            numbers.Add(input);
            number = input;
        }
        while (number != 0);

        int sum = 0;
        int numbersCount = numbers.Count;
        int largestNumber = 0;
        for (int i = 0; i < numbersCount; i++)
        {
            sum += numbers[i];
            if (largestNumber < numbers[i]) 
            {
                largestNumber = numbers[i];
            }
        }

        double average = (double)sum / (numbersCount - 1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}