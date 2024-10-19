using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    internal class RacecourseManager
    {
        public List<RaceEvent> RaceEvents { get; set; }

        public RacecourseManager()
        {
            RaceEvents = new List<RaceEvent>();
        }

        // Methods

        public void AddRaceEvent(RaceEvent raceEvent)
        {
            RaceEvents.Add(raceEvent);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
