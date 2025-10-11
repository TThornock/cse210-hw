using System.Linq;
using System.Numerics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerList =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < end)
        {
            string s = spinnerList[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerList.Count)
            {
                i = 0;
            }
        }
    }

    public void showCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}