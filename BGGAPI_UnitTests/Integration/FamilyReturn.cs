namespace BGGAPI_UnitTests.Integration
{
    using System.Collections.Generic;
    using System.Linq;

    using BGG.Annotations;

    using BGGAPI;
    using BGGAPI.Family;
    using BGGAPI.Shared;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Return = BGGAPI.Family.Return;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class FamilyReturn
    {
        /// <summary>
        /// The request id to use.
        /// Setting this as a field so it can be referenced else where.
        /// </summary>
        [NotNull]
        private static readonly List<int> RequestID = new List<int> { 2, 42 };

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        private static Return Return { get; set; }

        private static List<int> ReturnedItems { get; set; }

        private static int NameCount { get; set; }

            /// <summary>
        /// The setup of the User Tests.
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

        [TestMethod]
        public void IntegrationFamilyReturnsMoreThanZero()
        {
            Assert.IsTrue(Return.Items.Count > 0);
        }

        [TestMethod]
        public void IntegrationFamilyReturnsIDMatch()
        {
            foreach (var item in Return.Items)
            {
                ReturnedItems.Add(item.ID);
            }

            CollectionAssert.AreEqual(ReturnedItems, RequestID);
        }

        [TestMethod]
        public void IntegrationFamilyReturnsNameNotNull()
        {
            foreach (var name in Return.Items[0].Names.Where(name => !string.IsNullOrWhiteSpace(name.value)))
            {
                NameCount++;
            }

            Assert.AreEqual(NameCount, Return.Items[0].Names.Count);
        }

        [TestMethod]
        public void IntegrationFamilyReturnsThumbnailNotNull()
        {
            Assert.IsNotNull(Return.Items[0].Thumbnail);
        }

        [TestMethod]
        public void IntegrationFamilyReturnsImageNotNull()
        {
            Assert.IsNotNull(Return.Items[0].Image);
        }

        [TestMethod]
        public void IntegrationFamilyReturnsDescriptionIsNotNull()
        {
            Assert.IsNotNull(Return.Items[0].Description);
        }

        [TestMethod]
        public void IntegrationFamilyReturnsLinks()
        {
            var count = Return.Items[0].Links.Count(link => !string.IsNullOrWhiteSpace(link.value));
            Assert.AreEqual(count, Return.Items[0].Links.Count);
        }

        private static bool GetLinks(Item item)
        {
            return item.Links != null;
        }
    }
}
