public class ListingActivity : Activity
{
    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing them out.")
    {
        _count = 0;
    }
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    { }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}
