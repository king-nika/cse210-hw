public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }
    public void Run()
    {
        DisplayStartMessage();

        Console.Clear();

        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(5);
            Console.Write("Breathe out...");
            ShowCountdown(5);
        }

        DisplayEndMessage();
    }
}