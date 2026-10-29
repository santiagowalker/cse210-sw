using System;
using System.Collections.Concurrent;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, enter 0 when finished");
        List<int> numbers = new List<int>();
        int userNumber = 1;
        while (userNumber != 0)
        {
        Console.WriteLine("Enter a number:");
        string enteredNumber = Console.ReadLine();
        userNumber = int.Parse(enteredNumber);
        if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int total = 0;
        foreach (int number in numbers)
        {
            total = total + number;
        }
        double totalNumbers = numbers.Count;
        double average = total / totalNumbers;
        int maxNum = numbers[0];
        foreach(int number in numbers)
        {
            if(number > maxNum)
            {
                maxNum = number;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");
    }
}