// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Collection.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//  Integration for the Collection request.
//  <see cref="Request"/> for the request code.
//  <see cref="Return"/> for the returned object.
//  <see cref="Item"/> for the specific items returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using BGGAPI;
    using BGGAPI.Collection;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Integration for the Collection request.
    /// <see cref="Request"/> for the request code.
    /// <see cref="Return"/> for the returned object.
    /// <see cref="Item"/> for the specific items returned.
    /// </summary>
    [TestClass]
    public class Collection
    {
        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        public static Return CollectionReturn { get; set; }

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

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
            var collectionRequest = new Request { UserName = "tysonjhayes" };
            CollectionReturn = client.GetCollection(collectionRequest);
        }

        /// <summary>
        /// The collection returns more then zero.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionReturnsMoreThenZero()
        {
            Assert.IsTrue(CollectionReturn.TotalItems > 0);
        }

        /// <summary>
        /// The collection name is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionNameIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Name);
        }

        /// <summary>
        /// The collection year is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionYearIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].YearPublished);
        }

        /// <summary>
        /// The collection image is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionImageIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Image);
        }

        /// <summary>
        /// The collection thumbnail is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionThumbnailIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Thumbnail);
        }

        /// <summary>
        /// The collection number of plays is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionNumPlaysIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].NumPlays);
        }

        /// <summary>
        /// The collection status is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionStatusIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status);
        }

        /// <summary>
        /// The collection status own is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionStatusOwnIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status.Own);
        }

        /// <summary>
        /// The collection status previously owned is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionStatusPrevOwnedIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status.PreviouslyOwned);
        }

        /// <summary>
        /// The collection status for trade is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionStatusForTradeIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status.ForTrade);
        }
    }
}
