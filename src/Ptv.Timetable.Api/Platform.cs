using Newtonsoft.Json;

namespace Ptv.Timetable.Api
{
    public class Platform
    {
        [JsonProperty("realtime_id")]
        public int RealTimeId { get; set; }

        [JsonProperty("stop")]
        public Stop Stop { get; set; }

        [JsonProperty("direction")]
        public Direction Direction { get; set; }
    }
}
