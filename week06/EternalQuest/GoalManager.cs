public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string input = "";

        while (input != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.");

            Console.WriteLine("\nPlease select one of the following options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo() { }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];

            Console.ForegroundColor = goal.IsComplete() ? ConsoleColor.Green : ConsoleColor.Yellow;
            Console.WriteLine($"{i + 1}. [{(goal.IsComplete() ? "X" : " ")}] {goal.GetDetailsString()}");
            Console.ResetColor();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("> ");
        string goal = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Please give a short description of your goal: ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goal)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Please select a valid option.");
                break;
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            if (!_goals[index].IsComplete())
            {

                Goal goal = _goals[index];
                goal.RecordEvent();
                _score += goal.GetPoints();

                Console.WriteLine($"You now have {_score} points.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
        else
        {
            Console.WriteLine("Please select a valid goal.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("\nPlease enter a filename to save the goals: ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt")) filename += ".txt";

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals saved successfully to {filename}!");
    }

    private void LoadGoals()
    {
        Console.Write("\nPlease enter a filename to load the goals: ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt")) filename += ".txt";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');

            switch (parts[0])
            {
                case "Simple":
                    SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));

                    if (bool.Parse(parts[4]))
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                    break;
                case "Eternal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "Checklist":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4])));
                    break;
            }
        }
    }
}