using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public class CreateEntities
    {
        public static RaceEvent CreateNewRaceEvent()
        {
            Racecourse racecourse = UserInput.GetRacecourseFromUser();
            DateOnly eventDate = UserInput.GetDateFromUser();

            RaceEvent raceEvent = new RaceEvent(racecourse, eventDate);
            return raceEvent;
        }
        public static Race CreateNewRace()
        {
            string raceName = UserInput.GetRaceNameFromUser();
            TimeOnly raceTime = UserInput.GetTimeFromUser();

            Race race = new Race(raceName, raceTime);
            return race;
        }
        public static Horse CreateNewHorse()
        {
            Horse horse = Horse.GetRandomHorse();
            return new Horse(horse.HorseName, horse.DateOfBirth);
        }
    }
}
