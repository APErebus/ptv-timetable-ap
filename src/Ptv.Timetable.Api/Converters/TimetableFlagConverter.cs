using System;
using System.Linq;
using Newtonsoft.Json;

namespace Ptv.Timetable.Api.Converters
{
    class TimetableFlagConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();

            var splitFlags = value.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            return splitFlags.Where(str => str != "E").Select(ParseFlag).ToList();
        }

        private static TimetableFlag ParseFlag(string str)
        {
            switch (str)
            {
                case "RR":
                    return TimetableFlag.ReservationRequired;
                case "GC":
                    return TimetableFlag.ReservationRequired;
                case "DOO":
                    return TimetableFlag.ReservationRequired;
                case "PUO":
                    return TimetableFlag.ReservationRequired;
                case "MO":
                    return TimetableFlag.ReservationRequired;
                case "TU":
                    return TimetableFlag.ReservationRequired;
                case "WE":
                    return TimetableFlag.ReservationRequired;
                case "TH":
                    return TimetableFlag.ReservationRequired;
                case "FR":
                    return TimetableFlag.ReservationRequired;
                case "SS":
                    return TimetableFlag.ReservationRequired;
                default:
                    throw new InvalidOperationException("Unknown flag");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}