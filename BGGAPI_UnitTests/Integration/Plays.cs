using System;
using System.Linq;
using BGGAPI;
using BGGAPI.Plays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BGGAPI_UnitTests.Integration
{
    [TestClass]
    public class Plays
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        public static Return PlaysUserReturn { get; set; }

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
            var playsUserRequest = new Request { UserName = "tysonjhayes" };
            PlaysUserReturn = client.GetPlays(playsUserRequest);
        }

        [TestMethod]
        public void IntegrationPlaysUserNameIsEqualToRequest()
        {
            Assert.AreEqual("tysonjhayes", PlaysUserReturn.UserName);
        }

        [TestMethod]
        public void IntegrationPlaysUserIDIsGreaterThanZero()
        {
            Assert.IsTrue(PlaysUserReturn.UserID > 0);
        }

        [TestMethod]
        public void IntegrationPlaysTotalGreaterThanZero()
        {
            Assert.IsTrue(PlaysUserReturn.Total > 0);
        }

        [TestMethod]
        public void IntegrationPlaysPageGreaterThanZero()
        {
            Assert.IsTrue(PlaysUserReturn.Page > 0);
        }

        [TestMethod]
        public void IntegrationPlaysPlayIsNotNull()
        {
            Assert.IsNotNull(PlaysUserReturn.Plays);
        }

        [TestMethod]
        public void IntegrationPlaysPlayIDIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.ID).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayDateTimeIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Date).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayQuanitityIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Quantity).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayLengthIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Length).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayIncompleteIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Incomplete).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayLocationIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Location).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayNoWinStatsIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.NoWinStats).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayItemIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Item).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayItemObjectTypeIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Item).Select(item => item.ObjectType).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayItemObjectIDIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Item).Select(item => item.ObjectId).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayItemNameIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Item).Select(item => item.Name).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayItemSubTypesIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Item).Select(item => item.SubTypes).Select(value => value).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(plays => plays.Players).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersUserNameIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.UserName)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersUserIDIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.UserID)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersNameIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.Name)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersStartPositionIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.StartPosition)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersColorIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.Color)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersScoreIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.Score)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersNewIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.New)).ToList());
        }

        [TestMethod]
        public void IntegrationPlaysPlayPlayersWinIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(PlaysUserReturn.Plays.Select(play => play.Players).Select(players => players.Select(player => player.Win)).ToList());
        }
    }
}
