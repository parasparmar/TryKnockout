﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryKnockout.Models;

namespace TryKnockout.ViewModels
{
    public class ResultList<T>
    {
        [JsonProperty(PropertyName ="queryOptions")]
        public QueryOptions QueryOptions { get; set; }

        [JsonProperty(PropertyName = "results")]
        public List<T> Results { get; set; }
    }
}