using System;

    class NullValues
    {
        static void Main()
        {
        int? n = null;
        double? d = null;
        Console.WriteLine(n);
        Console.WriteLine(d);
        Console.WriteLine("{0} {1}",n,d);
        int a = 46;
        Console.WriteLine("{0}",n+a);
        Console.WriteLine("{0}",d+a);

        }
    }

