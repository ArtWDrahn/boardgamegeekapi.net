using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BGGAPI_UnitTests.UnitTesting
{
    using System.IO;
    using System.Net;
    using System.Xml.Linq;

    using BGGAPI;

    using Moq;

    using global::RestSharp;
    using BGG;

    /// <summary>
    /// Summary description for RestSharp
    /// </summary>
    [TestClass]
    public class RestSharp
    {
        public RestSharp()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        public void Collection_UnitTest()
        {
            // Read in the XML Data
            string testData = XDocument.Load(Path.GetFullPath(@"D:\GitHub\BGGAPI\BGGAPI_UnitTests\Files\Collection_User.xml")).ToString();

            // Mock IRestClient to return the testData instead of the BGG data.
            var mock = new Mock<IRestClient>();
            mock.Setup(x => x.Execute(It.IsAny<RestRequest>()))
            .Returns(new RestResponse
            {
                StatusCode = HttpStatusCode.OK,
                Content = testData,
            });

            var request = new RestRequest();
            var response = mock.Object.Execute<BGGAPI.Collection.Collection>(request);
            Assert.IsTrue(response.Data.TotalItems > 0);
        }

    }
}
