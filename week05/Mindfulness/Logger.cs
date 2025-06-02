public static class Logger
{
    private static readonly string _filePath = "mindfulness_log.txt";

    public static void LogActivity(string activityName, int duration, string details = "")
    {
        string logEntry = $"{DateTime.Now}: {activityName} - Duration: {duration} seconds. Details: {details}";
        File.AppendAllText(_filePath, logEntry + Environment.NewLine);
    }

    public static void DisplayBreathingLog()
    {
        Console.WriteLine("\nBreathing Activity Log:");
        DisplayLog("Breathing");
    }

    public static void DisplayListingLog()
    {
        Console.WriteLine("\nListing Activity Log:");
        DisplayLog("Listing");
    }

    public static void DisplayReflectingLog()
    {
        Console.WriteLine("\nReflecting Activity Log:");
        DisplayLog("Reflecting");
    }

    private static void DisplayLog(string activityName)
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("No log entries found.");
            return;
        }

        string[] logEntries = File.ReadAllLines(_filePath);
        foreach (string entry in logEntries)
        {
            if (entry.Contains(activityName))
            {
                Console.WriteLine(entry);
            }
        }
    }
}