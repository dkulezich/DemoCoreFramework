using APIFramework;
using APIFramework.Configuration;
using Moq;
using NUnit.Framework;

namespace UnitTests
{
    public class RestClientFactoryTests
    {

        [Test]
        public void Create_IsSuccessful()
        {
            var configuration = new Mock<ApiFrameworkSection>();
            var restClientFactory = new RestClientFactory(configuration.Object);
            var restClient = restClientFactory.Create();

            Assert.IsNotNull(restClient);
        }
    }
}