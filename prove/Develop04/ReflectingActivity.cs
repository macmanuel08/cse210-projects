using System;

public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>();
  private List<string> _questions = new List<string>();

  public ReflectingActivity(string name, string description) : base(name, description)
  {
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Reflect on a moment when you faced a significant challenge and overcame it.");
    _prompts.Add("Think about a difficult decision you had to make and how it impacted your life.");
    _prompts.Add("Consider a time when you learned a valuable lesson from a mistake or failure.");
    _prompts.Add("Consider a moment when you had to step out of your comfort zone.");

    _questions.Add("How did you feel when it was complete?");
    _questions.Add("What is your favorite thing about this experience?");
    _questions.Add("What challenges did you face during the process?");
    _questions.Add("Can you describe the lessons you learned from this experience?");
    _questions.Add("In what ways has this experience influenced your perspective?");
    _questions.Add("How did this experience contribute to your personal growth?");
    _questions.Add("Were there any unexpected outcomes or surprises during the process?");
    _questions.Add("Can you identify any specific skills you developed through this experience?");
    _questions.Add("How would you approach a similar challenge differently in the future?");
    _questions.Add("Did you seek advice or support from others during this journey?");
    _questions.Add("What moments stand out as particularly memorable or impactful?");
    _questions.Add("Reflect on any moments of doubt or uncertainty you encountered.");
    _questions.Add("In what ways did this experience align with your initial expectations?");
    _questions.Add("How has this accomplishment influenced your future goals and aspirations?");
    _questions.Add("Consider the people who supported you - how did they contribute to your success?");
  }

  public string GetRandomPrompt()
  {
    Random randomGenerator = new Random();
    int randomInt = randomGenerator.Next(0, _prompts.Count - 1);
    return _prompts[randomInt];
  }

  public string GetRandomQuestion()
  {
    Random randomGenerator = new Random();
    int randomInt = randomGenerator.Next(0, _questions.Count - 1);
    return _questions[randomInt];
  }

  public void DisplayPrompt()
  {
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
  }

  public void DisplayQuestions()
  { 
    int seconds = GetDuration();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    while (DateTime.Now < endTime)
    {
      Console.Write($"> {GetRandomQuestion()}");
      ShowSpinner(6);
      Console.WriteLine("");
    }
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine("Get Ready...");
    ShowSpinner(4);

    Console.WriteLine("");
    Console.WriteLine("Consider the following prompt:");
    DisplayPrompt();
    Console.WriteLine("");
    Console.Write("When you have something in mind, press enter to continue.");
    Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Now, ponder on each of the following questions as related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();
    DisplayQuestions();
    Console.WriteLine("");
    DisplayEndingMessage();
  }
}