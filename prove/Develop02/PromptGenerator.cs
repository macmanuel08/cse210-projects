using System;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>
    {
      "What is one accomplishment that made today fulfilling for me?",
      "In what way did I demonstrate kindness or empathy towards others today?",
      "What unexpected joy or surprise did I encounter during the day?",
      "How did I handle a challenging situation today, and what did I learn from it?",
      "What is a new skill or knowledge I acquired today?",
      "What is a goal I made progress towards today?",
      "How did I prioritize self-care today?",
      "What communication or listening skills can I improve?",
      "What is a specific moment or event from today that I want to remember and cherish?",
      "If I could express gratitude to someone for their impact on my day, who would it be and why?"
    };

  public string GetRandomPrompt() {
    Random randomGenerator = new Random();
    int randomNumber = randomGenerator.Next(0, 10);
    return _prompts[randomNumber];
  }
}