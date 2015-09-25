using System;

    class EmployeeData
    {
        static void Main()
        {
        string firsttName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int personalID = int.Parse(Console.ReadLine());
        int uniqueNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("First Name: " + firsttName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + personalID);
        Console.WriteLine("Unique Number: " + uniqueNumber);
    }
    }

