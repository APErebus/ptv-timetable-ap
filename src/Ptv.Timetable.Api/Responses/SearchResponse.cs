using System.Collections.Generic;
using Newtonsoft.Json;
using Ptv.Timetable.Api.Converters;

namespace Ptv.Timetable.Api.Responses
{
    [JsonConverter(typeof(SearchResponseConverter))]
    public sealed class SearchResponse
    {
        public SearchResponse()
        {
            Stops = new List<Stop>();
            Lines = new List<Line>();
        }

        [JsonIgnore]
        public List<Stop> Stops { get; private set; }

        [JsonIgnore]
        public List<Line> Lines { get; private set; }

    
    }
}