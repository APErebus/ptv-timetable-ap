using System.Collections.Generic;
using Newtonsoft.Json;
using Ptv.Timetable.Api.Converters;

namespace Ptv.Timetable.Api.Responses
{
    [JsonConverter(typeof(StopsNearbyConverter) )]
    public class StopsNearbyResponse
    {
        public StopsNearbyResponse()
        {
            Stops = new List<Stop>();
        }

        public List<Stop> Stops { get; private set; }
    }
}
