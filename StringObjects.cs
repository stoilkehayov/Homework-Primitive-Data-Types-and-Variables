using System;

    class StringObjects
    {
        static void Main()
        {
        string a = "Hellow";
        string b = "World";
        object c = a + " " + b;
        string d = (string)c;
        Console.WriteLine(d);
        }
    }

