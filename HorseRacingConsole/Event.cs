using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public abstract class Event
    {
        // Fields
        private static int _nextEventID = 1;

        // Auto Properties
        public int EventID { get; private set; }
        public DateOnly Date { get; set; }

        // Constructor
        public Event(DateOnly date)
        {
            EventID = _nextEventID++;
            Date = date;
        }
    }
}
