using System.Collections.Generic;
using System.Diagnostics;
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

            //RacecourseManager racecourseManager = new RacecourseManager();

            List<RaceEvent> raceEvents = new List<RaceEvent>();
            // For testing
            RaceEvent raceEvent1 = new RaceEvent(RaceCourse.Cork, new DateOnly(2024, 10, 14));
            RaceEvent raceEvent2 = new RaceEvent(RaceCourse.Dundalk, new DateOnly(2024, 11, 1));
            //racecourseManager.RaceEvents.Add(raceEvent1);
            //racecourseManager.RaceEvents.Add(raceEvent2);
            raceEvents.Add(raceEvent1);
            raceEvents.Add(raceEvent2);

            Race race1 = new Race("Race1", new TimeOnly(2, 00, 00));
            Race race2 = new Race("Race2", new TimeOnly(2, 00, 00));
            raceEvent1.Races.Add(race1);
            raceEvent2.Races.Add(race2);

            Horse horse1 = new Horse();
            Horse horse2 = new Horse();
            race1.Horses.Add(horse1);
            race2.Horses.Add(horse2);

            //Console.WriteLine(raceEvents.IndexOf(raceEvent1.EventID));



            MainMenu(raceEvents);
        }

        // Menu methods
        private static void MainMenu(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                ShowMainMenu();
                int userType = GetUserMenuInput(4);

                switch (userType)
                {
                    case 1: HandleRacecourseManager(raceEvents); break;
                    case 2: HandleHorseOwner(raceEvents); break;
                    case 3: HandleRacegoer(); break;
                    case 4: return;
                    default: break;
                }
            }
        }

        private static void HandleRacecourseManager(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                ShowRacecourseManagerMenu();
                int managerOption = GetUserMenuInput(6);

                switch (managerOption)
                {
                    case 1:
                        ShowRaceEvents(raceEvents); break;
                    case 2:
                        AddRaceEvent(raceEvents, CreateNewRaceEvent());
                        ShowRaceEvents(raceEvents); break;
                    case 3:
                        ShowRaceEvents(raceEvents);
                        Console.Write("Enter Event ID to see its races: ");

                        int userSelection3 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection3)
                            {
                                Console.WriteLine(raceEvent);
                                break;
                            }
                        }
                        break;
                    case 4:
                        ShowRaceEvents(raceEvents);
                        Console.Write("Type Event ID to see its races: ");

                        int userSelection4 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection4)
                            {
                                raceEvent.AddRaceToEvent(CreateNewRace());
                                Console.WriteLine(raceEvent);
                                break;
                            }
                        }
                        break;
                    case 5:
                        ShowRaceEvents(raceEvents);
                        Console.Write("Type Event ID to see its races: ");

                        int userSelection5 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection5)
                            {
                                Console.WriteLine(raceEvent);
                                Console.Write("Type Race ID to add a horse: ");
                                int userSelection55 = GetUserSelection();
                                foreach (var race in raceEvent.Races)
                                {
                                    if (race.RaceID == userSelection55)
                                    {
                                        race.AddHorseToRace(CreateNewHorse());
                                        Console.WriteLine(race);
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    case 6:
                        return;
                    default: break;
                }
            }
        }

        private static void HandleHorseOwner(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                ShowHorseOwnerMenu();
                int horseOwnerOption = GetUserMenuInput(5);

                switch (horseOwnerOption)
                {
                    case 1:
                        ShowRaceEvents(raceEvents);
                        Console.Write("Type Event ID to see its races: ");

                        int userSelection5 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection5)
                            {
                                Console.WriteLine(raceEvent);
                                Console.Write("Type Race ID to add a horse: ");
                                int userSelection55 = GetUserSelection();
                                foreach (var race in raceEvent.Races)
                                {
                                    if (race.RaceID == userSelection55)
                                    {
                                        race.AddHorseToRace(CreateNewHorse());
                                        Console.WriteLine(race);
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    case 2: break;
                    case 3:
                        //Console.Clear();
                        return;
                    default: break;
                }
                //break;
            }
        }

        private static void HandleRacegoer()
        {
            while (true)
            {
                ShowRacegoerMenu();
                int raceGoerOption = GetUserMenuInput(3);

                switch (raceGoerOption)
                {
                    case 1: Console.WriteLine("1"); break;
                    case 2: Console.WriteLine("2"); break;
                    case 3:
                        Console.WriteLine("3");
                        //Console.Clear();
                        return;
                    default: break;
                }
                //break;
            }
        }


        // Show menu methods
        private static void ShowMainMenu()
        {
            //Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("\nWhat kind of user are you?");
            Console.WriteLine("1 - Racecourse Manager");
            Console.WriteLine("2 - Horse Owner");
            Console.WriteLine("3 - Racegoer");
            Console.WriteLine("4 - Exit");
        }

        private static void ShowRacecourseManagerMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nRacecourse Manager Menu: ");
            Console.WriteLine("\n1 - Show all race events");
            Console.WriteLine("2 - Add new race event");
            Console.WriteLine("3 - Show all races");
            Console.WriteLine("4 - Add race to a race event");
            Console.WriteLine("5 - Add horses to a race");
            Console.WriteLine("6 - Go back");
        }

        private static void ShowHorseOwnerMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nHorse Owner Menu: ");
            Console.WriteLine("\n1 - Enter horse in race");
            Console.WriteLine("2 - Show race events");
            Console.WriteLine("3 - Go back");
        }

        private static void ShowRacegoerMenu()
        {
            //Console.Clear();
            Console.WriteLine("Racegoer Menu: ");
            Console.WriteLine("\n1 - ");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - Go back");
        }

        private static void ShowAddRaceMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nAdd Race Menu: ");
            Console.Write("Which race event do you want to add a race to (enter event number): ");
        }

        // Helper method for user input with validation
        private static int GetUserMenuInput(int maxOption)
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

        private static int GetUserSelection()
        {
            //Console.Write($"\nEnter ID: ");
            if (int.TryParse(Console.ReadLine(), out int option))// && option >= 1 && option <= maxOption)
            {
                //Console.WriteLine("Success");
                return option;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetUserSelection();
            }
        }

        // Create methods

        public static void AddRaceEvent(List<RaceEvent> raceEvents, RaceEvent raceEvent)
        {
            raceEvents.Add(raceEvent);
        }


        public static RaceEvent CreateNewRaceEvent()
        {
            RaceEvent raceEvent = new RaceEvent(RaceCourse.Naas, new DateOnly(2024, 11, 4)); // Replace this with user entry
            return raceEvent;
        }

        public static Race CreateNewRace()
        {
            Race race = new Race("Race1", new TimeOnly(2, 00, 00));
            return race;
        }

        public static Horse CreateNewHorse()
        {
            Horse horse = new Horse("Horse10", new DateOnly(2020, 5, 15));
            return horse;
        }

        // Display methods

        public static void ShowRaceEvents(List<RaceEvent> raceEvents)
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
                table += $"| {raceEvent.EventID,-15} | {raceEvent.RaceCourse,-15} | {raceEvent.Races.Count,-15} | {raceEvent.Date,-15} |\n";
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
