namespace BGGAPI_UnitTests
{
    using BGGAPI;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Collection_IntegrationTesting
    {
        [TestMethod]
        public void Collection_ReturnsMoreThenZero()
        {
            var client = new Client();
            var collectionRequest = new BGGAPI.Collection.Request { UserName = "tysonjhayes", Rated = true, Stats = true };
            var collection = client.GetCollection(collectionRequest);
            Assert.IsTrue(collection.TotalItems > 0);
        }
    }
}
