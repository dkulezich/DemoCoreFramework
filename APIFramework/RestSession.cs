using RestSharp;

namespace APIFramework
{
    public class RestSession
    {
        public RestSession(IRestClient client, IRestRequest request)
        {
            Client = client;
            Request = request;
        }

        public IRestClient Client { get; }
        public IRestRequest Request { get; }
        public IRestResponse Response => Client.Execute(Request);
    }
}