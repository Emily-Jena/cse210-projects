using System;

class Circle 
{
    private double _radius; // only accessible within this class - always protected

    public void SetRadius(double radius) // can access outside of class
    {
        if (radius < 0) 
        {
            Console.WriteLine("Error, radius must be > 0");
            return;
        }
        _radius = radius; //attribute radius is = to radius
        //this.radius = radius // it is an option.
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}

class Program
{
//     static double AddNumbers(double a, double b) {
//         return a + b;
//     }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");

        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle.GetRadius()}");

        
        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");
        
        }
        

        // int x = 10;
        // if (x==10)
        // {
        //     Console.WriteLine("X is 10");
        // }

        // Console.WriteLine("Hey, how are you?");
        // Console.WriteLine("Hey Betty, How are you?");

        // for (int i = 0; i < 20; i++);
        // {
        //     Console.WriteLine("Hello, Bob");
        // }

        // for (int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine("Hello, Bob");

        // }

        // for (int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"Hello, Bob {i}");

        // }

        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(99);
        // myNumbers.Add(25);
        // myNumbers.Add(-132);
        // //myNumbers.Append(21);
        // myNumbers.Add(230);

        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        //}

    // double total = AddNumbers(123.98, 985.12356);
    // Console.WriteLine(total); //calling the return code
    

    }
