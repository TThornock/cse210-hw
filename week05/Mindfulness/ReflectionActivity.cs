public class ReflectionActivity : Activity
{

    private Random rand = new Random();
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This helps you Reflect on the past.";
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine($"{DisplayPrompt}");

        Console.Write("Press Enter when ready.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"{DisplayQuestion}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPromt()
    {
        string randomPromt = _prompts[rand.Next(_prompts.Count)];
        return randomPromt;
    }

    public string GetRandomQuestions()
    {
        string randomQuestion = _questions[rand.Next(_questions.Count)];
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Prompt: {GetRandomPromt()}");
    }

    public void DisplayQuestion()
    {
        foreach (string q in _questions)
        {
            Console.WriteLine($"{q}");
            Thread.Sleep(5);
        }
    }
}