using System;

namespace CDON.Marketplace
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }

        public string Content { get; set; }

        public string RequestUrl { get; set; }

        public ApiException(int statusCode, string content, string requestUrl)
            : base($"Got {statusCode} with {content} from {requestUrl}")
        {
            StatusCode = statusCode;
            Content = content;
            RequestUrl = requestUrl;
        }
    }
}
