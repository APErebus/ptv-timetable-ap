using Newtonsoft.Json;

namespace Ptv.Timetable.Api
{
    public class Outlet : Stop
    {
        [JsonProperty("outlet_type")]
        public string OutletType { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
    }
}