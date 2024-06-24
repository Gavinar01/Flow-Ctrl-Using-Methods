using System;

namespace EvaluateGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfGrades = GetNumberOfGrades();
            double[] grades = GetGrades(numberOfGrades);

            Console.WriteLine("END OF USER INPUT");
            Console.WriteLine("PROCESSING GRADES....");

            double average = CalculateAverage(grades);
            string gradeStatus = EvaluateGrade(average);

            Console.WriteLine("The average grade is " + average);
            Console.WriteLine(gradeStatus);

            DisplayGrades(grades);
        }

        static int GetNumberOfGrades()
        {
            Console.Write("Enter how many grades you want to input: ");
            return Convert.ToInt16(Console.ReadLine());
        }

        static double[] GetGrades(int numberOfGrades)
        {
            double[] grades = new double[numberOfGrades];

            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write("Input grade: ");
                double grade;
                while (true)
                {
                    try
                    {
                        grade = Convert.ToDouble(Console.ReadLine());
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid Input. Please enter a grade between 0 and 100.");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input. Please enter a valid grade.");
                    }
                }
                grades[counter] = grade;
            }

            return grades;
        }

        static double CalculateAverage(double[] grades)
        {
            double sum = 0;
            for (int counter = 0; counter < grades.Length; counter++)
            {
                sum += grades[counter];
            }

            return sum / grades.Length;
        }

        static string EvaluateGrade(double average)
        {
            if (average <= 50)
            {
                return "FAILED";
            }
            else if (average > 50 && average <= 70)
            {
                return "FAIR";
            }
            else if (average > 70 && average <= 80)
            {
                return "GOOD";
            }
            else if (average > 80 && average <= 90)
            {
                return "VERY GOOD";
            }
            else if (average > 90 && average <= 100)
            {
                return "EXCELLENT";
            }

            return "Invalid grade";
        }

        static void DisplayGrades(double[] grades)
        {
            Console.WriteLine("Here are the grades given by your professor:");

            for (int counter = 0; counter < grades.Length; counter++)
            {
                Console.Write(grades[counter] + "-");
            }
            Console.WriteLine();
        }
    }
}
