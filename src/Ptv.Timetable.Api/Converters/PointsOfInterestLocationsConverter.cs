using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ptv.Timetable.Api.Converters
{
    class PointsOfInterestLocationsConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var list = new List<Stop>();
            //loads
            var locations = JArray.Load(reader);

            foreach (var jObj in locations.Children<JObject>())
            {
                var outletProperty = jObj.Property("outlet_type");

                list.Add(outletProperty == null ? jObj.ToObject<Stop>() : jObj.ToObject<Outlet>());
            }

            return list;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}