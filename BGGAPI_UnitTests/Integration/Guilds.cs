namespace BGGAPI_UnitTests.Integration
{
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Guilds;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for Guild
    /// </summary>
    [TestClass]
    public class Guilds
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Gets or sets the returned thing object.
        /// </summary>
        private static Return Return { get; set; }

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var client = new Client();
            var guildRequest = new Request { ID = 6, Members = true };
            Return = client.GetGuild(guildRequest);
        }

        [TestMethod]
        public void IntegrationGuildIDEqualsRequest()
        {
            Assert.IsTrue(Return.ID == 6);
        }

        [TestMethod]
        public void IntegrationGuildNameIsNotNull()
        {
            Assert.IsNotNull(Return.Name);
        }

        [TestMethod]
        public void IntegrationGuildCreatedIsNotNull()
        {
            Assert.IsNotNull(Return.Created);
        }

        [TestMethod]
        public void IntegrationGuildCategoryIsNotNull()
        {
            Assert.IsNotNull(Return.Category);
        }

        [TestMethod]
        public void IntegrationGuildManagerIsNotNull()
        {
            Assert.IsNotNull(Return.Manager);
        }

        [TestMethod]
        public void IntegrationGuildDescriptionIsNotNull()
        {
            Assert.IsNotNull(Return.Description);
        }

        [TestMethod]
        public void IntegrationGuildWebsitenIsNotNull()
        {
            Assert.IsNotNull(Return.WebSite);
        }

        #region memberlist
        [TestMethod]
        public void IntegrationGuildMemberListIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Members.List);
        }

        [TestMethod]
        public void IntegrationGuildMemberListPageIsNotNull()
        {
            Assert.IsNotNull(Return.Members.Page);
        }

        [TestMethod]
        public void IntegrationGuildMemberListCountIsNotNull()
        {
            Assert.IsNotNull(Return.Members.Count);
        }

        [TestMethod]
        public void IntegrationGuildMemberListNameIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Members.List.Select(name => name.Name).ToList());
        }

        [TestMethod]
        public void IntegrationGuildMemberListDateIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Members.List.Select(name => name.Date).ToList());
        }
        #endregion

        #region Location
        public void IntegrationGuildLocationIsNotNull()
        {
            Assert.IsNotNull(Return.Location);
        }
        public void IntegrationGuildLocationAddr1IsNotNull()
        {
            Assert.IsNotNull(Return.Location.Addr1);
        }

        public void IntegrationGuildLocationCityIsNotNull()
        {
            Assert.IsNotNull(Return.Location.City);
        }

        public void IntegrationGuildLocationCountryIsNotNull()
        {
            Assert.IsNotNull(Return.Location.Country);
        }

        public void IntegrationGuildLocationPostalCodeIsNotNull()
        {
            Assert.IsNotNull(Return.Location.PostalCode);
        }

        public void IntegrationGuildLocationStateIsNotNull()
        {
            Assert.IsNotNull(Return.Location.StateOrProvince);
        }
        #endregion
    }
}
