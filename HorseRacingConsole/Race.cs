﻿namespace HorseRacingConsole
{
    public class Race
    {
        // Static field for ID
        private static int _nextRaceID = 1;

        // Auto Properties
        public int RaceID { get; private set; }
        public string RaceName { get; set; }
        public TimeOnly StartTime { get; set; }
        public List<Horse> Horses { get; set; }

        // Constructors
        public Race()
        {
            RaceID = _nextRaceID++;
            RaceName = RaceNames.Names[1];
            StartTime = new TimeOnly(2, 14, 30);
            Horses = new List<Horse>();
        }
        public Race(string raceName, TimeOnly startTime)
        {
            RaceID = _nextRaceID++;
            RaceName = raceName;
            StartTime = startTime;
            Horses = new List<Horse>();
        }

        // Methods
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