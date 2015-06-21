using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ptv.Timetable.Api.Responses;

namespace Ptv.Timetable.Api.Converters
{
    class LinesByModeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        { }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var response = new LinesByModeResponse();

            response.Lines.AddRange(JArray.Load(reader).Select(jt => jt.ToObject<Line>()));

            return response;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
