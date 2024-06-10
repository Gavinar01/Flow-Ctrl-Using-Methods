namespace AddDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = GetDayNumberFromUser();
            string dayName = GetDayName(dayNumber);

            if (string.IsNullOrEmpty(dayName))
            {
                Console.WriteLine("Invalid Input.");
                return;
            }

            Console.WriteLine("The day is " + dayName);

            int dayToAdd = GetDayToAddFromUser();
            int finalDay = CalculateFinalDay(dayNumber, dayToAdd);
            string finalDayName = GetDayName(finalDay);

            Console.WriteLine("The day is " + finalDayName);
        }

        static int GetDayNumberFromUser()
        {
            Console.Write("Enter a number between 1 to 7: ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                return dayNumber;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                return GetDayNumberFromUser(); // recursive call to prompt user again
            }
        }

        static int GetDayToAddFromUser()
        {
            Console.Write("Input number to add to the day: ");
            if (int.TryParse(Console.ReadLine(), out int dayToAdd))
            {
                return dayToAdd;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return GetDayToAddFromUser(); // recursive call to prompt user again
            }
        }

        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "MONDAY";
                case 2:
                    return "TUESDAY";
                case 3:
                    return "WEDNESDAY";
                case 4:
                    return "THURSDAY";
                case 5:
                    return "FRIDAY";
                case 6:
                    return "SATURDAY";
                case 7:
                    return "SUNDAY";
                default:
                    return null;
            }
        }

        static int CalculateFinalDay(int dayNumber, int dayToAdd)
        {
            // Calculate the final day by adding the day to add and taking the remainder modulo 7
            // This ensures the result is within the range of 1 to 7
            return (dayNumber + dayToAdd - 1) % 7 + 1;
        }
    }
}