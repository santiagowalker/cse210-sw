using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myjournal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string userEntry = Console.ReadLine();
                Entry entry = new Entry();
                entry._promptText = prompt;
                entry._entryText = userEntry;
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry._date = dateText;
                myjournal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                myjournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Filename: ");
                string file = Console.ReadLine();
                myjournal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Filename: ");
                string file = Console.ReadLine();
                myjournal.SaveToFile(file);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Enter a valid option.");
            }
        }

    }
}