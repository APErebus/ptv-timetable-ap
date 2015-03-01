using System;

namespace Ptv.Timetable.Api
{
    class Utilities
    {
        public static string GetApiCompliantDateTimeString(DateTime dateTime)
        {
            return new DateTime(dateTime.Ticks - (dateTime.Ticks % TimeSpan.TicksPerSecond), dateTime.Kind).ToString("yyyy-MM-ddTHH:mm:ssZ");
        }
    }
}
