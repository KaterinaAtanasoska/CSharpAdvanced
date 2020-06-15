using System;
using System.Collections.Generic;

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> notWorkingDateList = new List<DateTime>() {
            new DateTime(2020, 01, 01),
            new DateTime(2020, 01, 07),
            new DateTime(2020, 04, 20),
            new DateTime(2020, 05, 01),
            new DateTime(2020, 05, 25),
            new DateTime(2020, 08, 03),
            new DateTime(2020, 10, 12),
            new DateTime(2020, 10, 23),
            new DateTime(2020, 12, 08)
        };

            while (true)
            {
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                DateTime date = new DateTime(year, month, day);

                
                bool notWorkingDate = false;

                foreach (var dateList in notWorkingDateList)
                {
                    if (dateList.Month == date.Month && dateList.Day == date.Day)
                    {
                        notWorkingDate = true;
                    }
                }


                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Is not working day");
                }
                else if (notWorkingDate == true)
                {
                    Console.WriteLine("Is not working day");
                }
                else
                {
                    Console.WriteLine("Is working day");
                }

                Console.WriteLine("Check another date? (y/n)");
                string newGame = Console.ReadLine();
                if (newGame == "y" || newGame == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (newGame == "n" || newGame == "N")
                {
                    break;
                }
            }

        }
    }
}
