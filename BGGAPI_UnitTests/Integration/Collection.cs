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

    using System.Collections.Generic;
    using System.Linq;

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
            var ids = new List<int> { 41114 };
            var collectionRequest = new Request { UserName = "tysonjhayes", Version = true, ID = ids};
            CollectionReturn = client.GetCollection(collectionRequest);
        }

        /// <summary>
        /// Integration Collection Version Not Null
        /// This should tell us if we are getting /any/ version info.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionVersionNotNull()
        {
            Assert.IsTrue(CollectionReturn.Items.Select(items => items.Version).Any());
        }

        [TestMethod]
        public void IntegrationCollectionVersionThumbnail()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Thumbnail).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionImage()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Image).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionName()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Name).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionLinks()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Links).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionYearPublished()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.YearPublished).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionProductCode()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.ProductCode).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionWidth()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Width.value).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionLength()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Length.value).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionDepth()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Depth.value).ToList());
        }

        [TestMethod]
        public void IntegrationCollectionVersionWeight()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Where(items => items.Version != null).Select(items => items.Version).Select(version => version.Item).Select(item => item.Weight).ToList());
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
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Select(item => item.Name).ToList());
        }

        /// <summary>
        /// The collection year is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationCollectionYearIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(CollectionReturn.Items.Select(item =>item.YearPublished).ToList());
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

        [TestMethod]
        public void IntegrationCollectionVersionVolumeSort()
        {
            var client = new Client();
            var collectionRequest = new Request { UserName = "tysonjhayes", Version = true, Own = true };
            var volume = client.GetCollectionSorted(collectionRequest);
            Assert.IsTrue(volume[0].Volume > 0);
        }
    }
}
