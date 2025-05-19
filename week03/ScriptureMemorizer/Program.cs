using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and Exceeding Requirements: The Scripture is selected at random from a list of scriptures
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Step 1: Define a list of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whoever believeth in him shall not perish but have everlasting life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all your heart and lean not unto thine own understanding; in all your ways acknowledge Him, and He shall direct your paths."),

            new Scripture(new Reference("Doctrine and Covenants", 10, 43),
                "I will not suffer that they shall destroy my work; yea, I will show unto them that my wisdom is greater than the cunning of the devil."),

            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),

            new Scripture(new Reference("John", 14, 15),
                "If ye love me, keep my commandments."),

            new Scripture(new Reference("Mosiah", 3, 19),
                "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.")
        };

        // Step 2: Pick one randomly
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Step 3: Scripture memorization loop
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
                Console.Write("Press ENTER to reveal the full scripture...");
                Console.ReadLine(); // Wait for another ENTER press

                // Reveal full text
                scripture.ShowAllWords();

                Console.Clear();
                Console.WriteLine("\nYou have memorized the scripture completely!");
                Console.WriteLine("\nHere is the full scripture again:");
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}