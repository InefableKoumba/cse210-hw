using System;
using System.Collections.Generic;
using System.IO;

// Exceeding Requirements:
// 1. The program can load a library of scriptures from a file ("scriptures.txt") and randomly selects one to present to the user.
// 2. The program hides words by only selecting from words that are not already hidden, ensuring it doesn't waste attempts on hidden words.
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Reference defaultRef = new Reference("Proverbs", 3, 5, 6);
            string defaultText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
            scriptures.Add(new Scripture(defaultRef, defaultText));
        }

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();
        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        string book = parts[0];
                        int chapter = int.Parse(parts[1]);
                        int startVerse = int.Parse(parts[2]);
                        int endVerse = int.Parse(parts[3]);
                        string text = parts[4];

                        Reference reference;
                        if (startVerse == endVerse)
                        {
                            reference = new Reference(book, chapter, startVerse);
                        }
                        else
                        {
                            reference = new Reference(book, chapter, startVerse, endVerse);
                        }

                        scriptures.Add(new Scripture(reference, text));
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading scriptures: {e.Message}");
        }

        return scriptures;
    }
}