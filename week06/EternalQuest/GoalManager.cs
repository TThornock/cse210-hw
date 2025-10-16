public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string choice = "0";


        while (choice != "6")
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select Option: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalDetails();
            }


            else if (choice == "3")
            {
                Console.Write("What is the name of the fil?: ");
                string file = Console.ReadLine();
                SaveGoals(file);
            }

            if (choice == "4")
            {
                Console.Write("What is the name of the fil?: ");
                string file = Console.ReadLine();
                LoadGoals(file);
            }

            if (choice == "5")
            {
                RecordEvent();
            }

            else
            {
                Console.WriteLine("Invalid Enrty");
            }
        }

        Console.WriteLine("Have a nice day!");
    }
    

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score} points");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];

            string details;
            if (g is ChecklistGoal c)
                details = c.GetDetailsString();
            else
                details = g.GetDetailsString();

            Console.WriteLine($"{i + 1}. {details}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Types of goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");


        Console.Write("What goal do you want to create? ");
        string goal_choice = Console.ReadLine();

        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();

        Console.Write("Give a short description: ");
        string description = Console.ReadLine();

        Console.Write("How many points will it be?: ");
        int points = int.Parse(Console.ReadLine());

        if (goal_choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (goal_choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (goal_choice == "3")
        {
            Console.Write("");
            int target = int.Parse(Console.ReadLine());

            Console.Write("");
            int bouns = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bouns));
        }

        else
        {
            Console.WriteLine("Invalid Enrty.");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        Console.WriteLine("Which goal did you accomplish?");

        Console.Write("Enter the number of the goal: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goal selectedGoal = _goals[choice - 1];

            if (selectedGoal is SimpleGoal simple)
            {
                simple.RecordEvent();
                _score += simple.GetPoints();
            }
            else if (selectedGoal is ChecklistGoal checklist)
            {
                checklist.RecordEvent();
                _score += checklist.GetPoints();
                if (checklist.IsComplete())
                    _score += checklist.GetBonus();
            }
            else if (selectedGoal is EternalGoal eternal)
            {
                eternal.RecordEvent();
             _score += eternal.GetPoints();
            } 

            Console.WriteLine($"Your total score is now {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            outputfile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputfile.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");

    }

    public void LoadGoals(string file)
    {
                _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(" | ");
            string type = parts[0].Trim();

            if (type == "SimpleGoal")
            {
                string name = parts[1].Trim();
                string desc = parts[2].Trim();
                int points = int.Parse(parts[3].Trim());
                bool isComplete = bool.Parse(parts[4].Trim());

                SimpleGoal g = new SimpleGoal(name, desc, points);
                if (isComplete == true)
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1].Trim();
                string desc = parts[2].Trim();
                int points = int.Parse(parts[3].Trim());
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1].Trim();
                string desc = parts[2].Trim();
                int points = int.Parse(parts[3].Trim());
                int bonus = int.Parse(parts[4].Trim());
                int target = int.Parse(parts[5].Trim());
                int completed = int.Parse(parts[6].Trim());

                ChecklistGoal g = new ChecklistGoal(name, desc, points, target, bonus);
                for (int j = 0; j < completed; j++)
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
        }

        Console.WriteLine("Goals loaded.");
    }    
}