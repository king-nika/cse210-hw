using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the programme!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            return number;
        }

        static double SquareNumber(int number)
        {
            double square = Math.Pow(number, 2);

            return square;
        }

        static void DisplayResult(string name, double number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        double squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);
    }
}