using ClimeApp.Domain.Contracts;
using ClimeApp.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClimeApp.DataAccess.Repositories
{
    public class ClimeModel : IClime
    {
        private const string key = "407fbde93f7e3f7005d1f94c1b5190c6";
        public List<WeatherClimeDao> GetWeather(string txt)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", txt, key);
                    var json = web.DownloadString(url);

                    ClimeRoot data = JsonConvert.DeserializeObject<ClimeRoot>(json);

                    List<WeatherClimeDao> list = new List<WeatherClimeDao>()
                    {
                        new WeatherClimeDao()
                        {
                            Lon = data.Coord.Lon,
                            Lat = data.Coord.Lat,
                            Temp = data.Main.Temp,
                            Feels_like = data.Main.Feels_like,
                            Feels_min = data.Main.Feels_min,
                            Temp_max = data.Main.Temp_max,
                            Pressure = data.Main.Pressure,
                            Humidity = data.Main.Humidity,
                            Type = data.Sys.Type,
                            Message = data.Sys.Message,
                            Country = data.Sys.Country,
                            Sunrise = data.Sys.Sunrise,
                            Sunset = data.Sys.Sunset,
                            Main = data.weather[0].Main,
                            Description = data.weather[0].Description,
                            Icon = data.weather[0].Icon,
                            speed = data.Wind.speed,
                            Deg = data.Wind.Deg,
                        }
                    };

                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}