using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        int sign_check = percentage % 10;


        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F" && percentage < 97)
        {
            if (sign_check >= 7)
            {
                sign = "+";
            }
            else if (sign_check < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass the class.");
        }
    
    }
}