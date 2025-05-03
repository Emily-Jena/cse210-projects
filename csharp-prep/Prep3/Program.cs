using System;
using System.Formats.Asn1;
using System.Net;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess My number");
        Console.WriteLine("----------------");
        // ---------------Formula---------------------
       
        string repeat;
        do 
        {

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101); 
        int guessNum = -1;

        
        while (guessNum != magicNum)
        {        
        // Console.Write("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine()); //ReadLine allows user input.
        Console.Write("What is your guess? ");
        guessNum =  int.Parse(Console.ReadLine());

        // Formula to see if it is higher or lower.
        
            if (guessNum < magicNum )
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }

            Console.Write("Do you want to continue? ");
            repeat = Console.ReadLine();
            } while (repeat == "yes");

    }
}