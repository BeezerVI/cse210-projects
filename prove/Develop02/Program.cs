// In this program, I added a feature where after the user indicated they wanted to write, the program would ask them if they would like a prompt. 
// If the user answered yes, the program would provide them with a prompt. 
// If the user said anything else, the program would simply proceed without giving them a prompt.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();

        void AddEntry()
        {
            string randomPrompt = new PromtGenerator().GetRandomPrompt();
            //Ask user if they want a prompt and if says no then say that "No prompt was givin"
            if (AskIfWantPrompt() == true)
            {
                Console.WriteLine($"Prompt: {randomPrompt}");
            }
            else
            {
                randomPrompt = "No prompt was givin";
                Console.WriteLine("Whats on your mind?");
            }
            DateTime currentDate = DateTime.Now.Date;
            Console.Write("> ");
            string newEntry = Console.ReadLine();

            Entry entry = new Entry();
            entry._entryDate = currentDate.ToString("yyyy-MM-dd");
            entry._entryText = newEntry;
            entry._promtText = randomPrompt;
            entries.Add(entry);

        }

        bool AskIfWantPrompt()
        {
            Console.WriteLine("Would you like a prompt? type 'yes' if yes otherwise type nuthing");
            string response = Console.ReadLine();

            if (response == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void DisplayEntry()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine();
                entry.DisplayEntry();
            }
        }

        void AddToFile()
        {
            string filename = FileName();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine($"{entry._entryDate}~~{entry._promtText}~~{entry._entryText}");

                }
                Console.WriteLine("made file we thinks");
            }
        }

        void LoadFromFile()
        {
            entries.Clear();
            string filename = FileName();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");

                Entry entry = new Entry();
                entry._entryDate = parts[0];
                entry._promtText = parts[1];
                entry._entryText = parts[2];
                Console.WriteLine("Added new text");

                entries.Add(entry);
            }
            Console.WriteLine("Finshed wrighting from file try display");
        }

        string FileName()
        {
            Console.WriteLine("What is the name of your file? ");
            string filename = Console.ReadLine();
            return filename;
        }


        void DisplayOptions()
        {
            Console.WriteLine("1: Wright");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Load");
            Console.WriteLine("4: Save");
            Console.WriteLine("5: Quit");
            Console.Write("What would you like to do? ");
        }

        int numberResponse = 0;
        while (numberResponse != 5)
        {
            DisplayOptions();
            //Convert user response from string to int
            string response = Console.ReadLine();
            numberResponse = int.Parse(response);

            //Find out what command they meant
            if (numberResponse == 1)
            {
                AddEntry();
            }

            else if (numberResponse == 2)
            {
                DisplayEntry();
            }

            else if (numberResponse == 3)
            {
                LoadFromFile();
            }

            else if (numberResponse == 4)
            {
                AddToFile();
            }

            else
            {
                Console.WriteLine("Good Bye!");
                numberResponse = 5;
            }
        }
    }
}