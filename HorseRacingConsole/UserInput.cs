using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public class UserInput
    {
        public static int GetUserMenuInput(int maxOption)
        {
            Console.Write($"\nEnter a number between 1 and {maxOption}: ");
            if (int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= maxOption)
            {
                return option;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetUserMenuInput(maxOption);
            }
        }

        public static int GetUserSelection()
        {
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                return option;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetUserSelection();
            }
        }

        public static TimeOnly GetTimeFromUser()
        {
            Console.Write("Please enter the time (HH:mm): ");
            string timeInput = Console.ReadLine();

            if (TimeOnly.TryParse(timeInput, out TimeOnly time))
            {
                return time;
            }
            else
            {
                Console.WriteLine("Invalid time format. Please try again.");
                return GetTimeFromUser();
            }
        }

        public static DateOnly GetDateFromUser()
        {
            Console.Write("\nPlease enter the date (yyyy-mm-dd): ");

            string dateEntered = Console.ReadLine();

            if (DateOnly.TryParse(dateEntered, out DateOnly eventDate))
            {
                return eventDate;
            }
            else
            {
                Console.WriteLine("Invalid date format, try again!");
                return GetDateFromUser();
            }
        }

        public static Racecourse GetRacecourseFromUser()
        {
            Console.WriteLine("Available race courses:\n");

            for (int i = 1; i < Enum.GetValues(typeof(Racecourse)).Length + 1; i++)
            {
                Console.WriteLine($"{i}\t{(Racecourse)i}");
            }

            Console.Write("\nEnter the corresponding number: ");
            Racecourse userInput = (Racecourse)int.Parse(Console.ReadLine());
            return userInput;
        }

        public static string GetRaceNameFromUser()
        {
            Console.WriteLine("Available race names:\n");

            foreach (var raceName in RaceNames.Names)
            {
                Console.WriteLine($"{raceName.Key}\t{raceName.Value}");
            }

            Console.Write("\nEnter the corresponding number: ");
            int userInput = int.Parse(Console.ReadLine());
            string race = RaceNames.Names[userInput];
            RaceNames.Names.Remove(userInput);
            return race;
        }
    }
}
