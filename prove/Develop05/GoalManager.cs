using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void Start()
    {
        string option;

        do
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            displayMenu();
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
            }
        } while (option != "6");

    }

    private void displayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int index = 1;

        foreach (Goal goal in _goals)
        {            
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }

    }

    private void CreateGoal()
    {
        ListGoalNames();
        Console.Write("What type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        if (goalType == "1")
        {
            SimpleGoal goal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(goal);
        }
        else if (goalType == "2")
        {
            EternalGoal goal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(goal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
            _goals.Add(goal);
        }

    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine("");
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[goalIndex];
        goal.RecordEvent();

        
        string line = goal.GetStringRepresentation();
        string[] parts = line.Split(":");
        int earned = 0;


        if (parts[0] == "ChecklistGoal" && goal.IsComplete())
        {
            string[] goalBodyParts = parts[1].Split("~~");
            int bonus = int.Parse(goalBodyParts[3]);
            earned += bonus;
        }
        
        earned += int.Parse(goal.GetPoints());

        ConsoleColor previousColor = Console.ForegroundColor; // save the default color
        Console.ForegroundColor = ConsoleColor.Blue; // Print text in blue

        Console.WriteLine($"Congratulations! You earned {earned} points!");
        _score += earned;

        Console.WriteLine($"You now have {_score} points.");

        Console.ForegroundColor = previousColor; // Set the text color in the defualt color
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            if (parts.Count() == 2)
            {
                string goalType = parts[0];
                string goalContent = parts[1];

                if (goalType == "SimpleGoal")
                {
                    string[] goalBodyParts = goalContent.Split("~~");
                    string goalName = goalBodyParts[0];
                    string goalDescription = goalBodyParts[1];
                    string goalPoints = goalBodyParts[2];
                    bool isComplete = bool.Parse(goalBodyParts[3]);
                    SimpleGoal goal = new SimpleGoal(goalName, goalDescription, goalPoints);
                    if (isComplete)
                    {
                        goal.RecordEvent();
                    }
        
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string[] goalBodyParts = goalContent.Split("~~");
                    string goalName = goalBodyParts[0];
                    string goalDescription = goalBodyParts[1];
                    string goalPoints = goalBodyParts[2];
                    EternalGoal goal = new EternalGoal(goalName, goalDescription, goalPoints);
                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string[] goalBodyParts = goalContent.Split("~~");
                    string goalName = goalBodyParts[0];
                    string goalDescription = goalBodyParts[1];
                    string goalPoints = goalBodyParts[2];
                    int bonus = int.Parse(goalBodyParts[3]);
                    int target = int.Parse(goalBodyParts[4]);
                    int amountCompleted = int.Parse(goalBodyParts[5]);
                    ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
                    for (int i = 0; i < amountCompleted; i++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
        }
    }
}