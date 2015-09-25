using System;

    class ComparingFloats
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double result = Math.Abs(a - b);
        if (result < 0.000001)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        }
    }
