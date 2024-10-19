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
        public string HorseName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int HorseID { get; set; }// = 1;

        // Constructors

        public Horse()
        {
            HorseID = _nextHorseID++;
            HorseName = "name";
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
        }

        public Horse(string horseName, DateOnly dateOfBirth)
        {
            HorseID = _nextHorseID++;
            HorseName = horseName;
            DateOfBirth = dateOfBirth;
        }

        // Override methods
        public override string ToString()
        {
            return $"\nHorse Information:\nName: {HorseName}\nDate of Birth: {DateOfBirth}\nHorse ID: {HorseID}";
        }
    }
}
