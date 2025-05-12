using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        PromptGenerator promptGenerator = new PromptGenerator();

        Journal journal = new Journal();

        while (input != "5")
        {
            Console.WriteLine("\nPlease select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            input = Console.ReadLine();

            if (input == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                Entry entry = new Entry(prompt, response, date);
                journal.AddEntry(entry);
            }
            else if (input == "2")
            {
                journal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.Write("Enter file name: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (input == "4")
            {
                Console.Write("Enter file name: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (input == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Please select a valid option.");
            }
        }
    }
}