namespace HorseRacingConsole
{
    public enum Racecourse
    {
        Cork=1, Downpatrick, Dundalk, Galway, Fairyhouse, Gowran, Kilbeggan, Killarney, Laytown, Leopardstown, Listowel, Naas, Navan, Punchestown, Roscommon, Sligo, Tramore, Ballinrobe, Limerick, Bellewstown, Thurles, Clonmel, Downroyal, Tipperary, Curragh, Wexford
    }

    public class RaceEvent : Event
    {
        // Auto Properties
        public Racecourse RaceCourse { get; set; }
        public int NumberOfRaces { get; set; }
        public List<Race> Races { get; set; }

        // Constructors
        public RaceEvent(Racecourse raceCourse, DateOnly date) : base(date)
        {
            RaceCourse = raceCourse;
            NumberOfRaces = 0;
            Races = new List<Race>();
        }

        // Methods

        public void AddRaceToRaceEvent(Race race)
        {
            Races.Add(race);
        }

        // Override methods
        public override string ToString()
        {
            string table = $"\nRaces at the {RaceCourse} race meeting:\n" +
                        "----------------------------------------------------\n" +
                        "| Race ID | Race Name                 | Start Time |\n" +
                        "----------------------------------------------------\n";
            string noRaces = "There are currently no races created\n";
            if (Races.Count == 0)
            {
                table += noRaces;
            }

            foreach (var race in Races)
            {
                table += $"| {race.RaceID,-7} | {race.RaceName,-25} | {race.StartTime,-10} |\n";
            }

            table += "----------------------------------------------------";

            return table;
        }
    }
}
