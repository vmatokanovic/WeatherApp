using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherNowInfo
    {
        public string name { get; set; }
        public sys sys { get; set; }
        public double dt { get; set; }
        public wind wind { get; set; }
        public main main { get; set; }
        public List<weather> Weather { get; set; }
        public coord coord { get; set; }
    }

        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }//kraj coord klase

        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }//kraj weather klase

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }//kraj main klase

        public class wind
        {
            public double speed { get; set; }
        }//kraj wind klase

        public class sys
        {
            public string country { get; set; }
        }//kraj sys klase
}