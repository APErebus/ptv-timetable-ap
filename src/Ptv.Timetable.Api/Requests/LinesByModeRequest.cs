using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class LinesByModeRequest : IPtvRequest
    {
        private readonly TransportType _transportType;
        private readonly string _nameFilter;

        private const string Url = "/v2/lines/mode/{0}";
        private const string NameFilterQuery = "{0}?name={1}";

        public LinesByModeRequest(TransportType transportType, string nameFilter)
        {
            _transportType = transportType;
            _nameFilter = nameFilter;
        }

        public string BuildRequestUrl()
        {
            var url = string.Format(CultureInfo.CurrentCulture, Url,
                _transportType.ToString("D"));

            if (!string.IsNullOrEmpty(_nameFilter))
                url = string.Format(CultureInfo.CurrentCulture, NameFilterQuery, url, NameFilterQuery);

            return url;
        }
    }
}
