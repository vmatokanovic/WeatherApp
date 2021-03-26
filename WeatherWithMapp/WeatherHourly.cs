using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWithMapp
{
    public class WeatherHourly
    {
        public List<hourly> hourly { get; set; }
    }

    public class hourly
    {
        public double temp { get; set; }
        public double wind_speed { get; set; }
        public List<weather> weather { get; set; }
    }
}
