using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        const string APPID = "1e8ed35d54d0446444c006631e9f4b6d";
        string cityName = "Osijek";
        public Form1()
        {
            InitializeComponent();
            getWeather("Osijek");
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", city, APPID);
                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherNowInfo>(json);

                WeatherNowInfo output = result;
                lbl_cityName.Text = string.Format("{0}, {1}", output.name, output.sys.country);
                lbl_Temperature.Text = string.Format("{0} \u00B0C", output.main.temp);
                lbl_Condition.Text = string.Format("{0}", output.Weather[0].description);
                lbl_Humidity.Text = string.Format("Humidity: {0} %", output.main.humidity);
                lbl_Pressure.Text = string.Format("Pressure: {0} hPa", output.main.pressure);
                lbl_Wind.Text = string.Format("Wind speed: {0} m/s", output.wind.speed);
                picture_now.Image = setIcon(output.Weather[0].icon);
                string coord_lon = string.Format("{0}", output.coord.lon);
                string coord_lat = string.Format("{0}", output.coord.lat);
                //Napraviti funkciju koja za taj isti grad prikazuje vrijeme za iduca 3 dana,
                //ali ti trebaju coordinate lon i lat
                getForecast(coord_lon, coord_lat);
                void getForecast(string coordLon, string coordLat)
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}&units=metric", coordLat, coordLon, APPID);
                    using (WebClient web = new WebClient())
                    {
                        var json = web.DownloadString(url);
                        var Object = JsonConvert.DeserializeObject<WeatherForecast>(json);
                        
                        WeatherForecast forecast = Object;
                        lbl_nameDay1.Text = string.Format("{0}", getDate(forecast.daily[1].dt).DayOfWeek);
                        lbl_condDay1.Text = string.Format("{0}", forecast.daily[1].weather[0].description);
                        lbl_tempDay1.Text = string.Format("{0} \u00B0C", forecast.daily[1].temp.day);
                        lbl_windDay1.Text = string.Format("Wind speed: {0} m/s", forecast.daily[1].wind_speed);
                        picture_day1.Image = setIcon(forecast.daily[1].weather[0].icon);

                        lbl_nameDay2.Text = string.Format("{0}", getDate(forecast.daily[2].dt).DayOfWeek);
                        lbl_condDay2.Text = string.Format("{0}", forecast.daily[2].weather[0].description);
                        lbl_tempDay2.Text = string.Format("{0} \u00B0C", forecast.daily[2].temp.day);
                        lbl_windDay2.Text = string.Format("Wind speed: {0} m/s", forecast.daily[2].wind_speed);
                        picture_day2.Image = setIcon(forecast.daily[2].weather[0].icon);

                        lbl_nameDay3.Text = string.Format("{0}", getDate(forecast.daily[3].dt).DayOfWeek);
                        lbl_condDay3.Text = string.Format("{0}", forecast.daily[3].weather[0].description);
                        lbl_tempDay3.Text = string.Format("{0} \u00B0C", forecast.daily[3].temp.day);
                        lbl_windDay3.Text = string.Format("Wind speed: {0} m/s", forecast.daily[3].wind_speed);
                        picture_day3.Image = setIcon(forecast.daily[3].weather[0].icon);
                    }
                }
            } 
        }
        DateTime getDate(double milisecond)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisecond).ToLocalTime();
            return day;
        }

        Image setIcon(string iconID)
        {
            string url = string.Format("http://openweathermap.org/img/w/{0}.png", iconID);
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var weatherIcon = response.GetResponseStream())
            {
                Image weatherImg = Bitmap.FromStream(weatherIcon);
                return weatherImg;
            }
        }
    }
}
