using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HorseRacingConsole
{
    public class Horse
    {



        // Static field
        private static int _nextHorseID = 1;
        private static List<Horse> horseNames;
        private static Random random = new Random();

        // Auto properties
        public string HorseName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int HorseID { get; private set; }// = 1;

        // Constructors
        static Horse()
        {
            LoadHorseInfo("horseNames.json");
            _nextHorseID = 1;
        }

        public Horse()
        {            
            HorseID = _nextHorseID++;
            HorseName = "";
            DateOfBirth = DateOnly.FromDateTime(DateTime.Now); //Use this for testing
        }

        public Horse(string horseName, DateOnly dateOfBirth)
        {
            HorseID = _nextHorseID++;
            HorseName = horseName;
            DateOfBirth = dateOfBirth;
        }

        // Methods
        public static void LoadHorseInfo(string filePath)
        {
            string json = File.ReadAllText(filePath);
            horseNames = JsonConvert.DeserializeObject<List<Horse>>(json);
        }


        public static Horse GetRandomHorse()
        {
            if (horseNames == null || horseNames.Count == 0)
            {
                Console.WriteLine("The list of horses is empty.");
                return null;
            }

            Random random = new Random();
            int index = random.Next(horseNames.Count);
            Horse horse = horseNames[index];
            horseNames.RemoveAt(index);
            return horse;
        }



        // Override methods
        public override string ToString()
        {
            return $"\nHorse Information:\nName: {HorseName}\nDate of Birth: {DateOfBirth}\nHorse ID: {HorseID}";
        }
    }
}
