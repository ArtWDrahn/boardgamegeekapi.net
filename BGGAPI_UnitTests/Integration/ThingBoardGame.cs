namespace BGGAPI_UnitTests.Integration
{
    using System.Collections.Generic;
    using System.Linq;

    using BGGAPI;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Integration testing for Board Game Things.
    /// </summary>
    [TestClass]
    public class ThingBoardGame
    {
        /// <summary>
        /// The game id.
        /// </summary>
        private static readonly List<int> GameID = new List<int> { 1, 42 };

        /// <summary>
        /// Gets or sets the returned thing object.
        /// </summary>
        private static BGGAPI.Thing.Return Return { get; set; }

        /// <summary>
        /// Gets or sets the Return ID
        /// Picking a random id produced in GameID to test against.
        /// This way if we expand the number of GameIDs to call we will
        /// always pick one at random to test against.
        /// </summary>
        private static int ReturnID { get; set; }

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
            var thingsRequest = new BGGAPI.Thing.Request { ID = GameID };
            ReturnID = Shared.Shared.Integer(GameID.Count);
            Return = client.GetThings(thingsRequest);
        }

        /// <summary>
        /// The integration thing returned ids match.
        /// Given we can accept multiple ids we need to make sure they are all being returned.
        /// </summary>
        [TestMethod]
        public void IntegrationThingIDsMatch()
        {
            var items = Return.Items.Select(item => item.ID).ToList();
            CollectionAssert.AreEqual(GameID, items);
        }

        /// <summary>
        /// The integration thing item types not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemTypesNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].Type);
        }

        /// <summary>
        /// The integration thing item description not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemDescriptionNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].Description);
        }

        /// <summary>
        /// The integration thing item thumbnail not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemThumbnailNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].Thumbnail);
        }

        /// <summary>
        /// The integration thing item image not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemImageNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].Image);
        }

        /// <summary>
        /// The integration thing item year published not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemYearPublishedNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].YearPublished);
        }

        /// <summary>
        /// The integration thing item min players not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemMinPlayersNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].MinPlayers);
        }

        /// <summary>
        /// The integration thing item max players not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemMaxPlayersNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].MaxPlayers);
        }

        /// <summary>
        /// The integration thing item play time not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemPlayTimeNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].PlayingTime);
        }

        /// <summary>
        /// The integration thing item min age not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemMinAgeNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].MinAge);
        }

        #region Name Tests
        /// <summary>
        /// The integration thing item names not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemNamesNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].Names);
        }

        /// <summary>
        /// The integration thing item names type not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemNamesTypeContainKnownValue()
        {
            var names = Return.Items[ReturnID].Names.Select(name => name.Type).ToList();

            CollectionAssert.Contains(names, names.Count > 1 ? "alternate" : "primary");
        }

        /// <summary>
        /// The integration thing item names sort index not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemNamesSortIndexNotNull()
        {
            var indexList = Return.Items[ReturnID].Names.Select(name => name.SortIndex).ToList();
            CollectionAssert.AllItemsAreNotNull(indexList);
        }

        /// <summary>
        /// The integration thing item names value not null.
        /// </summary>
        [TestMethod]
        public void IntegrationThingItemNamesValueNotNull()
        {
            var nameValue = Return.Items[ReturnID].Names.Select(name => name.value).ToList();
            CollectionAssert.AllItemsAreNotNull(nameValue);
        }

        #endregion

        #region Polls
        [TestMethod]
        public void Integratin
        #endregion
    }
}
