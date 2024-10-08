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
        // Fields
        private TimeOnly _startTime;
        private int _raceID;
        private string _raceName;
        private List<Horse> _horses = new List<Horse>();

        // Properties
        public TimeOnly StartTime { get => _startTime; set => _startTime = value; }
        public int RaceID { get => _raceID; set => _raceID = value; }
        public string RaceName { get => _raceName; set => _raceName = value; }
        public List<Horse> Horses { get => _horses; set => _horses = value; }

        // Constructors
        public Race() 
        {
            StartTime = new TimeOnly(2, 14, 30);
            RaceID = 1;
        }
        public Race(TimeOnly startTime, int raceID)
        {
            StartTime = startTime;
            RaceID = raceID;
        }

        // Add horse to list
        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);
        }

        // Override methods
        public override string ToString()
        {
            return $"\nRace Information:\nStart Time: {StartTime}\nRace ID: {RaceID}";
        }
    }
}
