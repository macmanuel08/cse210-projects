using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
  private int _count = 0;
  private List<string> _prompts = new List<string>();

  public ListingActivity(string name, string description) : base(name, description)
  {
    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");
  }

  public void GetRandomPrompt()
  {
    Random randomGenerator = new Random();
    int randomInt = randomGenerator.Next(0, _prompts.Count - 1);
    Console.WriteLine($"--- {_prompts[randomInt]} ---");
  }

  public List<string> GetListFromUser()
  {
    DisplayStartingMessage();

    List<string> listFromUser = new List<string>();

    int seconds = GetDuration();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    Console.WriteLine("Get ready...");
    ShowSpinner(4);
    Console.WriteLine("");
    Console.WriteLine("List as many responses you can to the following prompt:");
    GetRandomPrompt();
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.WriteLine("");

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string userInput = Console.ReadLine();
      listFromUser.Add(userInput);
    }

    return listFromUser;
  }

  public void Run()
  {
    List<string> inputs = GetListFromUser();
    _count = inputs.Count();
    Console.WriteLine($"You listed {_count} items!");
    DisplayEndingMessage();
  }
}