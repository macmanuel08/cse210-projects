using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        int lastDigit = grade % 10;

        string letterGrade = "";

        if (grade >= 90)
        {
            if (lastDigit < 3)
            {
                letterGrade = "A-";
            }
            else
            {
                letterGrade = "A";
            }
        }
        else if (grade >= 80)
        {
            if (lastDigit >= 7)
            {
                letterGrade = "B+";
            }
            else if (lastDigit < 3)
            {
                letterGrade = "B-";
            }
            else
            {
                letterGrade = "B";
            }
        }
        else if (grade >= 70)
        {
            if (lastDigit >= 7)
            {
                letterGrade = "C+";
            }
            else if (lastDigit < 3)
            {
                letterGrade = "C-";
            }
            else
            {
                letterGrade = "C";
            }
        }
        else if (grade >= 60)
        {
            if (lastDigit >= 7)
            {
                letterGrade = "D+";
            }
            else if (lastDigit < 3)
            {
                letterGrade = "D-";
            }
            else
            {
                letterGrade = "D";
            }
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't passed the class. Study harder next time.");
        }
    }
}