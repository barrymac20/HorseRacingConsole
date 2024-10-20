using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingConsole
{
    public class Weather
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Units current_units { get; set; }
        public Current current { get; set; }

        public override string ToString()
        {
            return $"Latitude{latitude}";
        }
    }
    
    public class Current_Units
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string precipitation { get; set; }
        public string weather_code { get; set; }
        public string wind_speed_10m { get; set; }
    }

    public class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public float temperature_2m { get; set; }
        public float precipitation { get; set; }
        public int weather_code { get; set; }
        public float wind_speed_10m { get; set; }

        public override string ToString()
        {
            return $"Time: {time}, Temperature: {temperature_2m}, Precipitation: {precipitation}, Weather Code: {weather_code}, Wind Speed: {wind_speed_10m}";
        }

    }

}
