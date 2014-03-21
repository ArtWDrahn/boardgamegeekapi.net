// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hot.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Integration testing for the hot list.
//  <see cref="Request"/> for the request object.
//  <see cref="Return"/> for the return object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Hot;

    using BGGAPI_UnitTests.Shared;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Integration testing for the hot list.
    /// <see cref="Return"/> for the return object.
    /// <see cref="Request"/> for the request object.
    /// </summary>
    [TestClass]
    public class Hot
    {
        /// <summary>
        /// All of the available types.
        /// </summary>
        private static readonly List<Request.FamilyType> TypesAll =
            ((Request.FamilyType[])Enum.GetValues(typeof(Request.FamilyType))).ToList();

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Gets or sets the returned thing object.
        /// </summary>
        private static Return Return { get; set; }

        /// <summary>
        /// The setup of the Thing Integration Tests.
        /// </summary>
        /// <param name="testContext">
        /// The test context.  Not actually used.
        /// </param>
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var client = new Client();
            var type = TypesAll.PickRandom();
            var hotRequest = new Request { Type = type };
            Return = client.GetHotList(hotRequest);
        }

        /// <summary>
        /// The integration hot items not null.
        /// </summary>
        [TestMethod]
        public void IntegrationHotItemsNotNull()
        {
            Assert.IsTrue(Return.Items.Any());
        }

        /// <summary>
        /// The integration hot item id not null.
        /// </summary>
        [TestMethod]
        public void IntegrationHotItemIDNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.ID).ToList());
        }

        /// <summary>
        /// The integration hot item rank not null.
        /// </summary>
        [TestMethod]
        public void IntegrationHotItemRankNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.Rank).ToList());
        }

        /// <summary>
        /// The integration hot item thumbnail not null.
        /// </summary>
        [TestMethod]
        public void IntegrationHotItemThumbnailNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.Thumbnail).ToList());
        }

        /// <summary>
        /// The integration hot item name not null.
        /// </summary>
        [TestMethod]
        public void IntegrationHotItemNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.Name).ToList());
        }
    }
}
