using Newtonsoft.Json;

namespace Ptv.Timetable.Api
{
    public class Line
    {
        [JsonProperty("transport_type")]
        public TransportType TransportType { get; set; }

        [JsonProperty("line_id")]
        public int Id { get; set; }

        [JsonProperty("line_name")]
        public string Name { get; set; }

        [JsonProperty("line_number")]
        public string Number { get; set; }
    }
}
