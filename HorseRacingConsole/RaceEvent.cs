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

        //// Fields
        //private string _name;
        //private string _location;
        //private int _numberOfRaces;

        //// Properties
        //public string Name { get => _name; set => _name = value; }
        //public string Location { get => _location; set => _location = value; }
        //public int NumberOfRaces { get => _numberOfRaces; set => _numberOfRaces = value; }

        // Constructors
        public RaceEvent()
        { 
            Name = "";
            Location = "";
            NumberOfRaces = 1;
            Date = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
        }

        public RaceEvent(string name, string location, int numberOfRaces, DateOnly date)
        {
            Name = name;
            Location = location;
            NumberOfRaces = numberOfRaces;
            Date = date;
        }

        // Override methods
        public override string ToString()
        {
            return $"\nRace Event Information:\nName: {Name}\nLocation: {Location}\nNumber of Races: {NumberOfRaces}\nDate: {Date}";
        }

    }
}
