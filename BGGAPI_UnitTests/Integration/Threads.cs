using System.Linq;

namespace BGGAPI_UnitTests.Integration
{
    using BGGAPI;
    using BGGAPI.Threads;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class Threads
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        public static Return ThreadsReturn { get; set; }

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
            var threadsRequest = new Request { ID = 1, MinArticleID = 1, Count = 100};
            ThreadsReturn = client.GetThreads(threadsRequest);
        }

        [TestMethod]
        public void IntegreationThreadsIDNotNull()
        {
            Assert.IsNotNull(ThreadsReturn.ID);
        }

        [TestMethod]
        public void IntegrationThreadsNumArticlesNotNull()
        {
            Assert.IsNotNull(ThreadsReturn.NumArticles);
        }

        [TestMethod]
        public void IntegrationThreadsLinkNotNull()
        {
            Assert.IsNotNull(ThreadsReturn.Link);
        }

        [TestMethod]
        public void IntegrationThreadsSubjectNotNull()
        {
            Assert.IsNotNull(ThreadsReturn.Subject);
        }


        [TestMethod]
        public void IntegrationThreadsArticlesNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.ID).ToList());
        }

        [TestMethod]
        public void IntegrationThreadsUserNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.UserName).ToList());
        }

        [TestMethod]
        public void IntegrationThreadsLinksNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.Link).ToList());
        }

        [TestMethod]
        public void IntegrationThreadsPostDateNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.PostDate).ToList());
        }
    }
}
