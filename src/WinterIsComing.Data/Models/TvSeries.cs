﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Data.Models
{
    public class TvSeries
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
