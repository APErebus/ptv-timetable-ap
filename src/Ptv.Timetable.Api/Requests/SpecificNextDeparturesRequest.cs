using System;
using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class SpecificNextDeparturesRequest : IRequest
    {
        private readonly TransportType _transportType;
        private readonly int _lineId;
        private readonly int _stopId;
        private readonly int _directionId;
        private readonly int _limit;
        private readonly DateTime? _specifiedTime;

        private const string Url = "/v2/mode/{0}/line/{1}/stop/{2}/directionid/{3}/departures/all/limit/{4}";
        private const string TimeIncludedUrl = "{0}?for_utc={1}";

        public SpecificNextDeparturesRequest(TransportType transportType, int lineId, int stopId, int directionId, int limit, DateTime? specifiedTime)
        {
            _transportType = transportType;
            _lineId = lineId;
            _stopId = stopId;
            _directionId = directionId;
            _limit = limit;
            _specifiedTime = specifiedTime;
        }

        public string BuildRequestUrl()
        {
            var url = string.Format(CultureInfo.CurrentCulture, Url,
                _transportType.ToString("D"),
                _lineId,
                _stopId,
                _directionId,
                _limit);

            if (_specifiedTime.HasValue)
                url = string.Format(CultureInfo.CurrentCulture, TimeIncludedUrl, url, Utilities.GetApiCompliantDateTimeString(_specifiedTime.Value));

            return url;
        }
    }
}