using ClimeApp.Domain.Contracts;
using ClimeApp.Domain.Entities;
using ClimeDao.AppCore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimeDao.AppCore.Services
{
    public class ClimeServices : IClimeServices
    {
        private IClime clime;

        public ClimeServices(IClime clime)
        {
            this.clime = clime;
        }

        public List<WeatherClimeDao> weatherClimeDao(string txt)
        {
            return clime.GetWeather(txt);
        }
    }
}
