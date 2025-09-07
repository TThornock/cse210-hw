using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        float set_number = 35;
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (set_number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            set_number = float.Parse(input);
            if (set_number != 0)
            {
                numbers.Add(set_number);
            }
        }

        float sum = 0;

        foreach (float number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");


        float max = numbers[0];

        float min = numbers[0];

        foreach (float number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min && number > -1)
            {
                min = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        Console.WriteLine($"The smallest positive number is: {min}");


        numbers.Sort();
        Console.WriteLine("The list sorted is:");
        foreach (float number in numbers)
        {
            Console.WriteLine($"{number}");
        }


    }
}