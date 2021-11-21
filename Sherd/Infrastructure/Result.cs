using System.Collections.Generic;
using System.Net;

namespace Infrastructure
{
    public class Result
    {
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public object Data { get; set; }
    }

    public class ApiResult
    {
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public object Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
