﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapkarajouhou
{
    public class BookmarkedCity
    {
        public List<City> Cities { get; set; }

        public BookmarkedCity()
        {
            Cities = new List<City>();
        }

        public class City
        {
            public string Name { get; set; }
            public string Lat { get; set; }
            public string Lng { get; set; }

            public City(string name, string lat, string lng)
            {
                Name = name;
                Lat = lat;
                Lng = lng;
            }
        }
    }
}
