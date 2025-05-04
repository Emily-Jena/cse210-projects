using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Function Calling");
        Console.WriteLine("---------------------");
        //--------------------------------------------
        {
            DisplayWelcomeMessage();

            string inputName = PromptUserName();
            int inputNum = PromptUserNumber();
            int squaredNum = SquareNumber(inputNum);

            DisplayResult(inputName, squaredNum);

        }
        // ----- functions and prompt ----------------
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write($"Please enter your name: ");
            string userName = Console.ReadLine();
            return userName; // -- always return te prompt
        }

        static int PromptUserNumber()
        {
            Console.Write($"Please enter your favourite number: ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }
        
        // ---- Calculate favourite number -------------
        static int SquareNumber(int favNum)
        {
            int sqNum = favNum * favNum;
            return sqNum;
        }

        // ---------- Display Results ---------------------
        static void DisplayResult(string userName, int sqNum)
        {
        Console.WriteLine($"{userName}, the square of your number is {sqNum}");
        }
    }
}
