using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter = "";
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber <= 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Prepare yourself, you can do better than this!");
        }
    }

}