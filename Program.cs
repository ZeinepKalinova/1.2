// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("ФИО: ");
        string fullName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(fullName))
        {
            string greeting = $"Hello {fullName}!";
            Console.WriteLine(greeting);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

