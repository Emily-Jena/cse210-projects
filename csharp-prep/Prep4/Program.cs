using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Appended List");
        Console.WriteLine("------------------");
        // ----------------------------------------------
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int inputNum = -1;

        while (inputNum != 0)
        {   
        Console.Write("Enter number: ");
        inputNum = int.Parse(Console.ReadLine());

        if (inputNum != 0)
        {
            numbers.Add(inputNum);
        }
        }

        if (numbers.Count > 0) 
        {
        // ----Calculate Sum ----------
        int sumNum = 0;
        foreach (int number in numbers) 
        {
            sumNum += number;
        }
        Console.WriteLine($"The sum is {sumNum}");

        // ------Calculate Average -------------
        float aveNum = ((float)sumNum) / numbers.Count;
        Console.WriteLine($"The average is {aveNum}");

        // ------ Calculate Max Digit ---------------
        int largeNum = numbers[0];
        foreach (int number in numbers)
        {        
            if (largeNum < number) 
            {
                largeNum = number;
            }
        }
        Console.WriteLine($"The largest number is {largeNum}");
        } 

    }
} 