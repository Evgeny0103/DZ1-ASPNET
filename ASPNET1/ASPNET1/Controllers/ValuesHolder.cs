using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET1.Controllers
{
    public class ValuesHolder
    {
        public List<WeatherForecast> Values { get; set; }
        public ValuesHolder()
        {
            Values = new List<WeatherForecast>();
        }
    }
}
