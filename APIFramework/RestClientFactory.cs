using APIFramework.Configuration;
using RestSharp;
using System;

namespace APIFramework
{
    public class RestClientFactory
    {
        private readonly ApiFrameworkSection config;

        public RestClientFactory(ApiFrameworkSection config)
        {
            this.config = config;
        }

        public IRestClient Create()
        {
            return new RestClient(config.baseUrl);
        }
    }
}
