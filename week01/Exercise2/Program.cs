using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your score percentage: ");
        int score = int.Parse(Console.ReadLine());

        string letter;
        if (score >= 90)
            letter = "A";
        else if (score >= 80)
            letter = "B";
        else if (score >= 70)
            letter = "C";
        else if (score >= 60)
            letter = "D";
        else
            letter = "F";
        
        if (score >= 70)
            Console.WriteLine("Congratulations! You passed.");
        else
            Console.WriteLine("Sorry, better luck next time...");
        Console.WriteLine($"Your grade is {letter}.");
    }
}