using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please provide your grade percentage: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Contgratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, You didnt pass the course. Try again next semester");
        }


        Console.WriteLine($"Your grade is {letter}");
    }
}