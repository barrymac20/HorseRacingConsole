using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public enum Racecourse
    {
        Cork=1, Downpatrick, Dundalk, Galway, Fairyhouse, Gowran, Kilbeggan, Killarney, Laytown, Leopardstown, Listowel, Naas, Navan, Punchestown, Roscommon, Sligo, Tramore, Ballinrobe, Limerick, Bellewstown, Thurles, Clonmel, Downroyal, Tipperary, Curragh, Wexford
    }

    public class RaceEvent : IEvent
    {
        // Fields
        private static int _nextEventID = 1;
        //private RaceCourse _raceCourse;

        // Auto Properties
        public int EventID { get; set; }
        public Racecourse RaceCourse { get; set; }
        public int NumberOfRaces { get; set; }
        public DateOnly Date { get; set; }
        public List<Race> Races { get; set; }

        // Constructors
        public RaceEvent()
        {
            EventID = _nextEventID++;
            RaceCourse = Racecourse.Curragh;
            NumberOfRaces = 0;
            Date = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
            Races = new List<Race>();
        }

        public RaceEvent(Racecourse raceCourse, DateOnly date)
        {
            EventID = _nextEventID++;
            RaceCourse = raceCourse;
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

        public void AddRaceToEvent(Race race)
        {
            Races.Add(race);
        }

        // Override methods
        public override string ToString()
        {
            //     return $"\nRace Event Information:\n" +
            //$"---------------------------------------------------\n" +
            //$"| {"Name",-15} | {"Location",-15} | {"Number of Races",-15} | {"Date",-15} |\n" +
            //$"---------------------------------------------------\n" +
            //$"| {Name,-15} | {Location,-15} | {NumberOfRaces,-15} | {Date,-15} |\n" +
            //$"---------------------------------------------------";

            string table = $"\nRaces at the {RaceCourse} race meeting:\n" +
                        "-----------------------------------------------\n" +
                        "| Race ID | Race Name            | Start Time |\n" +
                        "-----------------------------------------------\n";
            string noRaces = "There are currently no races created\n";
            if (Races.Count == 0)
            {
                table += noRaces;
            }

            foreach (var race in Races)
            {
                table += $"| {race.RaceID,-7} | {race.RaceName,-20} | {race.StartTime,-10} |\n";
            }

            table += "-----------------------------------------------";

            return table;
        }
    }
}
