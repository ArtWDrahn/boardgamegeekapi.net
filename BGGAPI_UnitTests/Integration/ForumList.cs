// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForumList.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Integration testing for the ForumList calls.
//   <see cref="Request" /> for the request call.
//   <see cref="Return" /> for returned call.
//   <see cref="Forum" /> for the individual forums returned in the returned call.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using System.Linq;

    using BGGAPI;
    using BGGAPI.ForumList;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Integration testing for the ForumList calls.
    /// <see cref="Request"/> for the request call.
    /// <see cref="BGGAPI.ForumList.Return"/> for returned call.
    /// <see cref="Forum"/> for the individual forums returned in the returned call.
    /// </summary>
    [TestClass]
    public class ForumList
    {
        /// <summary>
        /// The request id for the test request.
        /// </summary>
        private const int RequestID = 42;

        /// <summary>
        /// Random thing generated from the list of returned forums.
        /// </summary>
        private int randomThingFourm;

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// Not currently used in these tests.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Gets or sets the Forum List.
        /// </summary>
        private static Return Return { get; set; }

        /// <summary>
        /// The setup of the integration testing.
        /// </summary>
        /// <param name="testContext">
        /// The test context. Not currently used.
        /// </param>
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            var client = new Client();

            var thingRequest = new Request { ID = RequestID };

            Return = client.GetFourmList(thingRequest);
        }

        /// <summary>
        /// The integration forum thing returns is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsIsNotNull()
        {
            Assert.IsNotNull(Return);
        }

        /// <summary>
        /// The integration forum thing returns correct id.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsCorrectID()
        {
            Assert.AreEqual(Return.ID, RequestID);
        }

        /// <summary>
        /// The integration forum thing returns correct type.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsCorrectType()
        {
            Assert.AreEqual(Return.Type, "thing");
        }

        /// <summary>
        /// The integration forum thing returns more than zero.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsMoreThanZero()
        {
            Assert.IsTrue(Return.Forums.Any());

            this.randomThingFourm = Shared.Shared.Integer(Return.Forums.Count());
        }

        /// <summary>
        /// The integration forum thing returns forum group id.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumGroupID()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].GroupID);
        }

        /// <summary>
        /// The integration forum thing returns Forum title.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumTitle()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].Title);
        }

        /// <summary>
        /// The integration forum thing returns forum no posting.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumNoPosting()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].NoPosting);
        }

        /// <summary>
        /// The integration forum thing returns forum description.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumDescription()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].Description);
        }

        /// <summary>
        /// The integration forum thing returns forum number of threads.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumNumThreads()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].NumThreads);
        }

        /// <summary>
        /// The integration forum thing returns forum number of posts.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumNumPosts()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].NumPosts);
        }

        /// <summary>
        /// The integration forum thing returns forum number of posts.
        /// </summary>
        [TestMethod]
        public void IntegrationForumThingReturnsForumLastPostDate()
        {
            Assert.IsNotNull(Return.Forums[this.randomThingFourm].LastPostDate);
        }
    }
}
