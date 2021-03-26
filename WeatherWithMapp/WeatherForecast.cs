using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWithMapp
{
    public class WeatherForecast
    {
        public List<daily> daily { get; set; }
    }

    public class temp
    {
        public double day { get; set; }
    }
    public class daily
    {
        public double dt { get; set; }//day in milliseconds
        public double wind_speed { get; set; }
        public temp temp { get; set; }
        public List<weather> weather { get; set; }
    }
}