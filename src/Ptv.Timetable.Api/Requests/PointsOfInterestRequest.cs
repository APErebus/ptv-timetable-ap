using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Ptv.Timetable.Api;

namespace Ptv.Timetable.Api.Requests
{
    class PointsOfInterestRequest : IPtvRequest
    {
        private readonly IEnumerable<PointOfInterestType> _filterTypes;
        private readonly double _topLeftLatitude;
        private readonly double _topLeftLongitude;
        private readonly double _bottomRightLatitude;
        private readonly double _bottomRightLongitude;
        private readonly int _gridDepth;
        private readonly int _limit;

        private const string Url = "/v2/poi/{0}/lat1/{1}/long1/{2}/lat2/{3}/long2/{4}/griddepth/{5}/limit/{6}";

        public string BuildQueryString()
        {
            return null;
        }

        public string BuildRequestUrl()
        {
            return string.Format(CultureInfo.CurrentCulture, Url,
                string.Join(",", _filterTypes.Select(ft => ft.ToString("D"))),
                _topLeftLatitude.ToString("r"),
                _topLeftLongitude.ToString("r"),
                _bottomRightLatitude.ToString("r"),
                _bottomRightLongitude.ToString("r"),
                _gridDepth,
                _limit
                );
        }

        public PointsOfInterestRequest(IEnumerable<PointOfInterestType> filterTypes, double topLeftLatitude, double topLeftLongitude, double bottomRightLatitude, double bottomRightLongitude, int gridDepth, int limit)
        {
            _filterTypes = filterTypes;
            _topLeftLatitude = topLeftLatitude;
            _topLeftLongitude = topLeftLongitude;
            _bottomRightLatitude = bottomRightLatitude;
            _bottomRightLongitude = bottomRightLongitude;
            _gridDepth = gridDepth;
            _limit = limit;
        }
    }
}
