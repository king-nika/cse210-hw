using System;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int inputNumber = -1;
        int sum = 0;

        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            inputNumber = int.Parse(input);

            if (inputNumber == 0)
            {
                break;
            }
            numbers.Add(inputNumber);
        }

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest value is: {numbers.Max()}");
    }
}