using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ptv.Timetable.Api
{
    public sealed class Disruption
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("publishedOn")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime PublishedOn { get; set; }
    }
}
