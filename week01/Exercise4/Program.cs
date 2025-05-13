using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        while ( number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is {sum}");

        int count = numbers.Count();
        int average = sum / count;
        Console.WriteLine($"The average is {average}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is {largest}");
    }
}