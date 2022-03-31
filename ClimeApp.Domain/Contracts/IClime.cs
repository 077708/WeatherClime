using ClimeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimeApp.Domain.Contracts
{
    public interface IClime
    {
        List<WeatherClimeDao> GetWeather(string txt);
    }
}
