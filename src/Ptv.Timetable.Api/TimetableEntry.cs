using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Ptv.Timetable.Api.Converters;

namespace Ptv.Timetable.Api
{
    public class TimetableEntry
    {
        [JsonProperty("platform")]
        public Platform Platform { get; set; }

        [JsonProperty("run")]
        public Run Run { get; set; }

        [JsonProperty("time_timetable_utc")]
        [JsonConverter(typeof (IsoDateTimeConverter))]
        public DateTimeOffset ScheduledTime { get; set; }

        [JsonProperty("time_realtime_utc")]
        [JsonConverter(typeof (IsoDateTimeConverter))]
        public DateTimeOffset? RealTime { get; set; }

        [JsonProperty("flags")]
        [JsonConverter(typeof (TimetableFlagConverter))]
        public IEnumerable<TimetableFlag> Flags { get; set; }
    }
}