using Newtonsoft.Json;

namespace Ptv.Timetable.Api
{
    public class Run
    {
        [JsonProperty("transport_type")]
        public TransportType TransportType { get; set; }

        [JsonProperty("run_id")]
        public int Id { get; set; }

        [JsonProperty("num_skipped")]
        public int StopsSkipped { get; set; }

        [JsonProperty("destination_id")]
        public int DestinationStopId { get; set; }

        [JsonProperty("destination_name")]
        public string DestinationName { get; set; }
    }
}
