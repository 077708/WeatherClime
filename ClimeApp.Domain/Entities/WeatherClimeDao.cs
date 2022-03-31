using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimeApp.Domain.Entities
{
    public class WeatherClimeDao
    {
        public long Lon { get; set; }
        public long Lat { get; set; }
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public double Feels_min { get; set; }
        public double Temp_max { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public int Type { get; set; }
        public double Message { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double speed { get; set; }
        public int Deg { get; set; }
    }
}
