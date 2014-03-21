// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BoardGameComments.cs" company="">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Tests Comments on Board Game Things
//   <see cref="Return" /> for the returned object.
//   <see cref="Comment" /> for more about the Comment Object.
//   <see cref="Request" /> for more on the Request type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Integration.Thing
{
    using System.Collections.Generic;
    using System.Linq;

    using BGGAPI;
    using BGGAPI.Thing.Comments;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests Comments on Board Game Things
    /// <see cref="Return"/> for the returned object.
    /// <see cref="Comment"/> for more about the Comment Object.
    /// <see cref="CommentRequest"/> for more on the Comment Request type.
    /// <see cref="RatingsRequest"/> for more on the Comment Request type.
    /// </summary>
    [TestClass]
    public class BoardGameComments
    {
        /// <summary>
        /// The game id.
        /// </summary>
        private static readonly List<int> GameID = new List<int> { 1, 42 };

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Gets or sets the returned comment object.
        /// </summary>
        private static Dictionary<int, List<Comment>> CommentReturn { get; set; }

        /// <summary>
        /// Gets or sets the returned ratings object.
        /// </summary>
        private static Dictionary<int, List<Comment>> RatingsReturn { get; set; }

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
            var commentRequest = new CommentRequest { ID = GameID, Comments = true, Page = 2, PageSize = 100 };
            CommentReturn = client.GetComments(commentRequest);

            var ratingsRequest = new RatingsRequest { ID = GameID, RatingComments = true, Page = 2, PageSize = 100 };
            RatingsReturn = client.GetRatingComments(ratingsRequest);
        }

        /// <summary>
        /// The board game comments value is not null.
        /// </summary>
        [TestMethod]
        public void BoardGameCommentsValueNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(CommentReturn.Select(key => key.Value.Select(comment => comment.value)).ToList());
        }

        /// <summary>
        /// The board game comments rating is not null.
        /// </summary>
        [TestMethod]
        public void BoardGameCommentsRatingNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(CommentReturn.Select(key => key.Value.Select(comment => comment.Rating)).ToList());
        }

        /// <summary>
        /// The board game comments user name not null.
        /// </summary>
        [TestMethod]
        public void BoardGameCommentsUserNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(CommentReturn.Select(key => key.Value.Select(comment => comment.UserName)).ToList());
        }

        /// <summary>
        /// The board game comments value is not null.
        /// </summary>
        [TestMethod]
        public void BoardGameRequestValueNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(RatingsReturn.Select(key => key.Value.Select(comment => comment.value)).ToList());
        }

        /// <summary>
        /// The board game comments rating is not null.
        /// </summary>
        [TestMethod]
        public void BoardGameRequestRatingNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(RatingsReturn.Select(key => key.Value.Select(comment => comment.Rating)).ToList());
        }

        /// <summary>
        /// The board game comments user name not null.
        /// </summary>
        [TestMethod]
        public void BoardGameRequestUserNameNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(RatingsReturn.Select(key => key.Value.Select(comment => comment.UserName)).ToList());
        }
    }
}
