using System;
using System.Net;

namespace Ptv.Timetable.Api
{
    public class PtvTimetableException : Exception
    {
        public HttpStatusCode ReponseStatusCode { get; set; }

        public string ResponseReasonPhrase { get; set; }

        public Uri RequestUri { get; set; }

        public PtvTimetableException()
            : this("An exception occurred attempting to connect to the PTV API")
        { }

        public PtvTimetableException(string message)
            : base(message)
        { }
        public PtvTimetableException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
