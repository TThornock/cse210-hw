using System;
using System.Diagnostics;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Assinment a1 = new Assinment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummery());

        MathAssinment a2 = new MathAssinment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(a2.GetSummery());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssinment a3 = new WritingAssinment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummery());
        Console.WriteLine(a3.GetWritingInformation());
    }
}