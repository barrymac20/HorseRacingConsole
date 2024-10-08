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
        
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int HorseID { get; set; }// = 1;

        // Constructors

        public Horse()
        {
            Name = "name";
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
            HorseID = 1;
        }

        public Horse(string name, DateOnly dateOfBirth, int horseID)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            HorseID = horseID;
        }

        // Override methods
        public override string ToString()
        {
            return $"\nHorse Information:\nName: {Name}\nDate of Birth: {DateOfBirth}\nHorse ID: {HorseID}";
        }
    }
}
