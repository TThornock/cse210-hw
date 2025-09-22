using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator promt = new PromptGenerator();
        Journal journal = new Journal();
        string choice = "0";

        while (choice != "5")
        {
            Console.WriteLine("1: Write a new entry");
            Console.WriteLine("2: Display the journal");
            Console.WriteLine("3: Save the Journal to a file");
            Console.WriteLine("4: Load the journal from a file");
            Console.WriteLine("5: Quit");
            Console.Write("Enter option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string newPrompt = promt.GetRandomPrompt();

                Console.WriteLine($"{newPrompt}");

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                Console.Write("");
                string entry = Console.ReadLine();

                Entry newEntry = new Entry(newPrompt, entry, date);
                journal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                journal.Displayall();
            }

            else if (choice == "3")
            {
                Console.Write("File name:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "4")
            {
                Console.Write("File name: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            
            else if (choice == "5")
            {
                Console.WriteLine("Have a nice day!");
            }

            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}