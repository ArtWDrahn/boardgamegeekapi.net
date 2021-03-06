﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FamilyReturn.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Integration for the Family API calls.
//   See <see cref="BGGAPI.Family.Request" /> for the Request calls
//   See <see cref="BGGAPI.Family.Return" /> for the return response.
//   See <see cref="BGGAPI.Family.Item" /> for the individual items returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using System.Collections.Generic;
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Family;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Return = BGGAPI.Family.Return;

    /// <summary>
    /// Integration for the Family API calls.
    /// See <see cref="BGGAPI.Family.Request"/> for the Request calls
    /// See <see cref="BGGAPI.Family.Return"/> for the return response.
    /// See <see cref="BGGAPI.Family.Item"/> for the individual items returned.
    /// </summary>
    [TestClass]
    public class FamilyReturn
    {
        /// <summary>
        /// The request id to use.
        /// Setting this as a field so it can be referenced else where.
        /// </summary>
        private static readonly List<int> RequestID = new List<int> { 2, 42 };

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Gets or sets the returned object.
        /// </summary>
        private static Return Return { get; set; }

        /// <summary>
        /// Gets or sets the returned items.
        /// </summary>
        private static List<int> ReturnedItems { get; set; }

        /// <summary>
        /// The setup of the Family Return Tests.
        /// </summary>
        /// <param name="testContext">
        /// The test context.  Not actually used.
        /// </param>
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var client = new Client();

            var familyRequest = new Request { ID = RequestID };
            Return = client.GetFamily(familyRequest);
            ReturnedItems = new List<int>();
        }

        /// <summary>
        /// The integration family returns more than zero.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsMoreThanZero()
        {
            Assert.IsTrue(Return.Items.Count > 0);
        }

        /// <summary>
        /// The integration family returns id match.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsIDMatch()
        {
            foreach (var item in Return.Items)
            {
                ReturnedItems.Add(item.ID);
            }

            CollectionAssert.AreEqual(ReturnedItems, RequestID);
        }

        /// <summary>
        /// The integration family returns name not null.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(names => names.Names.Select(name => name.value)).ToList());
        }

        /// <summary>
        /// The integration family returns thumbnail not null.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsThumbnailNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.Thumbnail).ToList());
        }

        /// <summary>
        /// The integration family returns image not null.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsImageNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.Image).ToList());
        }

        /// <summary>
        /// The integration family returns description is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsDescriptionIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items.Select(item => item.Description).ToList());
        }

        /// <summary>
        /// The integration family returns links.
        /// </summary>
        [TestMethod]
        public void IntegrationFamilyReturnsLinks()
        {
            var count = Return.Items[0].Links.Count(link => !string.IsNullOrWhiteSpace(link.value));
            Assert.AreEqual(count, Return.Items[0].Links.Count);
        }
    }
}
