using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(scripture.GetDisplayText());
        Console.Write("How many words would you like to have hide per round? (1-5) ");
        int hidNumber = int.Parse(Console.ReadLine());

        while (scripture.IsCompltlyHidden() != true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide more words");
            Console.ReadLine();
            scripture.hideRandomWords(hidNumber);
        }

        Console.Clear();
        Console.WriteLine("See you next time!");
    } 

}