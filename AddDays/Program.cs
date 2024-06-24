namespace AddDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            while (dayNumber < 1 || dayNumber > 7)
            {
                Console.Write("Invalid input. Please enter a number between 1 and 7: ");
                dayNumber = Convert.ToInt32(Console.ReadLine());
            }

            string dayName = GetDayName(dayNumber);
            Console.WriteLine("The day is " + dayName);

            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt32(Console.ReadLine());

            int finalDay = (dayNumber + dayToAdd - 1) % 7 + 1;
            string finalDayName = GetDayName(finalDay);

            Console.WriteLine("The day is " + finalDayName);
     }
          static string GetDayName(int dayNumber)
          {
            if (dayNumber == 1) return "MONDAY";
            if (dayNumber == 2) return "TUESDAY";
            if (dayNumber == 3) return "WEDNESDAY";
            if (dayNumber == 4) return "THURSDAY";
            if (dayNumber == 5) return "FRIDAY";
            if (dayNumber == 6) return "SATURDAY";
            if (dayNumber == 7) return "SUNDAY";
            return "Invalid day";
         }
     }
 }
