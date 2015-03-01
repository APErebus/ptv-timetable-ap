using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ptv.Timetable.Api.Responses;

namespace Ptv.Timetable.Api
{
    public interface IPtvTimetableService
    {
        Task<HealthCheckResponse> PerformHealthCheckAsync();

        Task<StopsNearbyResponse> GetStopsNearbyAsync(double latitude, double longitude);

        Task<PointsOfInterestResponse> GetPointsOfInterestAsync(
            IEnumerable<PointOfInterestType> filterTypes,
            double topLeftLatitude,
            double topLeftLogitude,
            double bottomRightLatitude,
            double bottomRightLongitude,
            int gridDepth, 
            int limit);

        Task<SearchResponse> PerformSearchAsync(string searchTerm);

        Task<NextDeparturesResponse> ListBroadNextDeparturesAsync(TransportType transportType, int stopId, int limit);

        Task<NextDeparturesResponse> ListSpecificNextDeparturesAsync(TransportType transportType, int lineId, int stopId, int directionId, int limit, DateTime? specifiedUtcTime = null);

        Task<StoppingPatternResponse> GetStoppingPatternAsync(TransportType transportType, int runId, int stopId, DateTime requestUtcTime);

        Task<StopsForLineResponse> ListStopsForLineAsync(TransportType transportType, int lineId);

        Task<byte[]> GetLineMapAsync(int lineId);
    }
}