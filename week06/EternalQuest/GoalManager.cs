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
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Display Player Info");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    DisplayPlayerInfo();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("How many points is it worth?");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int targetCount = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));

        }

        else
        {
            Console.WriteLine("Invalid choice. Goal not created.");
            return;
        }
        Console.WriteLine("Goal created successfully!");
    }

public void RecordEvent()
    {
        ListGoalNames();

        Console.WriteLine("Which goal did you accomplish? (Enter the number)");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice. No event recorded.");
            return;
        }

        Goal selectedGoal = _goals[choice - 1];

        selectedGoal.RecordEvent();

        _score += selectedGoal.GetPoints();

        Console.WriteLine($"Congratulations! You earned {selectedGoal.GetPoints()} points.");
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save your goals:");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

public void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load your goals:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. No goals loaded.");
            return;
        }

        _goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])
                    );

                    _goals.Add(goal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal goal = new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])
                    );

                    _goals.Add(goal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])
                    );

                    _goals.Add(goal);
                }
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

}