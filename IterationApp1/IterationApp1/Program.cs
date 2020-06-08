using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Evelynn", "Joey", "Christopher", "Ivana" };
        Console.WriteLine("What is your name?");
        string newName = Console.ReadLine();


        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Hi, " + newName + " meet " + names[i] + ". They're part of the team.");
        }
        Console.ReadLine();



        int[] numbers = { 7, 6, 27, 29, 77 };

        for (int n = 0; n <= 4; n++)
        {
            Console.WriteLine("The number is " + numbers[n]);
        }
        Console.ReadLine();


        List<string> instructors = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
        Console.WriteLine("Please type a name search for an instructor of The Tech Academy: ");
        string userSearch = Console.ReadLine();

        for (int i = 0; i < instructors.Count; i++)
        {
            if (userSearch == instructors[i])
            {
                Console.WriteLine(userSearch + " IS found at index " + i);
            }
            else if (userSearch != instructors[i])
            {
                Console.WriteLine(userSearch + " is not found at index " + i);
            }
        }
        Console.ReadLine();


        List<string> students = new List<string>() { "Scott", "Evelynn", "Ryan", "Brock", "Scott" };
        Console.WriteLine("Please type a name search for an student of The Tech Academy: ");
        string userSearch1 = Console.ReadLine();

        for (int i = 0; i < students.Count; i++)
        {
            if (userSearch1 == students[i])
            {
                Console.WriteLine(userSearch1 + " IS found at index " + i);
            }
            else
            {
                Console.WriteLine(userSearch1 + " is NOT found at index " + i);
            }
        }
        Console.ReadLine();


        List<string> moreNames = new List<string>() { "John", "Yolanda", "Scott", "Ashanti", "Kenzie", "John", "Scott" };
        List<string> nameAppearsTwice = new List<string>();

        foreach (string name in moreNames)
        {
            if (nameAppearsTwice.Contains(name))
            {
                Console.WriteLine(name + " has already appeard in list.");
            }
            else
            {
                nameAppearsTwice.Add(name);
                Console.WriteLine(name);
            }
        }
        Console.WriteLine(nameAppearsTwice.Count);
        Console.ReadLine();

    }
}

