using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int numberGuess = 0;
        while (magicNumber != numberGuess)
        {
            Console.WriteLine("What's your guess?(1-100)");
            string guess = Console.ReadLine();
            numberGuess = int.Parse(guess);
            if (numberGuess == magicNumber)
            {
                Console.WriteLine("Congratulations, You guessed it!");
            }
            else if (numberGuess > magicNumber)
            {
                Console.WriteLine("Guess lower");
            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
        }

    }
}