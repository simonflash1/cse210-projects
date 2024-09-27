using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when you are finished.");
        List<int> numbers = new List<int>();
        int number;
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);

            }
        } while (number != 0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double avgerage = numbers.Average();
            int largest = numbers.Max();
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The avgerage is: {avgerage}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}