using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while (option != "q")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("q. Quit");
            Console.Write("Enter your choice: ");
            option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndMessage();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndMessage();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndMessage();
                    break;
                case "q":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}