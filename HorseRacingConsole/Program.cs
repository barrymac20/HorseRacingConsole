using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace HorseRacingConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunHorseRacingApp();
        }

        // Run app method
        public static void RunHorseRacingApp()
        {
            List<RaceEvent> raceEvents = new List<RaceEvent>();
            // For testing
            RaceEvent raceEvent1 = new RaceEvent("Ascot", new DateOnly(2024, 10, 14));
            RaceEvent raceEvent2 = new RaceEvent("Epsom", new DateOnly(2024, 11, 1));
            raceEvents.Add(raceEvent1);
            raceEvents.Add(raceEvent2);

            MainMenu(raceEvents);
        }

        // Menu methods
        private static void MainMenu(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                ShowMainMenu();
                int userType = GetUserInput(4);

                switch (userType)
                {
                    case 1: HandleRacecourseManager(raceEvents); break;
                    case 2: HandleHorseOwner(); break;
                    case 3: HandleRacegoer(); break;
                    case 4: return;
                    default: break;
                }
            }
        }

        private static void HandleRacecourseManager(List<RaceEvent> raceEvents)
        {
            bool x = true;
            while (x)
            {
                ShowRacecourseManagerMenu();
                int managerOption = GetUserInput(6);

                switch (managerOption)
                {
                    case 1: GetRaceEventsTable(raceEvents); break;
                    case 2:
                        CreateNewRaceEvent(raceEvents);
                        GetRaceEventsTable(raceEvents); break;
                    case 3:
                        GetRacesTable(raceEvents);
                        //int eventNumber0 = int.Parse(Console.ReadLine());
                        //RaceEvent selectedRaceEvent0 = raceEvents[eventNumber0 - 1];
                        //Console.WriteLine(selectedRaceEvent0);
                        break;
                    case 4:
                        GetRaceEventsTable(raceEvents);
                        ShowAddRaceMenu();
                        int eventNumber = int.Parse(Console.ReadLine());
                        RaceEvent selectedRaceEvent = raceEvents[eventNumber - 1];
                        CreateNewRace(selectedRaceEvent.Races);
                        Console.WriteLine(selectedRaceEvent);
                        break;
                    case 5:
                        GetRaceEventsTable(raceEvents);
                        Console.WriteLine("Choose event: ");
                        int eventNumber1 = int.Parse(Console.ReadLine());
                        RaceEvent selectedRaceEvent1 = raceEvents[eventNumber1 - 1];
                        Race.ShowListOfRaces(selectedRaceEvent1.Races);
                        Console.WriteLine("Choose race to add horse to: ");
                        break;
                    case 6:
                        x = false;
                        //Console.Clear();
                        break;
                    default: break;
                }
                //break;
            }
        }

        private static void HandleHorseOwner()
        {
            bool x = true;
            while (x)
            {
                ShowHorseOwnerMenu();
                int horseOwnerOption = GetUserInput(5);

                switch (horseOwnerOption)
                {
                    case 1: Console.WriteLine("Enter horse"); break;
                    case 2: break;
                    case 3:
                        x = false;
                        //Console.Clear();
                        break;
                    default: break;
                }
                //break;
            }
        }

        private static void HandleRacegoer()
        {
            bool x = true;
            while (x)
            {
                ShowRacegoerMenu();
                int raceGoerOption = GetUserInput(3);

                switch (raceGoerOption)
                {
                    case 1: Console.WriteLine("1"); break;
                    case 2: Console.WriteLine("2"); break;
                    case 3:
                        Console.WriteLine("3");
                        x = false;
                        //Console.Clear();
                        break;
                    default: break;
                }
                //break;
            }
        }


        // Show menu methods
        private static void ShowMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("\nWhat kind of user are you?");
            Console.WriteLine("1 - Racecourse Manager");
            Console.WriteLine("2 - Horse Owner");
            Console.WriteLine("3 - Racegoer");
            Console.WriteLine("4 - Exit");
        }

        private static void ShowRacecourseManagerMenu()
        {
            Console.WriteLine("\nRacecourse Manager Menu: ");
            Console.WriteLine("\n1 - Show all race events");
            Console.WriteLine("2 - Create new race event");
            Console.WriteLine("3 - Show all races");
            Console.WriteLine("4 - Add race to a race event");
            Console.WriteLine("5 - Add horses to race");
            Console.WriteLine("6 - Go back");
        }

        private static void ShowHorseOwnerMenu()
        {
            Console.WriteLine("\nHorse Owner Menu: ");
            Console.WriteLine("\n1 - Enter horse in race");
            Console.WriteLine("2 - Show race events");
            Console.WriteLine("3 - Go back");
        }

        private static void ShowRacegoerMenu()
        {
            Console.WriteLine("Racegoer Menu: ");
            Console.WriteLine("\n1 - ");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - Go back");
        }

        private static void ShowAddRaceMenu()
        {
            Console.WriteLine("\nAdd Race Menu: ");
            Console.Write("Which race event do you want to add a race to (enter event number): ");
        }

        // Helper method for user input with validation
        private static int GetUserInput(int maxOption)
        {
            Console.Write($"\nEnter a number between 1 and {maxOption}: ");
            if (int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= maxOption)
            {
                return option;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetUserInput(maxOption);
            }
        }

        // Create methods
        public static void CreateNewRaceEvent(List<RaceEvent> raceEvents)
        {
            RaceEvent raceEvent = new RaceEvent("Aintree", new DateOnly(2024, 11, 4)); // Replace this with user entry
            raceEvents.Add(raceEvent);
        }

        public static void CreateNewRace(List<Race> races)
        {
            Race race = new Race("Race1", new TimeOnly(2, 00, 00));
            races.Add(race);
        }

        public static void CreateNewHorse(List<Horse> horses)
        {
            Horse horse = new Horse("Horse1", new DateOnly(2020, 5, 15));
            horses.Add(horse);
        }

        // Display methods

        public static void GetRaceEventsTable(List<RaceEvent> raceEvents)
        {
            string table = "\nRace Events Information:\n" +
                        "-------------------------------------------------------------------------\n" +
                        "| Event Number    | Location        | Number of Races | Date            |\n" +
                        "-------------------------------------------------------------------------\n";
            string noEvents = "There are currently no events created\n";
            if (raceEvents.Count == 0)
            {
                table += noEvents;
            }
            foreach (var raceEvent in raceEvents)
            {
                table += $"| {raceEvent.EventID,-15} | {raceEvent.Location,-15} | {raceEvent.Races.Count,-15} | {raceEvent.Date,-15} |\n";
            }
            table += "-------------------------------------------------------------------------";

            Console.WriteLine(table);
        }

        public static void GetRacesTable(List<RaceEvent> raceEvents)
        {
            foreach (var raceEvent in raceEvents)
            {
                Console.WriteLine(raceEvent);
            }
        }


    }
}
