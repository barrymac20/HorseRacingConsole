using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public class TestData
    {
        public static void StartingTestData()
        {
            List<RaceEvent> raceEvents = new List<RaceEvent>();
            RaceEvent raceEvent1 = new RaceEvent(Racecourse.Cork, new DateOnly(2024, 10, 14));
            RaceEvent raceEvent2 = new RaceEvent(Racecourse.Dundalk, new DateOnly(2024, 11, 1));
            raceEvents.Add(raceEvent1);
            raceEvents.Add(raceEvent2);

            Race race1 = new Race(RaceNames.Names[1], new TimeOnly(2, 00));
            Race race2 = new Race(RaceNames.Names[2], new TimeOnly(2, 30));
            raceEvent1.Races.Add(race1);
            raceEvent2.Races.Add(race2);

            Horse horse1 = CreateEntities.CreateNewHorse();
            Horse horse2 = CreateEntities.CreateNewHorse();
            race1.Horses.Add(horse1);
            race2.Horses.Add(horse2);

            MenuHandling.HandleMainMenu(raceEvents);
        }
    }
}
