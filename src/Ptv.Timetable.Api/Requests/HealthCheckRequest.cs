using System;
using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class HealthCheckRequest : IPtvRequest
    {
        private const string Url = "/v2/healthcheck?timestamp={0}";

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url, Utilities.GetApiCompliantDateTimeString(DateTime.UtcNow));
        }
    }
}
