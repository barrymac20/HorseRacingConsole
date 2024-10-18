using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HorseRacingConsole
{
    public class Horse
    {
        // Static field
        private static int _nextHorseID = 1;
        // Auto properties
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int HorseID { get; set; }// = 1;

        // Constructors

        public Horse()
        {
            HorseID = _nextHorseID++;
            Name = "name";
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
        }

        public Horse(string name, DateOnly dateOfBirth)
        {
            HorseID = _nextHorseID++;
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        // Override methods
        public override string ToString()
        {
            return $"\nHorse Information:\nName: {Name}\nDate of Birth: {DateOfBirth}\nHorse ID: {HorseID}";
        }
    }
}
