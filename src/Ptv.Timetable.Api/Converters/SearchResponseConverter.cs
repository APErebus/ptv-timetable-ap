using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ptv.Timetable.Api.Responses;

namespace Ptv.Timetable.Api.Converters
{
    class SearchResponseConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var response = new SearchResponse();

            var array = JArray.Load(reader);

            foreach (var jObj in array.Cast<JObject>())
            {
                var typeProp = jObj.Property("type");
                if (typeProp == null)
                    continue;

                switch (typeProp.Value.Value<string>())
                {
                    case "stop":
                        response.Stops.Add(jObj["result"].ToObject<Stop>());
                        break;
                    case "line":
                        response.Lines.Add(jObj["result"].ToObject<Line>());
                        break;
                }
            }

            return response;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}