using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class BroadNextDeparturesRequest : IPtvRequest
    {
        private readonly TransportType _transportType;
        private readonly int _stopId;
        private readonly int _limit;

        private const string Url = "/v2/mode/{0}/stop/{1}/departures/by-destination/limit/{2}";

        public BroadNextDeparturesRequest(TransportType transportType, int stopId, int limit)
        {
            _transportType = transportType;
            _stopId = stopId;
            _limit = limit;
        }

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url, _transportType.ToString("D"), _stopId, _limit);
        }
    }
}
