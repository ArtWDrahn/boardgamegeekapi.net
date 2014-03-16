namespace BGGAPI_UnitTests.Integration.Thing
{
    using System.Collections.Generic;
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Collection;
    using BGGAPI.Thing.Polls;
    using BGGAPI.Thing.Videos;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Integration testing for Thing Request type.
    /// This assumes that the request thing type is Board Game.
    /// <see cref="Request"/> for Request object
    /// <see cref="Return"/> for high level return object.
    /// <see cref="Item"/> for the individual item being returned.
    /// <see cref="Poll"/> for the poll data being returned.
    /// <see cref="Video"/> for video data being returned.
    /// </summary>
    [TestClass]
    public class BoardGame
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
            var thingsRequest = new BGGAPI.Thing.Request { ID = GameID, Videos = true };
            ReturnID = Shared.Shared.Integer(GameID.Count);
            Return = client.GetThings(thingsRequest);
        }

        #region static
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

        #endregion

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

        /// <summary>
        /// The thing item poll not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsNotNull()
        {
            Assert.IsNotNull(Return.Items[ReturnID].Polls);
        }

        /// <summary>
        /// The thing item polls names are not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsNameNotNull()
        {
            var pollNames = Return.Items[ReturnID].Polls.Select(poll => poll.Name).ToList();
            CollectionAssert.AllItemsAreNotNull(pollNames);
        }

        /// <summary>
        /// The thing item polls titles are not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsTitleNotNull()
        {
            var pollTitle = Return.Items[ReturnID].Polls.Select(poll => poll.Title).ToList();
            CollectionAssert.AllItemsAreNotNull(pollTitle);
        }

        /// <summary>
        /// The thing item polls total votes are not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsTotalVotesNotNull()
        {
            var pollVotes = Return.Items[ReturnID].Polls.Select(poll => poll.TotalVotes).ToList();
            CollectionAssert.AllItemsAreNotNull(pollVotes);
        }

        /// <summary>
        /// The thing item polls results not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsResultsNotNull()
        {
            var pollResults = Return.Items[ReturnID].Polls.Select(poll => poll.ResultsList).ToList();
            CollectionAssert.AllItemsAreNotNull(pollResults);
        }

        /// <summary>
        /// The thing item polls results values are not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsResultsValuesAreNotNull()
        {
            var finalResultsValue = (from poll in Return.Items[ReturnID].Polls from result in poll.ResultsList from item in result.ResultList select item.value).ToList();
            CollectionAssert.AllItemsAreNotNull(finalResultsValue);
        }

        /// <summary>
        /// The thing item polls results numbers are not null.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsResultsNumAreNotNull()
        {
            var finalResultsVotes = (from poll in Return.Items[ReturnID].Polls from result in poll.ResultsList from item in result.ResultList select item.NumVotes).ToList();
            CollectionAssert.AllItemsAreNotNull(finalResultsVotes);
        }

        /// <summary>
        /// The thing item polls results number of players is not null on number of players poll.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsResultsNumPlayersNotNullOnNumPlayersPoll()
        {
            var numPlayers = (from poll in Return.Items[ReturnID].Polls where poll.Name == "suggested_numplayers" from result in poll.ResultsList select result.NumPlayers).Cast<object>().ToList();
            Assert.IsTrue(numPlayers.Count > 0);
        }

        /// <summary>
        /// The thing item polls results level are not null on language dependence poll.
        /// </summary>
        [TestMethod]
        public void ThingItemPollsResultsLevelNotNullOnLanguageDependencePoll()
        {
            var dependenceLevel = (from poll in Return.Items[ReturnID].Polls where poll.Name == "language_dependence" from result in poll.ResultsList from item in result.ResultList select item.value).ToList();
            CollectionAssert.AllItemsAreNotNull(dependenceLevel);
        }
        #endregion

        #region Links

        /// <summary>
        /// The thing item links count greater then zero.
        /// </summary>
        [TestMethod]
        public void ThingItemLinksCountGreaterThenZero()
        {
            Assert.IsTrue(Return.Items[ReturnID].Links.Any());
        }

        /// <summary>
        /// The thing item links type not null.
        /// </summary>
        [TestMethod]
        public void ThingItemLinksTypeNotNull()
        {
            var linkType = Return.Items[ReturnID].Links.Select(item => item.Type).ToList();
            CollectionAssert.AllItemsAreNotNull(linkType);
        }

        /// <summary>
        /// The thing item links id not null.
        /// </summary>
        [TestMethod]
        public void ThingItemLinksIDNotNull()
        {
            var linkID = Return.Items[ReturnID].Links.Select(item => item.ID).ToList();
            CollectionAssert.AllItemsAreNotNull(linkID);
        }

        /// <summary>
        /// The thing item links value not null.
        /// </summary>
        [TestMethod]
        public void ThingItemLinksValueNotNull()
        {
            var linkValue = Return.Items[ReturnID].Links.Select(item => item.value).ToList();
            CollectionAssert.AllItemsAreNotNull(linkValue);
        }
        #endregion

        #region Videos

        /// <summary>
        /// The thing item video count greater than zero.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoCountGreaterThanZero()
        {
            Assert.IsTrue(Return.Items[ReturnID].Videos.Count > 0);
        }

        /// <summary>
        /// The thing item video id not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoIDNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.ID).ToList());
        }

        /// <summary>
        /// The thing item video titles not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoTitlesNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.Title).ToList());
        }

        /// <summary>
        /// The thing item video category not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoCategoryNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.Category).ToList());
        }

        /// <summary>
        /// The thing item video language not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoLanguageNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.Language).ToList());
        }

        /// <summary>
        /// The thing item video link not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoLinkNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.Link).ToList());
        }

        /// <summary>
        /// The thing item video user name not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoUserNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.UserName).ToList());
        }

        /// <summary>
        /// The thing item video user id not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoUserIDNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.UserId).ToList());
        }

        /// <summary>
        /// The thing item video post date not null.
        /// </summary>
        [TestMethod]
        public void ThingItemVideoPostDateNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].Videos.Select(video => video.PostDate).ToList());
        }
        #endregion

        // TODO: Statistics
        // TODO: MarketplaceListings
        // TODO: Comments
        // TODO: RatingsComments
        // TODO: Historical
    }
}
