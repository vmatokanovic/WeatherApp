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
using System.IO;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace WeatherWithMapp
{
    public partial class Form1 : Form
    {
        const string APPID = "1e8ed35d54d0446444c006631e9f4b6d";
        public Form1()
        {
            InitializeComponent();
            getWeather("Osijek");
            getRecent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
            showMap();
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
                lbl_Temperature.Text = string.Format("{0:F0} \u00B0C", output.main.temp);
                lbl_Condition.Text = string.Format("{0}", output.Weather[0].description);
                lbl_Humidity.Text = string.Format("Humidity: {0} %", output.main.humidity);
                lbl_Pressure.Text = string.Format("Pressure: {0} hPa", output.main.pressure);
                lbl_Wind.Text = string.Format("Wind speed: {0} m/s", output.wind.speed);
                picture_now.Image = setIcon(output.Weather[0].icon);
                string coord_lon = string.Format("{0}", output.coord.lon);
                string coord_lat = string.Format("{0}", output.coord.lat);
                using (StreamWriter str = new StreamWriter("coordinates.txt"))
                {
                    str.WriteLine(coord_lon);
                    str.WriteLine(coord_lat);
                }
                //Napraviti funkciju koja za taj isti grad prikazuje vrijeme za iduca 3 dana,
                //ali ti trebaju coordinate lon i lat
                getForecast(coord_lon, coord_lat);
                getHourly(coord_lon, coord_lat);
                void getForecast(string coordLon, string coordLat)
                {
                    string url1 = string.Format("http://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}&units=metric", coordLat, coordLon, APPID);
                    using (WebClient web1 = new WebClient())
                    {
                        var json1 = web1.DownloadString(url1);
                        var Object = JsonConvert.DeserializeObject<WeatherForecast>(json1);

                        WeatherForecast forecast = Object;
                        lbl_nameDay1.Text = string.Format("{0}", getDate(forecast.daily[1].dt).DayOfWeek);
                        lbl_condDay1.Text = string.Format("{0}", forecast.daily[1].weather[0].description);
                        lbl_tempDay1.Text = string.Format("{0:F0} \u00B0C", forecast.daily[1].temp.day);
                        lbl_windDay1.Text = string.Format("Wind speed: {0} m/s", forecast.daily[1].wind_speed);
                        picture_day1.Image = setIcon(forecast.daily[1].weather[0].icon);

                        lbl_nameDay2.Text = string.Format("{0}", getDate(forecast.daily[2].dt).DayOfWeek);
                        lbl_condDay2.Text = string.Format("{0}", forecast.daily[2].weather[0].description);
                        lbl_tempDay2.Text = string.Format("{0:F0} \u00B0C", forecast.daily[2].temp.day);
                        lbl_windDay2.Text = string.Format("Wind speed: {0} m/s", forecast.daily[2].wind_speed);
                        picture_day2.Image = setIcon(forecast.daily[2].weather[0].icon);

                        lbl_nameDay3.Text = string.Format("{0}", getDate(forecast.daily[3].dt).DayOfWeek);
                        lbl_condDay3.Text = string.Format("{0}", forecast.daily[3].weather[0].description);
                        lbl_tempDay3.Text = string.Format("{0:F0} \u00B0C", forecast.daily[3].temp.day);
                        lbl_windDay3.Text = string.Format("Wind speed: {0} m/s", forecast.daily[3].wind_speed);
                        picture_day3.Image = setIcon(forecast.daily[3].weather[0].icon);
                    }
                }
                void getHourly(string coordLon, string coordLat)
                {
                    string url2 = string.Format("http://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,daily,alerts&appid={2}&units=metric", coordLat, coordLon, APPID);
                    using (WebClient web2 = new WebClient())
                    {
                        var json2 = web2.DownloadString(url2);
                        var ObjectH = JsonConvert.DeserializeObject<WeatherHourly>(json2);

                        WeatherHourly hourly = ObjectH;
                        lbl_TempHour1.Text = string.Format("{0:F0} \u00B0C", hourly.hourly[1].temp);
                        lbl_condHour1.Text = string.Format("{0}", hourly.hourly[1].weather[0].description);
                        lbl_windHour1.Text = string.Format("Wind speed: {0} m/s", hourly.hourly[1].wind_speed);
                        picture_hour1.Image = setIcon(hourly.hourly[1].weather[0].icon);

                        lbl_TempHour2.Text = string.Format("{0:F0} \u00B0C", hourly.hourly[2].temp);
                        lbl_condHour2.Text = string.Format("{0}", hourly.hourly[2].weather[0].description);
                        lbl_windHour2.Text = string.Format("Wind speed: {0} m/s", hourly.hourly[2].wind_speed);
                        picture_hour2.Image = setIcon(hourly.hourly[2].weather[0].icon);

                        lbl_TempHour3.Text = string.Format("{0:F0} \u00B0C", hourly.hourly[3].temp);
                        lbl_condHour3.Text = string.Format("{0}", hourly.hourly[3].weather[0].description);
                        lbl_windHour3.Text = string.Format("Wind speed: {0} m/s", hourly.hourly[3].wind_speed);
                        picture_hour3.Image = setIcon(hourly.hourly[3].weather[0].icon);

                        lbl_TempHour4.Text = string.Format("{0:F0} \u00B0C", hourly.hourly[4].temp);
                        lbl_condHour4.Text = string.Format("{0}", hourly.hourly[4].weather[0].description);
                        lbl_windHour4.Text = string.Format("Wind speed: {0} m/s", hourly.hourly[4].wind_speed);
                        picture_hour4.Image = setIcon(hourly.hourly[4].weather[0].icon);

                        lbl_TempHour5.Text = string.Format("{0:F0} \u00B0C", hourly.hourly[5].temp);
                        lbl_condHour5.Text = string.Format("{0}", hourly.hourly[5].weather[0].description);
                        lbl_windHour5.Text = string.Format("Wind speed: {0} m/s", hourly.hourly[5].wind_speed);
                        picture_hour5.Image = setIcon(hourly.hourly[5].weather[0].icon);

                        lbl_TempHour6.Text = string.Format("{0:F0} \u00B0C", hourly.hourly[6].temp);
                        lbl_condHour6.Text = string.Format("{0}", hourly.hourly[6].weather[0].description);
                        lbl_windHour6.Text = string.Format("Wind speed: {0} m/s", hourly.hourly[6].wind_speed);
                        picture_hour6.Image = setIcon(hourly.hourly[6].weather[0].icon);
                    }
                }
            }
        }

        void getWeatherByCoords(double lat, double lng)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/find?lat={0}&lon={1}&cnt=2&appid={2}", lat, lng, APPID);
                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherByCoords>(json);

                WeatherByCoords output = result;
                string cityName = string.Format(output.list[0].name);
                getWeather(cityName);
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text != "")
            {
                var nameOfCity = textBox_Search.Text;
                nameOfCity = nameOfCity.Replace(" ", "+");
                getWeather(nameOfCity);
                using (StreamWriter str = new StreamWriter("recent_searches.txt", true))
                {
                    str.WriteLine(textBox_Search.Text);
                }
                getRecent();
                textBox_Search.Text = "Search for a city...";
                showMap();
            }
        }
        void getRecent()
        {
            using (StreamReader sr = new StreamReader("recent_searches.txt"))
            {
                string[] lines = File.ReadAllLines("recent_searches.txt");
                Array.Reverse(lines);
                btn_FirstCity.Text = lines[0];
                btn_SecondCity.Text = lines[1];
                btn_ThirdCity.Text = lines[2];
            }
        }

        void showMap()
        {
            using (StreamReader sr = new StreamReader("coordinates.txt"))
            {
                string[] lines = File.ReadAllLines("coordinates.txt");
                double lat;
                double lng;
                lng = Convert.ToDouble(lines[0]);
                lat = Convert.ToDouble(lines[1]);
                map.DragButton = MouseButtons.Left;
                map.MapProvider = GMapProviders.GoogleMap;
                map.Position = new PointLatLng(lat, lng);
                map.MinZoom = 5;
                map.MaxZoom = 100;
                map.Zoom = 10;
                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.green_dot);

                map.Overlays.Clear();
                GMapOverlay markers = new GMapOverlay("Markers");

                markers.Markers.Add(marker);

                map.Overlays.Add(markers);
            }
        }

        private void btn_FirstCity_Click(object sender, EventArgs e)
        {
            string cityName = btn_FirstCity.Text;
            getWeather(cityName);
            showMap();
        }

        private void btn_SecondCity_Click(object sender, EventArgs e)
        {
            string cityName = btn_SecondCity.Text;
            getWeather(cityName);
            showMap();
        }

        private void btn_ThirdCity_Click(object sender, EventArgs e)
        {
            string cityName = btn_ThirdCity.Text;
            getWeather(cityName);
            showMap();
        }

        private void textBox_Search_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Search.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var pointMap = map.FromLocalToLatLng(e.X, e.Y);
                double latMap = pointMap.Lat;
                double lngMap = pointMap.Lng;
                PointLatLng point = new PointLatLng(latMap, lngMap);
                using (StreamWriter str = new StreamWriter("coordinates.txt"))
                {
                    str.WriteLine(lngMap);
                    str.WriteLine(latMap);
                }
                //using (StreamReader sr = new StreamReader("coordinates.txt"))
                //{
                //    string[] lines = File.ReadAllLines("coordinates.txt");
                //    string cityName;
                //    cityName = lines[0];
                //    getWeather(cityName);
                //}
                getWeatherByCoords(latMap, lngMap);
                showMap();
            }
        }
    }
}
