// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Threads.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Establishes the Threads Integration testing.
//   This will pull from a specified known good thread and run tests against it.
//   This should work against any ID but we know it has numofedits to confirm we're getting the correct property.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration
{
    using BGGAPI;
    using BGGAPI.Threads;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

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

        public static Return ThreadsReturnDateTime { get; set; }

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
            var threadsRequestDateTime = new Request { ID = 1000, MinArticleID = 1, Count = 100, MinArticleDate = "2006-04-02"};
            var threadsRequest = new Request { ID = 1000, MinArticleID = 1, Count = 100 };
            ThreadsReturn = client.GetThreads(threadsRequest);
            ThreadsReturnDateTime = client.GetThreads(threadsRequestDateTime);
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

        /// <summary>
        /// This test should show us that if we use the MinArticleDate it should return a different number of articles.
        /// </summary>
        [TestMethod]
        public void IntegrationThreadCountIsDifferent()
        {
            Assert.IsTrue(ThreadsReturn.Articles.Count() > ThreadsReturnDateTime.Articles.Count());
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

        [TestMethod]
        public void IntegrationThreadsNumEditsNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.NumEdits).ToList());
        }

        [TestMethod]
        public void IntegrationThreadsArticleSubjectNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.Subject).ToList());
        }

        [TestMethod]
        public void IntegrationThreadsArticleBodyNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ThreadsReturn.Articles.Select(thread => thread.Body).ToList());
        }
    }
}
