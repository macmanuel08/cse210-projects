using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("345 Narra Dr.", "West Spring", "Colorado", "USA");
        Lecture lecture1 = new Lecture("Lecture", "Programming with Classes: Inheritance", "This is a lecture about inheritance in programming with classes using C# language.", "Feb 21, 2024", "5PM", lectureAddress, "Jon Smith", 20);
        Console.WriteLine("Lecture Standard Details");
        lecture1.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Lecture Short Description");
        lecture1.GetShortDescription();
        Console.WriteLine();
        Console.WriteLine("Lecture Full Details");
        lecture1.GetFullDetails();

        Console.WriteLine();
        Address receptionAddress = new Address("Main St","Los Angeles","Califonia","USA");
        Reception reception1 = new Reception("Reception", "Wedding Reception", "This is a reception for the wedding of Kevin and Lovely.", "May 14, 2024", "3PM", receptionAddress, "example1@email.com");
        Console.WriteLine("Reception Standard Details");
        reception1.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Reception Short Description");
        reception1.GetShortDescription();
        Console.WriteLine();
        Console.WriteLine("Reception Full Details");
        reception1.GetFullDetails();

        Console.WriteLine();
        Address outdoorGatheringAddress = new Address("Chestnut St","Lahug","Cebu","Philippines");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Outdoor Gathering", "Butuan Mission RM Reunion", "This is reunion for missionaries served in the Butuan Philippines mission in year 2016-2018.", "October 28, 2024", "5AM", outdoorGatheringAddress, "Sunny");
        Console.WriteLine("Outdoor Gathering Standard Details");
        outdoorGathering1.GetStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Short Description");
        outdoorGathering1.GetShortDescription();
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Full Details");
        outdoorGathering1.GetFullDetails();
    }
}