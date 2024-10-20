using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace HorseRacingConsole
{
    internal class Program
    {
        
        
        private static void Main(string[] args)
        {
            //RunHorseRacingApp();

            Weather? weatherData = WeatherService.GetCurrentWeather();
            Current currentWeather = weatherData.current;
            Console.WriteLine(currentWeather);

        }

        public static void RunHorseRacingApp()
        {

            //RacecourseManager racecourseManager = new RacecourseManager();

            List<RaceEvent> raceEvents = new List<RaceEvent>();

            // For testing
            RaceEvent raceEvent1 = new RaceEvent(Racecourse.Cork, new DateOnly(2024, 10, 14));
            RaceEvent raceEvent2 = new RaceEvent(Racecourse.Dundalk, new DateOnly(2024, 11, 1));
            raceEvents.Add(raceEvent1);
            raceEvents.Add(raceEvent2);

            Race race1 = new Race(RaceNames.Names[1], new TimeOnly(2, 00));
            Race race2 = new Race(RaceNames.Names[2], new TimeOnly(2, 30));
            raceEvent1.Races.Add(race1);
            raceEvent2.Races.Add(race2);

            Horse horse1 = CreateNewHorse();
            Horse horse2 = CreateNewHorse();
            race1.Horses.Add(horse1);
            race2.Horses.Add(horse2);

            MainMenu(raceEvents);
        }

        // Menu methods
        private static void MainMenu(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowMainMenu();
                int userType = GetUserMenuInput(4);

                switch (userType)
                {
                    case 1: HandleRacecourseManager(raceEvents); break;
                    case 2: HandleHorseOwner(raceEvents); break;
                    case 3: HandleRacegoer(raceEvents); break;
                    case 4: return;
                    default: break;
                }
            }
        }

        private static void HandleRacecourseManager(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowRacecourseManagerMenu();
                int managerOption = GetUserMenuInput(7);

                switch (managerOption)
                {
                    case 1: // Show all race events");
                        ShowRaceEvents(raceEvents); break;
                    case 2: // Add new race event
                        AddRaceEvent(raceEvents, CreateNewRaceEvent());
                        ShowRaceEvents(raceEvents); break;
                    case 3: // Show all races
                        ShowRaceEvents(raceEvents);
                        Console.Write("Enter the relevant Event ID: ");

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
                    case 4: // Add race to a race event
                        ShowRaceEvents(raceEvents);
                        Console.Write("Enter the relevant Event ID: ");

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
                    case 5: // Add horses to a race
                        ShowRaceEvents(raceEvents);
                        Console.Write("Enter the relevant Event ID: ");

                        int userSelection5 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection5)
                            {
                                Console.WriteLine(raceEvent);
                                Console.Write("Enter the relevant Race ID: ");
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
                    case 6: // Go back
                        return;
                    default: break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private static void HandleHorseOwner(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowHorseOwnerMenu();
                int horseOwnerOption = GetUserMenuInput(2);

                switch (horseOwnerOption)
                {
                    case 1:
                        ShowRaceEvents(raceEvents);
                        Console.Write("Enter the relevant Event ID: ");

                        int userSelection5 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection5)
                            {
                                Console.WriteLine(raceEvent);
                                Console.Write("Enter the relevant Race ID: ");
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
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private static void HandleRacegoer(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowRacegoerMenu();
                int raceGoerOption = GetUserMenuInput(2);

                switch (raceGoerOption)
                {
                    case 1: // Show all
                        ShowRaceEvents(raceEvents);
                        Console.Write("Enter the relevant Event ID to see race info: ");

                        int userSelection11 = GetUserSelection();
                        foreach (var raceEvent in raceEvents)
                        {
                            if (raceEvent.EventID == userSelection11)
                            {
                                Console.WriteLine(raceEvent);
                                Console.Write("Enter the relevant Race ID to see horse info: ");
                                int userSelection111 = GetUserSelection();
                                foreach (var race in raceEvent.Races)
                                {
                                    if (race.RaceID == userSelection111)
                                    {
                                        Console.WriteLine(race);
                                        break;
                                    }
                                }
                                break;
                            }
                        }

                        




                        break;
                    case 2: // Go back
                        return;
                    default: break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
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
            Racecourse racecourse = GetRacecourseFromUser();
            DateOnly eventDate = GetDateFromUser();

            RaceEvent raceEvent = new RaceEvent(racecourse, eventDate);
            return raceEvent;
        }

        private static DateOnly GetDateFromUser()
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

        private static Racecourse GetRacecourseFromUser()
        {
            Console.WriteLine("Available race courses:\n");

            for (int i = 1; i < Enum.GetValues(typeof(Racecourse)).Length + 1; i++)
            {
                Console.WriteLine($"{i}\t{(Racecourse)i}");
            }

            Console.Write("\nEnter the corresponding number: ");
            Racecourse userInput = (Racecourse)int.Parse(Console.ReadLine());
            return userInput;

            //if (Enum.TryParse(userInput, out RaceCourse selectedCourse) && Enum.IsDefined(typeof(RaceCourse), selectedCourse))
            //{
            //    return selectedCourse;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Try again.");
            //    return GetRacecourseFromUser();
            //}
        }

        public static Race CreateNewRace()
        {
            string raceName = GetRaceNameFromUser();
            TimeOnly raceTime = GetTimeFromUser();

            Race race = new Race(raceName, raceTime);
            return race;
        }
        private static string GetRaceNameFromUser()
        {
            Console.WriteLine("Available race names:\n");

            //for (int i = 1; i < Race.RaceNames.Count + 1; i++)
            //{
            //    Console.WriteLine($"{Race.RaceNames[i]}\t{(RaceName)i}");
            //}

            foreach (var raceName in RaceNames.Names)
            {
                Console.WriteLine($"{raceName.Key}\t{raceName.Value}");
            }

            Console.Write("\nEnter the corresponding number: ");
            int userInput = int.Parse(Console.ReadLine());
            //Console.WriteLine(Race.RaceNames[userInput]);
            string race = RaceNames.Names[userInput];
            RaceNames.Names.Remove(userInput);
            return race;
        }

        private static TimeOnly GetTimeFromUser()
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


        public static Horse CreateNewHorse()
        {
            Horse horse = Horse.GetRandomHorse();
            return new Horse(horse.HorseName, horse.DateOfBirth);
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
