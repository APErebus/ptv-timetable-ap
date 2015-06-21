using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ptv.Timetable.Api.Responses
{
    public class NextDeparturesResponse
    {
        public NextDeparturesResponse()
        {
            TimetableEntries = new List<TimetableEntry>();
        }

        [JsonProperty("values")]
        public List<TimetableEntry> TimetableEntries { get; private set; }
    }
}