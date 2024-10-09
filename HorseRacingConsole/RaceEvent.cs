using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public class RaceEvent
    {
        // Auto Properties
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfRaces { get; set; }
        public DateOnly Date { get; set; }
        public List<Race> Races { get; set; }

        // Constructors
        public RaceEvent()
        { 
            Name = "";
            Location = "";
            NumberOfRaces = 1;
            Date = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
            Races = new List<Race>();
        }

        public RaceEvent(string name, string location, int numberOfRaces, DateOnly date)
        {
            Name = name;
            Location = location;
            NumberOfRaces = numberOfRaces;
            Date = date;
            Races = new List<Race>();
        }

        // Methods

        public void AddRaceToEvent(Race newRace)
        {
            Races.Add(newRace);
        }

        // Override methods
        public override string ToString()
        {
            return $"\nRace Event Information:\nName: {Name}\nLocation: {Location}\nNumber of Races: {NumberOfRaces}\nDate: {Date}";
        }

    }
}
