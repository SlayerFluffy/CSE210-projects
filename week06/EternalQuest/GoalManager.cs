using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    //Attributes
    private List<Goal> _goals;
    private int _score;
    private string _path;
    private string _userName;

    //Constructors
    public GoalManager()
    {
        _score = 0;
        _path = " ";
    }

    //Methods
    public void Start()
    {
        // run menu loop
        string choice = "0";
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("Would you like to load a previous set of goals? (y/n)");
        string response = Console.ReadLine();
        
        if (response == "y")
        {
            LoadGoals();
        }
        else
        {
            _goals = new List<Goal>();
            Console.WriteLine("Please enter your name.");
            _userName = Console.ReadLine();
        }

        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                AddGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Current unsaved goals will be lost. Are you sure you want to load a new set of goals? (y/n)");
                string ynLoadGoals = Console.ReadLine();
                if (ynLoadGoals != "y")
                {
                    return;
                }                
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n{_userName}, your score is {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are: ");
        int goalNumber = 1;
        foreach (Goal item in _goals)
        {
            string name = item.GetName();
            Console.WriteLine($"{goalNumber}. {name}");
            goalNumber ++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals are: ");
        int goalNumber = 1;
        foreach (Goal item in _goals)
        {
            string description = item.GetDescription();
            char isMarked = item.IsComplete() ? 'X' : ' ';
            string name = item.GetName();
            if (item is ChecklistGoal checklistGoal)
            {
            Console.WriteLine($"{goalNumber}. [{isMarked}] {name} ({description}) -- completed {checklistGoal.GetAmountCompleted()}/{checklistGoal.GetTarget()}.");
            }
            else
            {
            Console.WriteLine($"{goalNumber}. [{isMarked}] {name} ({description}).");
            }
            goalNumber ++;
        }
    }
    public void AddGoal()
    {
        Console.WriteLine("What type of goal would you like to add?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("4. Bad Habit Goal");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the name of the goal.");
        string name = Console.ReadLine();
        Console.WriteLine("Enter a short description.");
        string description = Console.ReadLine();
        
        if (choice == 1)
        {
            Console.WriteLine("How many points is this goal worth?");
            string points = Console.ReadLine();
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == 2)
        {
            Console.WriteLine("How many times does this goal need to be completed?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("How many points is this goal worth?");
            string points = Console.ReadLine();
            Console.WriteLine("How many bonus points are awarded for completing this goal?");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else if (choice == 3)
        {
            Console.WriteLine("How many points is this goal worth?");
            string points = Console.ReadLine();
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 4)
        {
            Console.WriteLine("How many points will be deducted for this bad habit?(Enter a positive number, will automatically be converted to negative)");
            string points = Console.ReadLine();
            points = "-"+Console.ReadLine();
            _goals.Add(new BadHabitGoal(name, description, points));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        ListGoalNames();
        int choice = int.Parse(Console.ReadLine());
        Goal goal = _goals[choice - 1];
        goal.RecordEvent();
        if (goal is ChecklistGoal)
        {
            _score += int.Parse(goal.GetPoints());
        }
        if (goal is EternalGoal)
        {
            _score += int.Parse(goal.GetPoints());
        }
        if (goal.IsComplete())
        {
            if (goal is ChecklistGoal checklistGoal)
                {
                    _score += checklistGoal.GetBonus();
                    return;
                }
            else
            {
                _score += int.Parse(goal.GetPoints());
            }
        }
        if (goal is BadHabitGoal)
        {
            _score += int.Parse(goal.GetPoints());
        }

    }
    public void SaveGoals()
    {
        List<string> lines = new List<string>();
        Console.WriteLine("Enter a file name to save your goals.");
        _path = Console.ReadLine() + ".txt";
        lines.Add($"{_userName}~{_score}");
        foreach (Goal item in _goals)
        {
            lines.Add(item.GetStringRepresentation());
        }
        File.WriteAllLines(_path, lines);
    }
    public void LoadGoals()
    {
        Console.WriteLine("Enter the file name to load your goals.");
        _path = Console.ReadLine() + ".txt";
        string[] lines = File.ReadAllLines(_path);
        _userName = lines[0].Split('~')[0];
        _score = int.Parse(lines[0].Split('~')[1]);
        lines = lines.Skip(1).ToArray();
        _goals = [];
        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, complete));
            }
            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                goal.SetAmountCompleted(amountCompleted);
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
        }
    }
    public void BonusPoints()
    {
        foreach (Goal item in _goals)
        {
            if (item.IsComplete())
            {
                if (item is ChecklistGoal checklistGoal)
                {
                    _score += checklistGoal.GetBonus();
                }
            }
        }
    }
}