namespace Friday_the_13th
{
    internal class Program
    {
        // Creates 2 dateTime variables and sets "day" to be the current time.
        static DateTime day = DateTime.Now;
        static DateTime tenYears;

        static void Main()
        {
            // The variables "tenYears" becomes today + 10 years.
            tenYears = day;
            tenYears = tenYears.AddYears(10);

            // Creates a while loop, which ends when "tenYears" is no longer larger than "day".
            while (day < tenYears)
            {
                // Calls boolean method, which checks if the date is 13 and day is friday.
                if (IsFridayThe13th())
                {
                    // Creates a string which takes the day, month and year values of the "day" variable, which then gets output in the console.
                    string date = day.ToString("dd:MM:yyyy");
                    Console.WriteLine($"it is friday the 13th, the {date}");
                }

                // Adds 1 to the day
                day = day.AddDays(1);
            }
        }

        static bool IsFridayThe13th()
        {
            // Checks if the day is friday and the day in the month is 13. If it passes, then we return true.
            if(day.DayOfWeek == DayOfWeek.Friday && day.Day == 13)
            {
                return true;
            }

            // Returns false, only if the if statement isnt true.
            return false;
        }
    }
}