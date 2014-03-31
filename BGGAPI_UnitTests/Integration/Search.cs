namespace BGGAPI_UnitTests.Integration
{
    using System.Diagnostics;
    using System.Linq;
    using BGGAPI;
    using Shared;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Search
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        public static BGGAPI.Search.Return SearchRequest { get; set; }

        public static BGGAPI.Collection.Item Game { get; set; }

        /// <summary>
        /// The setup.
        /// </summary>
        /// <param name="testContext">
        /// The test context.
        /// </param>
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var client = new Client();
            var collectionRequest = new BGGAPI.Collection.Request { UserName = "tysonjhayes" };
            var collectionReturn = client.GetCollection(collectionRequest);
            Game = collectionReturn.Items.ToList().PickRandom();

            var searchRequest = new BGGAPI.Search.Request { Query = Game.Name, Exact = true };
            SearchRequest = client.SearchBGG(searchRequest);
        }


        [TestMethod]
        public void IntegrationSearchAssertCorrectTitleReturned()
        {
            Debug.Assert(Game != null, "Game != null");
            Assert.IsTrue(Equals(SearchRequest.Items[0].Name.value, Game.Name));
        }

        [TestMethod]
        public void IntegrationSearchAssertCorrectIdReturned()
        {
            Assert.IsTrue(Equals(SearchRequest.Items[0].ID, Game.ObjectId));
        }

        [TestMethod]
        public void IntegrationSearchAssertCorrectYearPublishedReturned()
        {
            Assert.IsTrue(Equals(SearchRequest.Items[0].YearPublished.value, Game.YearPublished));
        }

        [TestMethod]
        public void IntegrationSearchAssertIDReturned()
        {
            CollectionAssert.AllItemsAreNotNull(SearchRequest.Items.Select(items => items.ID).ToList());
        }

        [TestMethod]
        public void IntegrationSearchAssertNameReturned()
        {
            CollectionAssert.AllItemsAreNotNull(SearchRequest.Items.Select(items => items.Name.value).ToList());
        }

        [TestMethod]
        public void IntegrationSearchAssertYearReturned()
        {
            CollectionAssert.AllItemsAreNotNull(SearchRequest.Items.Select(items => items.YearPublished.value).ToList());
        }
    }
}
