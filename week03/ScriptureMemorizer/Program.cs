using System;
using System.Collections.Concurrent;
using System.Xml.Serialization;
// I improved the random word hiding so that previously hidden words are not counted again, ensuring the requested number of new words are hidden when possible.
class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Ether", 12, 27);
        Scripture s1 = new Scripture(r1, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        Console.WriteLine(s1.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string choice = Console.ReadLine();
        while (choice != "quit" && s1.IsCompletelyHidden() == false)
        {
            if (choice == "")
            {
                s1.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine(s1.GetDisplayText());
            }
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();
        }
    }
}