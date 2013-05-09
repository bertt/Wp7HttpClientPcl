﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Wp7HttpClientPcl.Core
{
    public class DataGetter
    {
        public async static Task<string> GetSomeEarthquakeData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.geonames.org/");
            var resp = await client.GetAsync("earthquakesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&username=bertt");
            var earthquakesJson = await resp.Content.ReadAsStringAsync();
            return earthquakesJson;
        }
    }
}