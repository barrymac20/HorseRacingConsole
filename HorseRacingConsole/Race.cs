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
        public static Dictionary<int, string> RaceNames { get; private set; } = new Dictionary<int, string>
    {
        {1, "Championship Stakes"},
        {2, "Summer Sprint"},
        {3, "Classic Derby"},
        {4, "Autumn Challenge"},
        {5, "Speed Cup"},
        {6, "Winter Wonderland Race"},
        {7, "Majestic Mile"},
        {8, "Starlight Stakes"},
        {9, "Rising Star Derby"},
        {10, "Emerald Sprint"},
        {11, "Great Race"},
        {12, "Sunshine Stakes"},
        {13, "Fast Track Challenge"},
        {14, "Golden Trophy"},
        {15, "Victory Lap"},
        {16, "Mountain View Stakes"},
        {17, "Thunder Race"},
        {18, "Horizon Cup"},
        {19, "Windy City Derby"},
        {20, "Legends Race"}
    };



        // Static field for ID
        private static int _nextRaceID = 1;

        // Auto Properties
        public int RaceID { get; set; }
        //public RaceName RaceName { get; set; }
        public string RaceName { get; set; }
        public TimeOnly StartTime { get; set; }
        public List<Horse> Horses { get; set; }



        // Constructors
        public Race()
        {
            RaceID = _nextRaceID++; // = 1; - no need for this as using count of Races list to start ID
            RaceName = RaceNames[1];
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

        public void AddHorseToRace(Horse horse)
        {
            Horses.Add(horse);
        }

        // Override methods
        public override string ToString()
        {
            string table = $"\nHorses in race {RaceName}:\n" +
                            "---------------------------------------------------\n" +
                            "| Horse ID | Horse Name           | Date of Birth |\n" +
                            "---------------------------------------------------\n";
            string noHorses = "There are currently no horses entered in this race!\n";
            if (Horses.Count == 0)
            {
                table += noHorses;
            }

            foreach (var horse in Horses)
            {
                table += $"| {horse.HorseID,-8} | {horse.HorseName,-20} | {horse.DateOfBirth,-13} |\n";
            }

            table += "---------------------------------------------------";

            return table;
        }
    }
}