using System;

class Program
{
    static void Main(string[] args)
    {
        static void displayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string promptUserName()
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            return name;
        }

        static int promptUserNumber()
        {
            Console.WriteLine("What is your number?");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            return number;
        }

        static int squareNumber(int userNum)
        {
            int squareNum = userNum * userNum;
            return squareNum;
        }

        static void displayResult(string User, int SquareNum)
        {
            Console.WriteLine($"{User}, the square of your number is {SquareNum} ");
        }

        displayWelcome();
        string userName = promptUserName();
        int userNum = promptUserNumber();
        int userSquareNum = squareNumber(userNum);
        displayResult(userName, userSquareNum);
    }
}