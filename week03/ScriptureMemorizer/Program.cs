using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Create reference and scripture instances
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whoever believeth in him shall not perish but have everlasting life.");

        // Create a loop to display scripture and hide words until all words are hidden
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress ENTER to continue or 'quit' to exit... ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide a random number of words
            scripture.HideRandomWords(3);

            // Check if completely hidden without triggering Show() yet
            bool isFullyHidden = scripture.IsCompletelyHidden();

            if (isFullyHidden)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText()); // shows all hidden
                Console.WriteLine("\nYou have memorized the scripture completely!");
                Console.Write("Press ENTER to reveal the full scripture...");
                Console.ReadLine(); // Wait for another ENTER press

                // Reveal full text
                scripture.ShowAllWords();

                Console.Clear();
                Console.WriteLine("\nHere is the full scripture again:");
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}