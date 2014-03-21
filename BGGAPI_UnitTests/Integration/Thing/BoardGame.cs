// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BoardGame.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Integration testing for Thing Request type.
//   This assumes that the request thing type is Board Game.
//   <see cref="BGGAPI.Thing.Request" /> for Request object
//   <see cref="Return" /> for high level return object.
//   <see cref="BGGAPI.Thing.Item" /> for the individual item being returned.
//   <see cref="Poll" /> for the poll data being returned.
//   <see cref="Video" /> for video data being returned.
//   <see cref="Statistics" /> for stats data being returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration.Thing
{
    using System.Collections.Generic;
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Thing;
    using BGGAPI.Thing.Polls;
    using BGGAPI.Thing.Videos;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Integration testing for Thing Request type.
    /// This assumes that the request thing type is Board Game.
    /// <see cref="BGGAPI.Thing.Request"/> for Request object
    /// <see cref="Return"/> for high level return object.
    /// <see cref="BGGAPI.Thing.Item"/> for the individual item being returned.
    /// <see cref="Poll"/> for the poll data being returned.
    /// <see cref="Video"/> for video data being returned.
    /// <see cref="Statistics"/> for stats data being returned.
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
        private static Return Return { get; set; }

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
            var thingsRequest = new Request { ID = GameID, Videos = true, Marketplace = true, Stats = true, Historical = true };
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

        #region Marketplace

        /// <summary>
        /// The thing item market place listing return list date.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingReturnListDate()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.ListDate.value).ToList());
        }

        /// <summary>
        /// The thing item market place listing price value not null.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingPriceValueNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.Price.value).ToList());
        }

        /// <summary>
        /// The thing item market place listing price currency not null.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingPriceCurrencyNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.Price.Currency).ToList());
        }

        /// <summary>
        /// The thing item market place listing condition value not null.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingConditionValueNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.Condition.value).ToList());
        }

        /// <summary>
        /// The thing item market place listing notes value not null.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingNotesValueNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.Notes.value).ToList());
        }

        /// <summary>
        /// The thing item market place listing link href not null.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingLinkHrefNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.Link.HRef).ToList());
        }

        /// <summary>
        /// The thing item market place listing link title not null.
        /// </summary>
        [TestMethod]
        public void ThingItemMarketPlaceListingLinkTitleNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(Return.Items[ReturnID].MarketplaceListing.Select(listing => listing.Link.Title).ToList());
        }
        #endregion

        // These tests are covering Stats and Historical as they are returned on the same fields.
        #region Statistics

        /// <summary>
        /// The thing item statistics ratings average not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsAverageNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Average.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings user rated not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsUserRatedNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.UsersRated.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings bayes average not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsBayesAverageNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.BayesAverage.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings standard deviation not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsStdDevNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.StdDev.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings median not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsMedianNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Median.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings owned not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsOwnedNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Owned.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings trading not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsTradingNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Trading.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings wanting not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsWantingNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Wanting.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings wishing not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsWishingNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Wishing.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings number of comments not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsNumCommentsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.NumComments.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings number of weights not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsNumWeightsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.NumWeights.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings average weight not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsAvgWeightNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.AverageWeight.value)).ToList());
        }

        /// <summary>
        /// The thing item statistics historical date not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsHistoricalDateNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Date)).ToList());
        }
        #endregion

        #region StatisticsRatingsRanks

        /// <summary>
        /// The thing item statistics ratings ranks id not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsRanksIDNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Ranks.Select(rank => rank.Id))).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings ranks type not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsRanksTypeNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Ranks.Select(rank => rank.Type))).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings ranks name not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsRanksNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Ranks.Select(rank => rank.Name))).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings ranks friendly name not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsRanksFriendlyNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Ranks.Select(rank => rank.FriendlyName))).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings ranks value not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsRanksValueNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Ranks.Select(rank => rank.value))).ToList());
        }

        /// <summary>
        /// The thing item statistics ratings ranks bayes average not null.
        /// </summary>
        [TestMethod]
        public void ThingItemStatisticsRatingsRanksBayesAverageNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(
                Return.Items.Select(item => item.Statistics.Rating.Select(ratings => ratings.Ranks.Select(rank => rank.BayesAverage))).ToList());
        }
        #endregion
    }
}
