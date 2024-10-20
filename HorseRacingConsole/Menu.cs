namespace HorseRacingConsole
{
    public static class Menu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("\nWhat kind of user are you?");
            Console.WriteLine("1 - Racecourse Manager");
            Console.WriteLine("2 - Horse Owner");
            Console.WriteLine("3 - Racegoer");
            Console.WriteLine("4 - Check current weather at racecourse location");
            Console.WriteLine("5 - Exit");
        }

        public static void ShowRacecourseManagerMenu()
        {
            Console.WriteLine("Racecourse Manager Menu: ");
            Console.WriteLine("\n1 - Show race events");
            Console.WriteLine("2 - Add new race event");
            Console.WriteLine("3 - Show races");
            Console.WriteLine("4 - Add race to a race event");
            Console.WriteLine("5 - Show horses");
            Console.WriteLine("6 - Add random horse to a race");
            Console.WriteLine("7 - Go back");
        }

        public static void ShowHorseOwnerMenu()
        {
            Console.WriteLine("Horse Owner Menu: ");
            Console.WriteLine("\n1 - Enter random horse in race");
            Console.WriteLine("2 - Go back");
        }

        public static void ShowRacegoerMenu()
        {
            Console.WriteLine("Racegoer Menu: ");
            Console.WriteLine("\n1 - Show race event, race, and horse information");
            Console.WriteLine("2 - Go back");
        }

        public static void ShowAddRaceMenu()
        {
            Console.WriteLine("Add Race Menu: ");
            Console.Write("Which race event do you want to add a race to (enter event number): ");
        }
    }
}
