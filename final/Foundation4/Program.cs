using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running running = new Running(30, "06 Oct 2024", 4.8);
        _activities.Add(running);

        Cycling cycling = new Cycling(38, "04 Sep 2024", 2.5);
        _activities.Add(cycling);

        Swimming swimming = new Swimming(20, "23 May 2024", 1.9, 6);
        _activities.Add(swimming);

        foreach (Activity activity in _activities)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }
    }
}