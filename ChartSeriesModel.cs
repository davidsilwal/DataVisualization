using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ChartSeriesModel
    {
        public ChartSeriesModel(string name, int value)
        {
            Name = name;
            Value = value;

        }
        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("y")]
        public int Value { get; }
    }
}
