// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRequest.cs" company="Tyson J. Hayes" >
//  © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Does integration tests the BGGAPI.Users.Request by calling out to BGG and parsing over live data.
//   The user that was selected was done so randomly as they actually had most of the fields to parse over.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using System;

    using BGGAPI;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Does integration tests the BGGAPI.Users.Request by calling out to BGG and parsing over live data.
    /// The user that was selected was done so randomly as they actually had most of the fields to parse over.
    /// </summary>
    [TestClass]
    public class UserRequest
    {
        /// <summary>
        /// Gets or sets the user object that is parsed over.
        /// </summary>
        private static BGGAPI.Users.UserReturn UserReturn { get; set; }

        /// <summary>
        /// Gets or sets the list item that is randomly parsed over.
        /// </summary>
        private static int ListItem { get; set; }

        /// <summary>
        /// Gets or sets the buddy item that is randomly parsed over.
        /// </summary>
        private static int BuddyItem { get; set; }

        /// <summary>
        /// Gets or sets the guild item that is randomly parsed over.
        /// </summary>
        private static int GuildItem { get; set; }

        /// <summary>
        /// The setup of the User Tests.
        /// </summary>
        /// <param name="testContext">
        /// The test context.  Not actually used.
        /// </param>
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            // Pick a number 1 - 10 for the hot/top listing checks.
            ListItem = new Random().Next(1, 10);

            var client = new Client();

            // picking a user that actually has most of what we are trying to test against.
            var userRequest = new BGGAPI.Users.Request
                                  {
                                      Name = "dakarp",
                                      Top = true,
                                      Hot = true,
                                      Buddies = true,
                                      Guilds = true
                                  };
            UserReturn = client.GetUser(userRequest);
        }

        /// <summary>
        /// Check that the user returned id is not null.
        /// </summary>
        [TestMethod]
        public void UserReturnedIDIsNotNull()
        {
            Assert.IsNotNull(UserReturn.ID);
        }

        /// <summary>
        /// Check that the user returned name is not null.
        /// </summary>
        [TestMethod]
        public void UserReturnedNameIsNotNull()
        {
            Assert.IsNotNull(UserReturn.Name);
        }

        /// <summary>
        /// The user returned first name is not null.
        /// </summary>
        [TestMethod]
        public void UserReturnedFirstNameIsNotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.FirstName.value));
        }

        [TestMethod]
        public void User_ReturnedLastName_IsNotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.LastName.value));
        }

        [TestMethod]
        public void User_ReturnedAvatarLink_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.AvatarLink.value));
        }

        [TestMethod]
        public void User_YearRegistered_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.YearRegistered.value));
        }

        [TestMethod]
        public void User_LastLogin_NotNull()
        {
            Assert.IsNotNull(UserReturn.LastLogin.value);
        }

        [TestMethod]
        public void User_StateOrProvince_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.StateOrProvince.value));
        }

        [TestMethod]
        public void User_Country_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.Country.value));
        }

        [TestMethod]
        public void User_WebAddress_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.WebAddress.value));
        }

        [TestMethod]
        public void User_TradeRating_NotNull()
        {
            Assert.IsNotNull(UserReturn.TradeRating.value);
        }

        #region Social Media Tests
        //TODO: Assert a new account with these filled out so the tests actually pass.
        [TestMethod]
        public void User_XboxAccount_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.XboxAccount.value));
        }

        [TestMethod]
        public void User_PSNAcount_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.PSNAccount.value));   
        }

        [TestMethod]
        public void User_BattleNetAccount_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.BattleNetAccount.value));
        }

        [TestMethod]
        public void User_SteamAccount_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.SteamAccount.value));
        }

        [TestMethod]
        public void User_WiiAccount_NotNull()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(UserReturn.WiiAccount.value));
        }
        #endregion

        #region Top Tests
        [TestMethod]
        public void User_TopDomain_NotNull()
        {
            Assert.IsNotNull(UserReturn.Top.Domain);
        }

        [TestMethod]
        public void User_TopList_NotEmpty()
        {
            Assert.IsTrue(UserReturn.Top.Items.Count > 0);
        }

        public void User_TopListRank_EqualtoListItem()
        {
            Assert.AreEqual(UserReturn.Top.Items[ListItem].Rank, ListItem);
        }

        public void User_TopListName_NotNull()
        {
            Assert.IsNotNull(UserReturn.Top.Items[ListItem].Name);
        }

        public void User_TopListID_NotNull()
        {
            Assert.IsNotNull(UserReturn.Top.Items[ListItem].ID);
        }

        public void User_TopListType_IsThing()
        {
            Assert.AreEqual(UserReturn.Top.Items[ListItem].Type, "thing");
        }

        #endregion

        #region Hot Tests
        [TestMethod]
        public void User_HotDomain_NotNull()
        {
            Assert.IsNotNull(UserReturn.Top.Domain);
        }

        [TestMethod]
        public void User_HotList_NotEmpty()
        {
            Assert.IsTrue(UserReturn.Top.Items.Count > 0);
        }

        public void User_HotListRank_EqualtoListItem()
        {
            Assert.AreEqual(UserReturn.Top.Items[ListItem].Rank, ListItem);
        }

        public void User_HotListName_NotNull()
        {
            Assert.IsNotNull(UserReturn.Top.Items[ListItem].Name);
        }

        public void User_HotListID_NotNull()
        {
            Assert.IsNotNull(UserReturn.Top.Items[ListItem].ID);
        }

        public void User_HotListType_IsThing()
        {
            Assert.AreEqual(UserReturn.Top.Items[ListItem].Type, "thing");
        }

        #endregion

        #region Buddies
        [TestMethod]
        public void User_Buddies_GreaterThanZero()
        {
            Assert.IsTrue(UserReturn.Buddies.Total > 0);
        }

        [TestMethod]
        public void User_BuddiesPages_GreaterThanZero()
        {
            Assert.IsTrue(UserReturn.Buddies.Page > 0);
        }

        [TestMethod]
        public void User_BuddyList_GreaterThanZero()
        {
            Assert.IsTrue(UserReturn.Buddies.BuddyList.Count > 0);
            BuddyItem = new Random().Next(1, UserReturn.Buddies.BuddyList.Count);
        }

        [TestMethod]
        public void User_BuddyListID_IsNotNull()
        {
            Assert.IsNotNull(UserReturn.Buddies.BuddyList[BuddyItem].ID);
        }

        [TestMethod]
        public void User_BuddyListName_IsNotNull()
        {
            Assert.IsNotNull(UserReturn.Buddies.BuddyList[BuddyItem].Name);
        }
        #endregion

        #region Guilds
        [TestMethod]
        public void User_Guilds_GreaterThanZero()
        {
            Assert.IsTrue(UserReturn.Guilds.Total > 0);
        }

        [TestMethod]
        public void User_GuildsPages_GreaterThanZero()
        {
            Assert.IsTrue(UserReturn.Guilds.Page > 0);
        }

        [TestMethod]
        public void User_GuildList_GreaterThanZero()
        {
            Assert.IsTrue(UserReturn.Guilds.GuildList.Count > 0);
            GuildItem = new Random().Next(1, UserReturn.Guilds.GuildList.Count);
        }

        [TestMethod]
        public void User_GuildListID_IsNotNull()
        {
            Assert.IsNotNull(UserReturn.Guilds.GuildList[GuildItem].ID);
        }

        [TestMethod]
        public void User_GuildListName_IsNotNull()
        {
            Assert.IsNotNull(UserReturn.Guilds.GuildList[GuildItem].Name);
        }
        #endregion
    }
}
