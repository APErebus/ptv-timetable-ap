using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ptv.Timetable.Api.Responses
{
    public class DisruptionsResponse
    {
        public DisruptionsResponse()
        {
            GeneralDisruptions = new List<Disruption>();
            MetroTrainDisruptions = new List<Disruption>();
            MetroTramDisruptions = new List<Disruption>();
            MetroBusDisruptions = new List<Disruption>();
            RegionalTrainDisruptions = new List<Disruption>();
            RegionalCoachDisruptions = new List<Disruption>();
            RegionalBusDisruptions = new List<Disruption>();
        }

        [JsonProperty("general")]
        public IEnumerable<Disruption> GeneralDisruptions { get; private set; }

        [JsonProperty("metro-train")]
        public IEnumerable<Disruption> MetroTrainDisruptions { get; private set; }

        [JsonProperty("metro-tram")]
        public IEnumerable<Disruption> MetroTramDisruptions { get;private set; }

        [JsonProperty("metro-bus")]
        public IEnumerable<Disruption> MetroBusDisruptions { get; private set; }

        [JsonProperty("regional-train")]
        public IEnumerable<Disruption> RegionalTrainDisruptions { get; private set; }

        [JsonProperty("regional-coach")]
        public IEnumerable<Disruption> RegionalCoachDisruptions { get; private set; }

        [JsonProperty("regional-bus")]
        public IEnumerable<Disruption> RegionalBusDisruptions { get; private set; }  
    }
}
