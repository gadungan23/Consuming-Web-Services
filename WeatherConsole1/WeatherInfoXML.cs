
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherConsole1
{
    public class WeatherInfoXML
    {
        public class city
        {

            [XmlAttribute("id")]
            public string id { get; set; }

            [XmlAttribute("name")]
            public string name { get; set; }
            public string country { get; set; }
            public string timezone { get; set; }

            [XmlElement("coord")]
            public coord coord { get; set; }

            [XmlElement("sun")]
            public sun sun { get; set; }
        }



        public class coord
        {
            [XmlAttribute("lon")]
            public string lon { get; set; }

            [XmlAttribute("lat")]
            public string lat { get; set; }
        }

        public class sun
        {
            [XmlAttribute("rise")]
            public string rise { get; set; }

            [XmlAttribute("set")]
            public string set { get; set; }
        }

        public class temperature
        {
            [XmlAttribute("value")]
            public string value { get; set; }

            [XmlAttribute("min")]
            public string min { get; set; }

            [XmlAttribute("max")]
            public string max { get; set; }

            [XmlAttribute("unit")]
            public string unit { get; set; }
        }
        public class feels_like
        {
            [XmlAttribute("value")]
            public string value { get; set; }

            [XmlAttribute("unit")]
            public string unit { get; set; }
        }

        public class humidity
        {
            [XmlAttribute("value")]
            public string value { get; set; }

            [XmlAttribute("unit")]
            public string unit { get; set; }
        }

        public class pressure
        {
            [XmlAttribute("value")]
            public string value { get; set; }

            [XmlAttribute("unit")]
            public string unit { get; set; }
        }

        public class wind
        {
            [XmlElement("speed")]
            public speed speed { get; set; }

            [XmlElement("direction")]
            public direction direction { get; set; }
        }

        public class speed
        {
            [XmlAttribute("value")]
            public string value { get; set; }
            [XmlAttribute("unit")]
            public string unit { get; set; }
            [XmlAttribute("name")]
            public string name { get; set; }
        }

        public class direction
        {
            [XmlAttribute("value")]
            public string value { get; set; }
            [XmlAttribute("code")]
            public string code { get; set; }
            [XmlAttribute("name")]
            public string name { get; set; }
        }

        public class clouds
        {
            [XmlAttribute("value")]
            public string value { get; set; }
            [XmlAttribute("name")]
            public string name { get; set; }
        }

        public class visibility
        {
            [XmlAttribute("value")]
            public string value { get; set; }
        }

        public class precipitation
        {
            [XmlAttribute("mode")]
            public string mode { get; set; }
        }

        public class weather
        {
            [XmlAttribute("number")]
            public string number { get; set; }

            [XmlAttribute("value")]
            public string value { get; set; }

            [XmlAttribute("icon")]
            public string icon { get; set; }
        }

        public class lastupdate
        {
            [XmlAttribute("value")]
            public string value { get; set; }
        }

        public class root
        {
            [XmlElement("city")]
            public city city { get; set; }

            [XmlElement("temperature")]
            public temperature temperature { get; set; }

            [XmlElement("feels_like")]
            public feels_like feels_like { get; set; }

            [XmlElement("humidity")]
            public humidity humidity { get; set; }

            [XmlElement("pressure")]
            public pressure pressure { get; set; }

            [XmlElement("wind")]
            public wind wind { get; set; }

            [XmlElement("clouds")]
            public clouds clouds { get; set; }

            [XmlElement("visibility")]
            public visibility visibility { get; set; }

            [XmlElement("precipitation")]
            public precipitation precipitation { get; set; }

            [XmlElement("weather")]
            public weather weather { get; set; }

            [XmlElement("lastupdate")]
            public lastupdate lastupdate { get; set; }
        }
    }
}
