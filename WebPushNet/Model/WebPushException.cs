using System.Net;
using System.Net.Http.Headers;

namespace WebPushNet
{
    public class WebPushNetException : Exception
    {
        public WebPushNetException(string message, PushSubscription pushSubscription, HttpResponseMessage responseMessage) : base(message)
        {
            PushSubscription = pushSubscription;
            HttpResponseMessage = responseMessage;
        }

        public HttpStatusCode StatusCode => HttpResponseMessage.StatusCode;

        public HttpResponseHeaders Headers => HttpResponseMessage.Headers;
        public PushSubscription PushSubscription { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
    }
}