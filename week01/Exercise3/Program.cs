using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int magicNumber = new Random().Next(1,100);

        while (true)
        {
            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber == guessNumber) {
                Console.WriteLine("You guessed it!");
                break;                
            }
            else if (magicNumber > guessNumber)
                Console.WriteLine("Higher");
            else if (magicNumber < guessNumber)
                Console.WriteLine("Lower");
        }
    }
}