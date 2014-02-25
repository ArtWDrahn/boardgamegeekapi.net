using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BGGAPI_UnitTests
{
    using System.Collections.Generic;

    using BGGAPI;

    [TestClass]
    public class Thing_BoardGame_IntegrationTest
    {
        [TestMethod]
        public void Thing_BoardGame_ReturnsExpectedID()
        {
            var client = new Client();
            var gameID = Shared.Shared.Integer();
            var thingRequest = new BGGAPI.Thing.Request { ID = new List<int> { gameID } };
            var things = client.GetThings(thingRequest);
            Assert.IsTrue(things.Items[0].ID == gameID);
        }
    }
}
