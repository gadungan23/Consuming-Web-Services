using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace WeatherConsole1
{
    internal class Program
    {
        static string key = "7d67cef0939c108690952b9bdc4007c5";
        static string city = "London";
        static void Main(string[] args)
        {
            try
            {
                new Program().getJSON("https://api.openweathermap.org/data/2.5/weather?q=" +
                    city + "&appid=" + key);
                new Program().
                    getXML("https://api.openweathermap.org/data/2.5/weather?q=" + city +
                    "&&mode=xml&appid=" + key);
            }
            catch (Exception) { }
        }

        void getJSON(string url)
        {
            try
            {
                using (WebClient webclient = new WebClient())
                {
                    
                    var json = webclient.DownloadString(url);
                    WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(json);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    Console.WriteLine("===Coordinates===");
                    Console.WriteLine("lon: " + Info.coord.lon.ToString());
                    Console.WriteLine("lat: " + Info.coord.lat.ToString());
                    Console.WriteLine("===Weather===");
                    Console.WriteLine("id: " + Info.weather[0].id.ToString());
                    Console.WriteLine("main: " + Info.weather[0].main.ToString());
                    Console.WriteLine("description: " + Info.weather[0].description.ToString());
                    Console.WriteLine("icon: " + Info.weather[0].icon.ToString());
                    Console.WriteLine("===Main===");
                    Console.WriteLine("temp: " + Info.weather[0].id.ToString());
                    Console.WriteLine("feels_like: " + Info.main.feels_like.ToString());
                    Console.WriteLine("temp_min: " + Info.main.temp_min.ToString());
                    Console.WriteLine("temp_max: " + Info.main.temp_max.ToString());
                    Console.WriteLine("pressure: " + Info.main.pressure.ToString());
                    Console.WriteLine("humidity: " + Info.main.humidity.ToString());
                    Console.WriteLine("visibility: " + weatherInfo.visibility.ToString());
                    Console.WriteLine("===Wind===");
                    Console.WriteLine("speed: " + Info.wind.speed.ToString());
                    Console.WriteLine("deg: " + Info.wind.deg.ToString());
                    Console.WriteLine("===Clouds===");
                    Console.WriteLine("all: " + Info.clouds.all.ToString());
                    Console.WriteLine("dt: " + weatherInfo.dt.ToString());
                    Console.WriteLine("===Sys===");
                    Console.WriteLine("type: " + Info.sys.type.ToString());
                    Console.WriteLine("id: " + Info.sys.id.ToString());
                    Console.WriteLine("country: " + Info.sys.country.ToString());
                    Console.WriteLine("sunrise: " + Info.sys.sunrise.ToString());
                    Console.WriteLine("sunset: " + Info.sys.sunset.ToString());
                    Console.WriteLine("timezone: " + weatherInfo.timezone.ToString());
                    Console.WriteLine("id: " + weatherInfo.id.ToString());
                    Console.WriteLine("name: " + weatherInfo.name.ToString());
                    Console.WriteLine("cod: " + weatherInfo.cod.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        void getXML(string url)
        {
            try
            {
                var client = new WebClient();
                var content = client.DownloadString(url);

                XmlSerializer serializer = new XmlSerializer(typeof(WeatherInfoXML.root),
                    new XmlRootAttribute("current"));
                WeatherInfoXML.root result = null;
                using (TextReader reader = new StringReader(content))
                {
                    result = (WeatherInfoXML.root)serializer.Deserialize(reader);
                    Console.WriteLine("===City===");
                    Console.WriteLine("id: "+result.city.id.ToString());
                    Console.WriteLine("name: " + result.city.name.ToString());
                    Console.WriteLine("timezone: " + result.city.timezone.ToString());
                    Console.WriteLine("===Sun===");
                    Console.WriteLine("rise: " + result.city.sun.rise.ToString());
                    Console.WriteLine("set: " + result.city.sun.set.ToString());
                    Console.WriteLine("===Temperature===");
                    Console.WriteLine("value: " + result.temperature.value.ToString());
                    Console.WriteLine("min: " + result.temperature.min.ToString());
                    Console.WriteLine("max: " + result.temperature.max.ToString());
                    Console.WriteLine("===Feels Like===");
                    Console.WriteLine("value: " + result.feels_like.value.ToString());
                    Console.WriteLine("unit: " + result.feels_like.unit.ToString());
                    Console.WriteLine("===Humidity===");
                    Console.WriteLine("value: " + result.humidity.value.ToString());
                    Console.WriteLine("unit: " + result.humidity.unit.ToString());
                    Console.WriteLine("===Pressure===");
                    Console.WriteLine("value: " + result.pressure.value.ToString());
                    Console.WriteLine("unit: " + result.pressure.unit.ToString());
                    Console.WriteLine("===Wind===");
                    Console.WriteLine("===Speed===");
                    Console.WriteLine("value: " + result.wind.speed.value.ToString());
                    Console.WriteLine("unit: " + result.wind.speed.unit.ToString());
                    Console.WriteLine("name: " + result.wind.speed.unit.ToString());
                    Console.WriteLine("===Direction===");
                    //Console.WriteLine("value: " + result.wind.direction.value.ToString());
                    Console.WriteLine("unit: " + result.wind.speed.unit.ToString());
                    Console.WriteLine("name: " + result.wind.speed.unit.ToString());
                    Console.WriteLine("===Clouds===");
                    Console.WriteLine("value: " + result.clouds.value.ToString());
                    Console.WriteLine("name: " + result.clouds.name.ToString());
                    Console.WriteLine("===Visibility===");
                    Console.WriteLine("value: " + result.visibility.value.ToString());
                    Console.WriteLine("===Precipitation===");
                    Console.WriteLine("mode: " + result.precipitation.mode.ToString());
                    Console.WriteLine("===Weather===");
                    Console.WriteLine("number: " + result.weather.number.ToString());
                    Console.WriteLine("value: " + result.weather.value.ToString());
                    Console.WriteLine("icon: " + result.weather.icon.ToString());
                    Console.WriteLine("===Last Update===");
                    Console.WriteLine("value: " + result.lastupdate.value.ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
