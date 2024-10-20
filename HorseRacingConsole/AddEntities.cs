using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    internal class AddEntities
    {
        public static void AddRaceEvent(List<RaceEvent> raceEvents, RaceEvent raceEvent)
        {
            raceEvents.Add(raceEvent);
        }

        public static void AddRaceToRaceEvent(List<RaceEvent> raceEvents)
        {
            DisplayInfo.ShowRaceEvents(raceEvents);
            Console.Write("Enter the relevant Event ID: ");

            int userSelection4 = UserInput.GetUserSelection();
            foreach (var raceEvent in raceEvents)
            {
                if (raceEvent.EventID == userSelection4)
                {
                    raceEvent.AddRaceToRaceEvent(CreateEntities.CreateNewRace());
                    Console.WriteLine(raceEvent);
                    break;
                }
            }
        }

        public static void AddHorseToRace(List<RaceEvent> raceEvents, string user)
        {
            DisplayInfo.ShowRaceEvents(raceEvents);
            Console.Write("Enter the relevant Event ID: ");

            int eventSelected = UserInput.GetUserSelection();
            foreach (var raceEvent in raceEvents)
            {
                if (raceEvent.EventID == eventSelected)
                {
                    Console.WriteLine(raceEvent);
                    Console.Write("Enter the relevant Race ID: ");
                    int raceSelected = UserInput.GetUserSelection();

                    foreach (var race in raceEvent.Races)
                    {
                        if (race.RaceID == raceSelected)
                        {
                            Horse horse = CreateEntities.CreateNewHorse();
                            race.AddHorseToRace(horse);
                            Console.Write($"\n{horse.HorseName} was added to the race by the {user}\n");
                            Console.WriteLine(race);
                            break;
                        }
                    }
                }
            }
        }
    }
}
