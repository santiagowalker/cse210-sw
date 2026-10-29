using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        DisplayResult(name, sqNumber);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What's your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What's your favorite number? ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
        static int SquareNumber(int number)
        {
            int sqUserNumber = number * number;
            return sqUserNumber;
        }
        static void DisplayResult(string userName, int sqUserNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqUserNumber}");
        }
    
}