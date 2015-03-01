using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Ptv.Timetable.Api.Converters;

namespace Ptv.Timetable.Api.Responses
{
    public class PointsOfInterestResponse
    {
        [JsonProperty("locations")]
        [JsonConverter(typeof(PointsOfInterestLocationsConverter))]
        private readonly List<Stop> _allLocations;

        [JsonIgnore]
        private List<Stop> _stops;

        [JsonIgnore]
        private List<Outlet> _outlets;

        [JsonProperty("minLat")]
        public double MinimumLatitude { get; set; }

        [JsonProperty("minLong")]
        public double MinimumLongitude { get; set; }

        [JsonProperty("maxLat")]
        public double MaximumLatitude { get; set; }

        [JsonProperty("maxLong")]
        public double MaximumLongitude { get; set; }

        [JsonProperty("weightedLat")]
        public double WeightedLatitude { get; set; }

        [JsonProperty("weightedLong")]
        public double WeightedLongitude { get; set; }

        [JsonProperty("totalLocations")]
        public int TotalLocations { get; set; }

        [JsonIgnore]
        public List<Stop> Stops { get { return _stops ?? (_stops = _allLocations.Except(Outlets).ToList()); } }

        [JsonIgnore]
        public List<Outlet> Outlets { get { return _outlets ?? (_outlets = _allLocations.OfType<Outlet>().ToList()); } }

        public PointsOfInterestResponse()
        {
            _allLocations = new List<Stop>();
        }
    }
}
