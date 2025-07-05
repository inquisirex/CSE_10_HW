using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello please input in your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeNumberFormat = int.Parse(grade);
        string letterGrade = "";
        string plusOrMinus = "";

        if (gradeNumberFormat >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNumberFormat >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNumberFormat >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNumberFormat >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (!(letterGrade == "F"))
        {
            int sign = gradeNumberFormat % 10;
            if(!(letterGrade == "A") && sign >= 7)
            {
                plusOrMinus = "+";
            }
            else if (sign <= 3)
            {
                plusOrMinus = "-";
            }
        }

        Console.WriteLine($"You got a {letterGrade}{plusOrMinus} on this course");

        if (gradeNumberFormat >= 70)
        {
            Console.WriteLine("You passed this course!");
        }
        else
        {
            Console.WriteLine("You did not manage to pass, better luck next time!");
        }       
    }
}