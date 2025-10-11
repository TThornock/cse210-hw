public class ListingActivity : Activity
{
    private int _count;
    Random rand = new Random();

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine($"Prompt: {GetRandomPromt()}");
        Console.WriteLine("You may begin listing items in...");
        showCountDown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPromt()
    {
        string ranpromt = _prompts[rand.Next(_prompts.Count)];
        return ranpromt;
    }

    public List<string> GetListFromUser()
    {
        List<string> listing = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("");
            string input = Console.ReadLine();
            listing.Add(input);
        }

        return listing;
    }
}