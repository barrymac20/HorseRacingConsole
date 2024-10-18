using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HorseRacingConsole
{
    public class Race
    {
        // Static field for ID
        private static int _nextRaceID = 1;

        // Auto Properties
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        public TimeOnly StartTime { get; set; }
        public List<Horse> Horses { get; set; }



        // Constructors
        public Race()
        {
            RaceID = _nextRaceID++; // = 1; - no need for this as using count of Races list to start ID
            RaceName = "Gold Cup";
            StartTime = new TimeOnly(2, 14, 30);
            Horses = new List<Horse>();
        }
        public Race(string raceName, TimeOnly startTime)
        {
            RaceID = _nextRaceID++; // 1; - no need for this as using count of Races list to start ID
            RaceName = raceName;
            StartTime = startTime;
            Horses = new List<Horse>();
        }

        // Methods

        public static void ShowListOfRaces(List<Race> races)
        {
            foreach (Race race in races)
            {
                Console.WriteLine(race);
            }
        }

        //public void AddHorse(Horse horse)
        //{
        //    Horses.Add(horse);
        //}

        

        // Override methods
        public override string ToString()
        {
            return $"\nRace Information:\nRace Name: {RaceName}\nStart Time: {StartTime}";
        }
    }
}
