using System;
using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class StoppingPatternRequest : IPtvRequest
    {
        private readonly TransportType _transportType;
        private readonly int _runId;
        private readonly int _stopId;
        private readonly DateTime _requestUtcTime;

        private const string Url = "/v2/mode/{0}/run/{1}/stop/{2}/stopping-pattern?for_utc={3}";

        public StoppingPatternRequest(TransportType transportType, int runId, int stopId, DateTime requestUtcTime)
        {
            _transportType = transportType;
            _runId = runId;
            _stopId = stopId;
            _requestUtcTime = requestUtcTime;
        }

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url,
                _transportType.ToString("D"),
                _runId,
                _stopId,
                Utilities.GetApiCompliantDateTimeString(_requestUtcTime));
        }
    }
}
