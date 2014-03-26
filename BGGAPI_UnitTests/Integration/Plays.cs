using System;
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
    }
}
