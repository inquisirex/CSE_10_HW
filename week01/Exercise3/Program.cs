using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine(number);
        int guess = 0;
        while (!(number == guess))
        {
            Console.WriteLine("What is your guess?");
            string magicGuess = Console.ReadLine();
            guess = int.Parse(magicGuess);
            if (guess > number)
            {
                Console.WriteLine("too High");
            }
            else if (guess < number)
            {
                Console.WriteLine("too low");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
            


    }
}