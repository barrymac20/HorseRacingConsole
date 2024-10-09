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
        private string _raceName;
        private TimeOnly _startTime;
        private List<Horse> _horses;

        // Properties
        public string RaceName { get => _raceName; set => _raceName = value; }
        public TimeOnly StartTime { get => _startTime; set => _startTime = value; }
        public List<Horse> Horses { get => _horses; set => _horses = value; }

        // Constructors
        public Race() 
        {
            RaceName = "Test";
            StartTime = new TimeOnly(2, 14, 30);
            Horses = new List<Horse>();
        }
        public Race(string raceName, TimeOnly startTime)
        {
            RaceName = raceName;
            StartTime = startTime;
            Horses = new List<Horse>();
        }

        // Add horse to list
        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);
        }

        // Override methods
        public override string ToString()
        {
            return $"\nRace Information:\nRace Name: {RaceName}\nStart Time: {StartTime}";
        }
    }
}
