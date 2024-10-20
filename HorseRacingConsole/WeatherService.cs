using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace HorseRacingConsole
{
    public class WeatherService
    {

        public static readonly string Weather_URL = $"https://api.open-meteo.com/v1/forecast?latitude={Latitude}&longitude={Longitude}&current=temperature_2m,precipitation,weather_code,wind_speed_10m&models=ukmo_seamless";
        public static double Latitude { get; private set; }
        public static double Longitude { get; private set; }

        public static Weather? GetCurrentWeather()
        {
            var client = new RestClient(Weather_URL);
            var request = new RestRequest();
            var response = client.Execute(request);
            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                string receivedJSON = response.Content;
                Weather? weather = JsonConvert.DeserializeObject<Weather>(receivedJSON);

                return weather;
            }
            return null;
        }

        // Got this information from open-meteo.com
        private static (double Latitude, double Longitude)? GetCoordinates(Racecourse racecourse)
        {
            return racecourse switch
            {
                Racecourse.Cork => (51.8985, -8.4756),
                Racecourse.Downpatrick => (54.3661, -5.7160),
                Racecourse.Dundalk => (54.0022, -6.3934),
                Racecourse.Galway => (53.2709, -9.0569),
                Racecourse.Fairyhouse => (53.6050, -6.5278),
                Racecourse.Gowran => (52.6544, -7.2571),
                Racecourse.Kilbeggan => (53.4031, -7.4305),
                Racecourse.Killarney => (52.0586, -9.5084),
                Racecourse.Laytown => (53.6767, -6.2761),
                Racecourse.Leopardstown => (53.2844, -6.2042),
                Racecourse.Listowel => (52.4695, -9.4674),
                Racecourse.Naas => (53.2113, -6.6043),
                Racecourse.Navan => (53.5894, -6.6882),
                Racecourse.Punchestown => (53.1862, -6.6822),
                Racecourse.Roscommon => (53.5908, -8.2065),
                Racecourse.Sligo => (54.2700, -8.4766),
                Racecourse.Tramore => (52.1583, -7.1397),
                Racecourse.Ballinrobe => (53.5960, -9.2394),
                Racecourse.Limerick => (52.6634, -8.6267),
                Racecourse.Bellewstown => (53.6961, -6.3711),
                Racecourse.Thurles => (52.6793, -7.7991),
                Racecourse.Clonmel => (52.3581, -7.7128),
                Racecourse.Downroyal => (54.3765, -6.5636),
                Racecourse.Tipperary => (52.5040, -7.8148),
                Racecourse.Curragh => (53.1160, -6.7476),
                Racecourse.Wexford => (52.3358, -6.4665),
                _ => null
            };
        }

    }
}
