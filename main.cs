// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program is a game to guess a random number the computer has generated.

using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
    double age; 
    string weekday;
      
        Console.WriteLine(" This program will tell you if you can recieve the student discount at the local museum. Student pricing is available on Tuesdays and Thursdays for those above or below the age of 12 to 21. Student pricing is always available for those between the ages of 12 and 21. Please enter the information below...");
        Console.WriteLine("");

        Console.Write("Enter your age: ");
        age = Convert.ToDouble(Console.ReadLine());


        Console.Write("Enter the day of the week: ");
        weekday = Convert.ToString(Console.ReadLine());
        
        if (weekday == "tuesday" || weekday == "thursday" || (age > 12 && age < 21))
        {
            Console.WriteLine("You are eligible for student pricing. ");
        }
        else {
        Console.WriteLine("You are not eligible for student pricing.");
        }

        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}