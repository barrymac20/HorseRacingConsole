namespace HorseRacingConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<RaceEvent> raceEvents = new List<RaceEvent>();

            RaceEvent raceEvent1 = new RaceEvent("Event 1", "Ascot", 2, new DateOnly(2024, 10, 14));
            RaceEvent raceEvent2 = new RaceEvent("Event 2", "Epsom", 5, new DateOnly(2024, 11, 1));
            raceEvents.Add(raceEvent1);
            raceEvents.Add(raceEvent2);

            while (true)
            {
                Console.WriteLine("\nWhat kind of user are you?");
                Console.WriteLine("1 - Racecourse Manager");
                Console.WriteLine("2 - Horse Owner");
                Console.WriteLine("3 - Racegoer");
                Console.Write("Type the number of appropriate option and press enter: ");
                
                if (!int.TryParse(Console.ReadLine(), out int userType) || userType < 1 || userType > 3)
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue; // Ask for user type again
                }

                bool x = true;
                while (x)
                {
                    switch (userType)
                    {
                        case 1:
                            Console.WriteLine("\n1 - Create race event");
                            Console.WriteLine("2 - Add race to race event");
                            Console.WriteLine("3 - Add horses to race");
                            Console.WriteLine("4 - Show race events");
                            Console.WriteLine("5 - Go back");
                            Console.Write("Type the number of desired option and press enter: ");
                            if (!int.TryParse(Console.ReadLine(), out int managerOption) || managerOption < 1 || managerOption > 5)
                            {
                                Console.WriteLine("Invalid option. Please try again.");
                                continue; // Ask for manager option again
                            }
                            switch (managerOption)
                            {
                                case 1: AddToRaceEvents(raceEvents); ShowListOfEvents(raceEvents); break;
                                case 2: Console.WriteLine("22"); break;
                                case 3: Console.WriteLine("33"); break;
                                case 4: ShowListOfEvents(raceEvents); ; break;
                                case 5: x = false; break;
                                default: break;
                            }
                            break;
                        case 2: Console.WriteLine("Horse owner functionality"); break;
                        case 3: Console.WriteLine("Racegoer functionality"); break;
                        default: break;
                    }
                }
            }

            //Race race1 = new Race("Race1", new TimeOnly(2, 00, 00));
            //Race race2 = new Race("Race2", new TimeOnly(2, 30, 00));

            //raceEvent1.AddRaceToEvent(race1);
            //raceEvent1.AddRaceToEvent(race2);

            //foreach (Race race in raceEvent1.Races)
            //{
            //    Console.WriteLine(race);
            //}


            //Horse horse1 = new Horse("Horse1", new DateOnly(2020, 5, 15), 1);
            //Horse horse2 = new Horse("Horse2", new DateOnly(2018, 3, 1), 2);

            //race1.AddHorse(horse1);
            //race1.AddHorse(horse2);

            //foreach (Horse horse in race1.Horses)
            //{
            //    Console.WriteLine(horse);
            //}
        }

        public static RaceEvent CreateRaceEvent()
        {
            RaceEvent raceEvent = new RaceEvent("Event 3", "Aintree", 5, new DateOnly(2024, 11, 4));
            return raceEvent;
        }

        public static void AddToRaceEvents(List<RaceEvent> raceEvents)
        {
            raceEvents.Add(CreateRaceEvent());
        }

        public static void ShowListOfEvents(List<RaceEvent> raceEvents)
        {
            foreach (RaceEvent raceEvent in raceEvents)
            {
                Console.WriteLine(raceEvent);
            }
        }
    }
}
