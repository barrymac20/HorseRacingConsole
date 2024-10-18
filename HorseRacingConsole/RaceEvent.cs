using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public class RaceEvent : IEvent
    {
        // Static field for ID
        private static int _nextEventID = 1;

        // Auto Properties
        public int EventID { get; set; }
        public string Location { get; set; }
        public int NumberOfRaces { get; set; }
        public DateOnly Date { get; set; }
        public List<Race> Races { get; set; }

        // Constructors
        public RaceEvent()
        {
            EventID = _nextEventID++;
            Location = "";
            NumberOfRaces = 0;
            Date = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
            Races = new List<Race>();
        }

        public RaceEvent(string location, DateOnly date)
        {
            EventID = _nextEventID++;
            Location = location;
            NumberOfRaces = 0;
            Date = date;
            Races = new List<Race>();
        }

        // Methods

        public static void ShowListOfEvents(List<RaceEvent> raceEvents)
        {
            foreach (RaceEvent raceEvent in raceEvents)
            {
                Console.WriteLine(raceEvent);
            }
        }

        //public Race AddRaceToEvent(Race newRace)
        //{
        //    Races.Add(newRace);
        //    return newRace;
        //}

        // Override methods
        public override string ToString()
        {
            //     return $"\nRace Event Information:\n" +
            //$"---------------------------------------------------\n" +
            //$"| {"Name",-15} | {"Location",-15} | {"Number of Races",-15} | {"Date",-15} |\n" +
            //$"---------------------------------------------------\n" +
            //$"| {Name,-15} | {Location,-15} | {NumberOfRaces,-15} | {Date,-15} |\n" +
            //$"---------------------------------------------------";

            // Create the table header
            string table = $"\nRaces in event {EventID}, {Location}:\n" +
                        "---------------------------------------------------\n" +
                        "| Race Number | Race Name            | Start Time |\n" +
                        "---------------------------------------------------\n";
            string noRaces = "There are currently no races created\n";
            if (Races.Count == 0)
            {
                table += noRaces;
            }
            // Loop through each Race and add it to the table
            
            foreach (var race in Races)
            {
                table += $"| {race.RaceID,-11} | {race.RaceName,-20} | {race.StartTime,-10} |\n";
            }

            // Add the closing line
            table += "---------------------------------------------------";

            return table;
        }
    }
}
