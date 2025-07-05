using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, to end the list type 0:");
        int lastNumber = -1;
        int sumTotal = 0;
        int greatest = 0;

        while (!(lastNumber == 0))
        {
            string inputString = Console.ReadLine();
            int inputNumber = int.Parse(inputString);
            if (inputNumber == 0)
            {
                break;
            }
            numbers.Add(inputNumber);
            lastNumber = inputNumber;
            sumTotal += inputNumber;
            if (inputNumber > greatest)
            {
                greatest = inputNumber;
            }
        }
        int avgTotal = (sumTotal / numbers.Count);
        Console.WriteLine($"The sum total is: {sumTotal}");
        Console.WriteLine($"The average total is: {avgTotal}");
        Console.WriteLine($"The Greatest number in the list is {greatest}");
    }
}