using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> scriptureLibrary = new List<string>();
        scriptureLibrary.Add("Moses 1:39~~For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        scriptureLibrary.Add("Alma 32:21~~And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");
        scriptureLibrary.Add("Moroni 10:3-5~~Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.");
        scriptureLibrary.Add("John 3:16~~For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        scriptureLibrary.Add("Proverbs 3:5-6~~Trust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.");

        Random randomGenerator = new Random();
        int randomScriptureIndex = randomGenerator.Next(0, scriptureLibrary.Count);

        string[] scripturePassage = scriptureLibrary[randomScriptureIndex].Split("~~");


        string text = scripturePassage[1];
        string[] scriptureReference = scripturePassage[0].Split(" ");
        string scriptureBook = scriptureReference[0];
        string[] chapterVerse = scriptureReference[1].Split(":");
        int chapter = int.Parse(chapterVerse[0]);
        Reference reference;
        if (chapterVerse[1].Contains("-"))
        {
            string[] verses = chapterVerse[1].Split("-");
            reference = new Reference(scriptureBook, chapter, int.Parse(verses[0]), int.Parse(verses[1]));
        }
        else
        {
            string[] verses = chapterVerse[1].Split("-");
            reference = new Reference(scriptureBook, chapter, int.Parse(verses[0]));
        }

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.Write($"{reference.GetDisplayText()} ");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
        Console.Write("Please enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();

        bool memorizing = true;

        while (memorizing)
        {
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.Write($"{reference.GetDisplayText()} ");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.Write("Please enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();

            if (input == "quit")
            {
                return;
            }

            if (scripture.IsCompletelyHidden())
            {
                memorizing = false;
                break;
            }
        }
    }
}