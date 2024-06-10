﻿using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter year of birth: ");
        int yearOfBirth = Convert.ToInt16(Console.ReadLine());

        var result = IdentifyAge(yearOfBirth);

        Console.WriteLine($"{result.Age} years old, {result.Generation}, {result.Stage}");
    }

    static (int Age, string Generation, string Stage) IdentifyAge(int yearOfBirth)
    {
        int age = 2024 - yearOfBirth;
        string generation = GetGeneration(age);
        string stage = GetStage(age);

        return (age, generation, stage);
    }

    static string GetGeneration(int age)
    {
        if (age >= 79 && age <= 96) return "The Silent Generation";
        if (age >= 60 && age <= 78) return "Baby Boomers";
        if (age >= 44 && age <= 59) return "Gen X";
        if (age >= 28 && age <= 43) return "Millenials";
        if (age >= 12 && age <= 27) return "Gen Z";
        if (age >= 0 && age <= 11) return "Gen Alpha";
        return "";
    }

    static string GetStage(int age)
    {
        if (age >= 0 && age <= 3) return "Infant";
        if (age >= 4 && age <= 6) return "Early Childhood";
        if (age == 7 || age == 8) return "Middle Childhood";
        if (age >= 9 && age <= 11) return "Late Childhood";
        if (age >= 12 && age <= 20) return "Adolescence";
        if (age >= 21 && age <= 35) return "Early Adulthood";
        if (age >= 36 && age <= 50) return "Midlife";
        if (age >= 51 && age <= 80) return "Mature Adulthood";
        if (age > 80) return "Late Adulthood";
        return "";
    }
}