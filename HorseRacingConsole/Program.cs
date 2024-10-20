using System;
using System.Collections.Generic;

namespace HorseRacingConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunHorseRacingApp();
            //RunAppWithStartingTestData();
        }

        public static void RunHorseRacingApp()
        {
            List<RaceEvent> raceEvents = new List<RaceEvent>();
            MenuHandling.HandleMainMenu(raceEvents);
        }

        public static void RunAppWithStartingTestData()
        { 
            TestData.StartingTestData();
        }
    }
}
