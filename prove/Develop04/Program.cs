// I added a log of how many times an acitvity performed by the user in each session.
// The log will show each end of the activity.

using System;

class Program
{
    static void Main(string[] args)
    {
        string option;
        Activity activity = new Activity("Activity", "For logging");
        BreathingActivity breathe = new BreathingActivity("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
        ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of life");
        ListingActivity list = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
        int breathingActivityLog = 0;
        int reflectingActivityLog = 0;
        int listingActivityLog = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a chioce from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                breathe.Run();
                breathingActivityLog++;
                Console.WriteLine($"You have performed Breathing Activity for {breathingActivityLog} times.");
                activity.ShowSpinner(5);
            }
            else if (option == "2")
            {
                reflect.Run();
                reflectingActivityLog++;
                Console.WriteLine($"You have performed Reflecting Activity for {reflectingActivityLog} times.");
                activity.ShowSpinner(5);
            }
            else if (option == "3")
            {
                list.Run();
                listingActivityLog++;
                Console.WriteLine($"You have performed Listing Activity for {listingActivityLog} times.");
                activity.ShowSpinner(5);
            }

        } while (option != "4");
    }
}