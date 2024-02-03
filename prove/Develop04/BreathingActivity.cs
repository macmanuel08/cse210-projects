using System;

public class BreathingActivity : Activity
{
  public BreathingActivity(string name, string description) : base(name, description)
  {
    return;
  }

  public void Run()
  {
    DisplayStartingMessage();
    int duration = GetDuration();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    Console.WriteLine("Get Ready...");
    ShowSpinner(4);

    while (DateTime.Now < endTime)
    {
      Console.WriteLine("");
      Console.Write("Breathe in...");
      ShowCountDown(5);
      Console.WriteLine("");
      Console.Write("Breathe out...");
      ShowCountDown(5);
      Console.WriteLine("");
    }
    DisplayEndingMessage();
  }
}