using System.Collections.Generic;
using Newtonsoft.Json;
using Ptv.Timetable.Api.Converters;

namespace Ptv.Timetable.Api.Responses
{
    [JsonConverter(typeof(LinesByModeConverter))]
    public class LinesByModeResponse
    {
        public LinesByModeResponse()
        {
            Lines = new List<Line>();
        }

        public List<Line> Lines { get; private set; }
    }
}
