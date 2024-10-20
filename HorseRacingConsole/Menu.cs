using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public static class Menu
    {
        public static void ShowMainMenu()
        {
            //Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("\nWhat kind of user are you?");
            Console.WriteLine("1 - Racecourse Manager");
            Console.WriteLine("2 - Horse Owner");
            Console.WriteLine("3 - Racegoer");
            Console.WriteLine("4 - Exit");
        }

        public static void ShowRacecourseManagerMenu()
        {
            //Console.Clear();
            Console.WriteLine("Racecourse Manager Menu: ");
            Console.WriteLine("\n1 - Show all race events");
            Console.WriteLine("2 - Add new race event");
            Console.WriteLine("3 - Show all races");
            Console.WriteLine("4 - Add race to a race event");
            Console.WriteLine("5 - Show all horses");
            Console.WriteLine("6 - Add horses to a race");
            Console.WriteLine("7 - Go back");
        }

        public static void ShowHorseOwnerMenu()
        {
            //Console.Clear();
            Console.WriteLine("Horse Owner Menu: ");
            Console.WriteLine("\n1 - Enter horse in race");
            Console.WriteLine("2 - Go back");
        }

        public static void ShowRacegoerMenu()
        {
            //Console.Clear();
            Console.WriteLine("Racegoer Menu: ");
            Console.WriteLine("\n1 - See race event, race, and horse information");
            Console.WriteLine("2 - Go back");
        }

        public static void ShowAddRaceMenu()
        {
            //Console.Clear();
            Console.WriteLine("Add Race Menu: ");
            Console.Write("Which race event do you want to add a race to (enter event number): ");
        }
    }
}
