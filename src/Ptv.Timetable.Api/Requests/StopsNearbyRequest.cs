using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class StopsNearbyRequest : IPtvRequest
    {
        private readonly double _latitude;
        private readonly double _longitude;

        private const string Url = "/v2/nearme/latitude/{0}/longitude/{1}";

        public StopsNearbyRequest(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url, _latitude.ToString("r"), _longitude.ToString("R"));
        }
    }
}
