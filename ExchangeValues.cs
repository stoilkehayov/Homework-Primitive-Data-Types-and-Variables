using System;

    class ExchangeValues
    {
        static void Main()
        {
        byte numberOne = 5;
        byte numberTwo = 10;
        Console.WriteLine(numberOne);
        Console.WriteLine(numberTwo);
        byte numberThree;
        numberThree = numberOne;
        numberOne = numberTwo;
        numberTwo = numberThree;
        Console.WriteLine(numberOne);
        Console.WriteLine(numberThree);
        }
    }

