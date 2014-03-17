// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Forums.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Integration testing for the Forum API calls.
//   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
//   See <see cref="BGGAPI.Forums.Return" /> for the return response.
//   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Forums;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    ///   Integration testing for the Forum API calls.
    ///   See <see cref="BGGAPI.Forums.Request" /> for the Request calls
    ///   See <see cref="BGGAPI.Forums.Return" /> for the return response.
    ///   See <see cref="BGGAPI.Forums.Thread" /> for the individual threads returned.
    /// </summary>
    [TestClass]
    public class Forums
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Gets or sets the forum return.
        /// </summary>
        private static Return ForumReturn { get; set; }

        /// <summary>
        /// Gets or sets the forum request.
        /// </summary>
        private static Request ForumRequest { get; set; }

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
            ForumRequest = new Request { ID = 3 };
            ForumReturn = client.GetFourms(ForumRequest);
        }

        /// <summary>
        /// Check that the forums id equal to request.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsIDEqualToRequest()
        {
            Assert.IsTrue(ForumReturn.ID == ForumRequest.ID);
        }

        /// <summary>
        /// Check that the forums title not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsTitleNotNull()
        {
            Assert.IsNotNull(ForumReturn.Title);
        }

        /// <summary>
        /// Check that the forums number of threads is greater than zero.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsNumThreadsGreaterThanZero()
        {
            Assert.IsTrue(ForumReturn.NumThreads > 0);
        }

        /// <summary>
        /// Check that the forums number of is posts greater than zero.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsNumPostsGreaterThanZero()
        {
            Assert.IsTrue(ForumReturn.NumPosts > 0);
        }

        [TestMethod]
        public void IntegrationForumsNoPostingIsTrue()
        {
            // TODO: Fake this test? Or remove it.
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Check that the forums date not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsDateNotNull()
        {
            Assert.IsNotNull(ForumReturn.LastPostDate);
        }

        /// <summary>
        /// Check that the forums thread count greater than zero.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadCountGreaterThanZero()
        {
            Assert.IsTrue(ForumReturn.Threads.Any());
        }

        /// <summary>
        /// Check that the forums thread id are unique.
        /// The idea of this test is to assure that we have different IDs for everything returned.
        /// This should also catch any nulls if there is a problem with the request.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadIdAreUnique()
        {
            CollectionAssert.AllItemsAreUnique(ForumReturn.Threads.Select(x => x.ID).ToList());
        }

        /// <summary>
        /// Check that the forums thread subject is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadSubjectIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ForumReturn.Threads.Select(x => x.Subject).ToList());
        }

        /// <summary>
        /// Check that the forums thread author is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadAuthorIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ForumReturn.Threads.Select(x => x.Author).ToList());
        }

        /// <summary>
        /// Check that the forums thread number of articles is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadNumberofArticlesIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ForumReturn.Threads.Select(x => x.NumArticles).ToList());
        }

        /// <summary>
        /// Check that the forums thread post date is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadPostDateIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ForumReturn.Threads.Select(x => x.PostDate).ToList());
        }

        /// <summary>
        /// Check that the forums thread last post date is not null.
        /// </summary>
        [TestMethod]
        public void IntegrationForumsThreadLastPostDateIsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ForumReturn.Threads.Select(x => x.LastPostDate).ToList());
        }
    }
}
