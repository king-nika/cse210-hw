public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Thank you for participating in the {_name}!\n");
        ShowSpinner(3);

        Console.WriteLine($"You completed the activity in {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            spinnerIndex = (spinnerIndex + 1) % spinner.Count;
            Thread.Sleep(250);
        }
    }

    public void ShowCountdown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }
}