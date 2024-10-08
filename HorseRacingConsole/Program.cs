namespace HorseRacingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaceEvent raceEvent = new RaceEvent();
            Console.WriteLine(raceEvent);

            Race race = new Race();
            Console.WriteLine(race);

            Horse horse = new Horse();
            Console.WriteLine(horse);
        }
    }
}
