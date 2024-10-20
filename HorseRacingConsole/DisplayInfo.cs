using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    class DisplayInfo
    {
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

        public static void ShowAllRaces(List<RaceEvent> raceEvents)
        {
            ShowRaceEvents(raceEvents);
            Console.Write("Enter the relevant Event ID: ");

            int userSelection3 = UserInput.GetUserSelection();
            foreach (var raceEvent in raceEvents)
            {
                if (raceEvent.EventID == userSelection3)
                {
                    Console.WriteLine(raceEvent);
                    break;
                }
            }
        }

        public static void ShowAllInfo(List<RaceEvent> raceEvents)
        {
            ShowRaceEvents(raceEvents);
            Console.Write("Enter the relevant Event ID to see race info: ");

            int userSelection11 = UserInput.GetUserSelection();
            foreach (var raceEvent in raceEvents)
            {
                if (raceEvent.EventID == userSelection11)
                {
                    Console.WriteLine(raceEvent);
                    Console.Write("Enter the relevant Race ID to see horse info: ");
                    int userSelection111 = UserInput.GetUserSelection();
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
        }

        public static void DisplayWeather()
        {
            Console.Clear();
            Console.WriteLine("Display weather in one of these race locations:/n");
            Racecourse racecourse = UserInput.GetRacecourseFromUser();
            var coordinates = WeatherService.GetCoordinates(racecourse);
            WeatherService weatherService = new WeatherService(coordinates.Value.Latitude, coordinates.Value.Longitude);
            Weather weather = weatherService.GetCurrentWeather();
            Console.WriteLine($"\nThe weather in {racecourse}:\n");
            Console.WriteLine(weather.current);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
