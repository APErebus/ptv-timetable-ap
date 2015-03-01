using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class StopsForLineRequest : IPtvRequest
    {
        private readonly TransportType _transportType;
        private readonly int _lineId;

        public const string Url = "/v2/mode/{0}/line/{1}/stops-for-line";

        public StopsForLineRequest(TransportType transportType, int lineId)
        {
            _transportType = transportType;
            _lineId = lineId;
        }

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url,
                _transportType.ToString("D"),
                _lineId);
        }
    }
}
