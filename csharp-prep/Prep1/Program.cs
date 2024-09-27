using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First Name? ");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your Last Name?");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");

    }
}