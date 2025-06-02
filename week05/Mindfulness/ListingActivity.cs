public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing them out.")
    {
        _count = 0;
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items.");

        DisplayEndMessage();

        Logger.DisplayListingLog();
        ShowSpinner(10);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
