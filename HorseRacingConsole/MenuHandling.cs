using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    internal class MenuHandling
    {
        public static void HandleMainMenu(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowMainMenu();
                int userType = UserInput.GetUserMenuInput(5);

                switch (userType)
                {
                    case 1: HandleRacecourseManager(raceEvents); break;
                    case 2: HandleHorseOwner(raceEvents); break;
                    case 3: HandleRacegoer(raceEvents); break;
                    case 4: DisplayInfo.DisplayWeather(); break;
                    case 5: return;
                    default: break;
                }
            }
        }

        public static void HandleRacecourseManager(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowRacecourseManagerMenu();
                int managerOption = UserInput.GetUserMenuInput(7);

                switch (managerOption)
                {
                    case 1: // Show all race events");
                        DisplayInfo.ShowRaceEvents(raceEvents); break;
                    case 2: // Add new race event
                        AddEntities.AddRaceEvent(raceEvents, CreateEntities.CreateNewRaceEvent());
                        DisplayInfo.ShowRaceEvents(raceEvents); break;
                    case 3: // Show all races
                        DisplayInfo.ShowAllRaces(raceEvents);
                        break;
                    case 4: // Add race to a race event
                        AddEntities.AddRaceToRaceEvent(raceEvents);
                        break;
                    case 5: // Show all
                        DisplayInfo.ShowAllInfo(raceEvents);
                        break;
                    case 6: // Add horses to a race
                        AddEntities.AddHorseToRace(raceEvents, "race course manager");
                        break;
                    case 7: // Go back
                        return;
                    default: break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        public static void HandleHorseOwner(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowHorseOwnerMenu();
                int horseOwnerOption = UserInput.GetUserMenuInput(2);

                switch (horseOwnerOption)
                {
                    case 1:
                        AddEntities.AddHorseToRace(raceEvents, "horse owner");
                        break;
                    case 2: return; ;
                    default: break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        public static void HandleRacegoer(List<RaceEvent> raceEvents)
        {
            while (true)
            {
                Console.Clear();
                Menu.ShowRacegoerMenu();
                int raceGoerOption = UserInput.GetUserMenuInput(2);

                switch (raceGoerOption)
                {
                    case 1: // Show all
                        DisplayInfo.ShowAllInfo(raceEvents);
                        break;
                    case 2: // Go back
                        return;
                    default: break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
