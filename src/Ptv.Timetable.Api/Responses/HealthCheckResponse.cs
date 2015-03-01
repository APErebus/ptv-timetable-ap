using Newtonsoft.Json;

namespace Ptv.Timetable.Api.Responses
{
    public sealed class HealthCheckResponse
    {
        [JsonProperty("securityTokenOK")]
        public bool IsSecurityTokenValid { get; set; }

        [JsonProperty("clientClockOK")]
        public bool IsClientClockInSync { get; set; }

        [JsonProperty("memcacheOK")]
        public bool IsApiMemoryCacheOk { get; set; }

        [JsonProperty("databaseOK")]
        public bool IsApiDatabaseOk { get; set; }

        [JsonIgnore]
        public bool IsHealthyEnoughToConnect
        {
            get { return IsSecurityTokenValid && IsApiDatabaseOk; }
        }
    }
}
