using System;
using System.IO;

// For additional feature, I added a delete option to the program using System.IO
// The Option is 5 and specify the file name to delete

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        int action;

        do
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                Entry entry = new Entry();
                
                DateTime currentDateAndTime = DateTime.Now;
                string formattedDate = currentDateAndTime.ToString("M/d/yyyy");
                entry._date = formattedDate;

                string prompt = generator.GetRandomPrompt();
                entry._prompText = prompt;
                
                Console.WriteLine(prompt);
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (action == 2)
            {
                journal.DisplayAll();
            }
            else if (action == 3) {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                List<Entry> loadedEntries = ReadFromFile(fileName);

                foreach (Entry entry in loadedEntries)
                {
                    journal.AddEntry(entry);
                }
            }
            else if (action == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                SaveToFile(journal._entries, fileName);
            }
            else if (action == 5)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                File.Delete(fileName);
                Console.WriteLine($"{fileName} deleted successfully");
            }
        }
        while (action != 6);
    }

    public static void SaveToFile(List<Entry> entries, string fileName)
    {
        Console.WriteLine("Saving to a file...");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompText}~~{entry._entryText}");
            }
        }
    }

    public static List<Entry> ReadFromFile(string fileName)
    {
        Console.WriteLine("Reading list from file...");
        List<Entry> entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompText = parts[1];
            newEntry._entryText = parts[2];
            entries.Add(newEntry);
        }
        return entries;
    }
}