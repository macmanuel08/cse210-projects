using System;

public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine("");
    Console.WriteLine($"{_description}.");
    Console.WriteLine("");
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.Clear();
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("");
    Console.WriteLine("Well done!!");
    ShowSpinner(4);
    Console.WriteLine("");
    Console.WriteLine($"You have completed another {_duration} seconds of {_name}.");
    ShowSpinner(4);
  }

  public void ShowSpinner(int seconds)
  {
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;
    while (DateTime.Now < endTime)
    {
      string s = animationStrings[i];
      Console.Write(s);
      Thread.Sleep(1000);
      Console.Write("\b \b");
      i++;

      if (i >= animationStrings.Count)
      {
        i = 0;
      }
    }
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }

  public int GetDuration()
  {
    return _duration;
  }

}