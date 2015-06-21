using System.Globalization;
using System.Linq;

namespace Ptv.Timetable.Api.Requests
{
    class DisruptionsRequest : IRequest
    {
        private readonly DisruptionMode[] _modes;

        public DisruptionsRequest(params DisruptionMode[] modes)
        {
            _modes = modes;
        }

        private const string Url = "/v2/disruptions/modes/{0}";

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url, GetDisruptionModes());
        }

        private string GetDisruptionModes()
        {
            var modes = string.Join(",", _modes.Select(GetDisruptionString));

            if (_modes.Length > 1)
                modes = "general," + modes;

            return modes;
        }

        private static string GetDisruptionString(DisruptionMode mode)
        {
            switch (mode)
            {
                case DisruptionMode.MetroBus:
                    return "metro-bus";
                case DisruptionMode.MetroTrain:
                    return "metro-train";
                case DisruptionMode.MetroTram:
                    return "metro-tram";
                case DisruptionMode.RegionalBus:
                    return "regional-bus";
                case DisruptionMode.RegionalTrain:
                    return "regional-train";
                case DisruptionMode.RegionalCoach:
                    return "regional-coach";
                default:
                    return "general";
            }
        }
    }
}
