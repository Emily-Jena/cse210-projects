using System;



class Program
{
//     static double AddNumbers(double a, double b) {
//         return a + b;
//     }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("This is in C#");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");

        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");

        
        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");

        
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
