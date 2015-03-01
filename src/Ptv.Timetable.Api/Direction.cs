using Newtonsoft.Json;

namespace Ptv.Timetable.Api
{
    public class Direction
    {
        [JsonProperty("linedir_id")]
        public int LineDirectionId { get; set; }

        [JsonProperty("direction_id")]
        public int Id { get; set; }

        [JsonProperty("direction_name")]
        public string Name { get; set; }

        [JsonProperty("line")]
        public Line Line { get; set; }
    }
}
