namespace BGGAPI_UnitTests.UnitTesting
{
    using BGGAPI;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Collection
    {
        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        public static BGGAPI.Collection.Collection CollectionReturn { get; set; }

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

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
            var collectionRequest = new BGGAPI.Collection.Request { UserName = "tysonjhayes" };
            CollectionReturn = client.GetCollection(collectionRequest);
        }

        [TestMethod]
        public void Collection_ReturnsMoreThenZero()
        {
            Assert.IsTrue(CollectionReturn.TotalItems > 0);
        }

        [TestMethod]
        public void Collection_NameIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Name);
        }

        [TestMethod]
        public void Collection_YearIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].YearPublished);
        }

        [TestMethod]
        public void Collection_ImageIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Image);
        }

        [TestMethod]
        public void Collection_ThumbnailIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Thumbnail);
        }

        [TestMethod]
        public void Collection_NumPlaysIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].NumPlays);
        }

        [TestMethod]
        public void Collection_StatusIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status);
        }

        [TestMethod]
        public void Collection_Status_OwnIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status.Own);
        }

        [TestMethod]
        public void Collection_Status_PrevOwnedIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status.PreviouslyOwned);
        }

        [TestMethod]
        public void Collection_Status_ForTradeIsNotNull()
        {
            Assert.IsNotNull(CollectionReturn.Items[0].Status.ForTrade);
        }
    }
}
