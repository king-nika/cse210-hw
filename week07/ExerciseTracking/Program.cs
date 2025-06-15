using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        RunningActivity runningActivity = new RunningActivity(30, 5);
        activities.Add(runningActivity);

        CyclingActivity cyclingActivity = new CyclingActivity(45, 10);
        activities.Add(cyclingActivity);

        SwimmingActivity swimmingActivity = new SwimmingActivity(30, 6);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}