using System;
using System.Globalization;

namespace Ptv.Timetable.Api.Requests
{
    class SearchRequest : IRequest
    {
        private readonly string _searchTerm;

        private const string Url = "/v2/search/{0}";

        public SearchRequest(string searchTerm)
        {
            _searchTerm = searchTerm;
        }

        public string BuildRequestUrl()
        {
            var encodedSearchTerm = Uri.EscapeDataString(_searchTerm.Trim());

            return string.Format(CultureInfo.CurrentCulture, Url, encodedSearchTerm);
        }
    }
}