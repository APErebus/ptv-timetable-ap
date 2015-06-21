using System.Collections.Generic;
using Newtonsoft.Json;
using Ptv.Timetable.Api.Converters;

namespace Ptv.Timetable.Api.Responses
{
    [JsonConverter(typeof(StopsForLineConverter))]
    public class StopsForLineResponse
    {
        public StopsForLineResponse()
        {
            Stops = new List<Stop>();
        }

        public List<Stop> Stops { get; private set; }
    }
}
