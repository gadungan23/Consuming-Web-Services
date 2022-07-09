using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherConsole1
{
    public class WeatherInfo
    {
        public string baseStr { get; set; }
        public string visibility { get; set; }
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set;  }
        }

        public class Weather
        {
            public string id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public string pressure { get; set; }
            public string humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
        }

        public class clouds
        {
            public double all { get; set; }
        }

        public string dt { get; set; }
        
        public class sys
        {
            public string type { get; set; }
            public string id { get; set; }
            public string country { get; set; }
            public string sunrise { get; set; }
            public string sunset { get; set; }
        }

        public string timezone { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }

        public class root
        {
            public coord coord { get; set; }
            public List <Weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public clouds clouds { get; set; }
            public sys sys { get; set; }

        }

    }
}
