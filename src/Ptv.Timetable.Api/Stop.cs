
using Newtonsoft.Json;

namespace Ptv.Timetable.Api
{
    public class Stop
    {
        #region JSON Serialization Properties

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("transport_type")]
        public TransportType TransportType { get; set; }

        [JsonProperty("stop_id")]
        public int StopId { get; set; }

        [JsonProperty("location_name")]
        public string LocationName { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        #endregion
    }
}