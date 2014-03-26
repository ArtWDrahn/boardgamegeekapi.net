// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Establishes the Client class for interacting with Board Game Geek.
//   This is just a start and currently all methods for interacting with the objects are stored here.
//   A refactoring of this is likely in order as the CallBGG method is not exposed to be easily testable.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RestSharp;

    /// <summary>
    /// The client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The default serializer.
        /// </summary>
        private static readonly Func<object, string> DefaultSerializer = o => o.ToString();

        /// <summary>
        /// The type.
        /// </summary>
        private static readonly IDictionary<Type, Func<object, string>> TypeSerializers =
            new Dictionary<Type, Func<object, string>>
                {
                    { typeof(bool), o => (bool)o ? "1" : null },

                    // We list bool? explicitly as we want different behaviour in the false case from the
                    // simple bool serialization
                    { typeof(bool?), o => ((bool?)o).Value ? "1" : "0" },
                    { typeof(DateTime), o => ((DateTime)o).ToString("yy-MM-dd HH:mm:ss") },
                    { typeof(List<int>), o => string.Join(",", (List<int>)o) },
                };

        /// <summary>
        /// Requests information about a user's collection
        /// </summary>
        /// <param name="collectionRequest">Details of the request</param>
        /// <returns>Details of the user's collection</returns>
        public Collection.Return GetCollection(Collection.Request collectionRequest)
        {
            if (string.IsNullOrEmpty(collectionRequest.UserName))
            {
                throw new ArgumentException("Null or empty username in collectionRequest");
            }

            return CallBGG<Collection.Return>("collection", collectionRequest);
        }

        /// <summary>
        /// Requests information about specific BGG objects
        /// </summary>
        /// <param name="thingsRequest">Details of the request</param>
        /// <returns>Details on the requested objects</returns>
        public Thing.Return GetThings(Thing.Request thingsRequest)
        {
            if (thingsRequest.ID == null || !thingsRequest.ID.Any())
            {
                throw new ArgumentException("Null or empty list of IDs in thingsRequest");
            }

            return CallBGG<Thing.Return>("thing", thingsRequest);
        }

        /// <summary>
        /// Requests information about specific users in Board Game Geek
        /// </summary>
        /// <param name="userRequest">
        /// The user Request.
        /// </param>
        /// <returns>
        /// Details on the requested objects
        /// </returns>
        public Users.UserReturn GetUser(Users.Request userRequest)
        {
            if (userRequest.Name == null)
            {
                throw new ArgumentException("Null name in userRequest");
            }

            return CallBGG<Users.UserReturn>("user", userRequest);
        }

        /// <summary>
        /// Get the family of board games requested.
        /// </summary>
        /// <param name="familyRequest">
        /// The family request.
        /// </param>
        /// <returns>
        /// The Family <see cref="BGGAPI.Family.Return"/> Object.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// If no id is presented it returns an ArgumentException.
        /// </exception>
        public Family.Return GetFamily(Family.Request familyRequest)
        {
            if (familyRequest.ID == null)
            {
                throw new ArgumentException("Null ID in familyRequest");
            }

            return CallBGG<Family.Return>("family", familyRequest);
        }

        /// <summary>
        /// The get forum list.
        /// </summary>
        /// <param name="forumRequest">
        /// The forum request.
        /// </param>
        /// <returns>
        /// The <see cref="ForumList.Return"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// If no id is presented it returns an ArgumentException.
        /// </exception>
        public ForumList.Return GetFourmList(ForumList.Request forumRequest)
        {
            if (forumRequest.ID == 0)
            {
                throw new ArgumentException("Zero ID in forumRequest");
            }

            return CallBGG<ForumList.Return>("forumlist", forumRequest);
        }

        /// <summary>
        /// The get forums.
        /// </summary>
        /// <param name="forumRequest">
        /// The forum request.
        /// </param>
        /// <returns>
        /// The <see cref="Forums.Return"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// If no id is presented it returns an ArgumentException.
        /// </exception>
        public Forums.Return GetFourms(Forums.Request forumRequest)
        {
            if (forumRequest.ID == 0)
            {
                throw new ArgumentException("Zero ID in forumRequest");
            }

            return CallBGG<Forums.Return>("forum", forumRequest);
        }

        public Threads.Return GetThreads(Threads.Request threadRequest)
        {
            return CallBGG<Threads.Return>("threads", threadRequest);
        }

        public Plays.Return GetPlays(Plays.Request playRequest)
        {
            if (playRequest.ID == null && playRequest.UserName == null)
            {
                throw new ArgumentException("ID and UserName are null.");
            }

            return CallBGG<Plays.Return>("plays", playRequest);
        }

        /// <summary>
        /// Requests information about specific BGG objects
        /// </summary>
        /// <param name="thingsRequest">Details of the request</param>
        /// <returns>Details on the requested objects</returns>
        public Dictionary<int, List<Thing.Comments.Comment>> GetComments(Thing.Comments.CommentRequest thingsRequest)
        {
            if (thingsRequest.ID == null || !thingsRequest.ID.Any())
            {
                throw new ArgumentException("Null or empty list of IDs in thingsRequest");
            }

            var returnRequest = CallBGG<Thing.Comments.Return>("thing", thingsRequest);

            var comDictionary = new Dictionary<int, List<Thing.Comments.Comment>>();

            foreach (Thing.Comments.Item item in returnRequest.Items)
            {
                var comments = item.Comments.Select(comment =>
                    new Thing.Comments.Comment
                    {
                        Rating = comment.Rating,
                        UserName = comment.UserName,
                        value = comment.value
                    }).ToList();
                comDictionary.Add(item.ID, comments);
            }

            return comDictionary;
        }

        /// <summary>
        /// Requests information about specific BGG objects
        /// </summary>
        /// <param name="thingsRatingsRequest">Details of the request</param>
        /// <returns>Details on the requested objects</returns>
        public Dictionary<int, List<Thing.Comments.Comment>> GetRatingComments(Thing.Comments.RatingsRequest thingsRatingsRequest)
        {
            if (thingsRatingsRequest.ID == null || !thingsRatingsRequest.ID.Any())
            {
                throw new ArgumentException("Null or empty list of IDs in thingsRequest");
            }

            if (thingsRatingsRequest.ID == null || !thingsRatingsRequest.ID.Any())
            {
                throw new ArgumentException("Null or empty list of IDs in thingsRequest");
            }

            var returnRequest = CallBGG<Thing.Comments.Return>("thing", thingsRatingsRequest);

            var comDictionary = new Dictionary<int, List<Thing.Comments.Comment>>();

            foreach (Thing.Comments.Item item in returnRequest.Items)
            {
                var comments = item.Comments.Select(comment =>
                    new Thing.Comments.Comment
                    {
                        Rating = comment.Rating,
                        UserName = comment.UserName,
                        value = comment.value
                    }).ToList();
                comDictionary.Add(item.ID, comments);
            }

            return comDictionary;
        }

        public Hot.Return GetHotList(Hot.Request hotRequest)
        {
            return CallBGG<Hot.Return>("hot", hotRequest);
        }

        public Guilds.Return GetGuild(Guilds.Request guildRequest)
        {
            if (guildRequest.ID == 0)
            {
                throw new ArgumentException("Guild does not exist.");
            }

            return CallBGG<Guilds.Return>("guild", guildRequest);
        }

        //public Guilds.Return GetGuild(Guilds.Request guildRequest, bool allMembers)
        //{
        //    if (guildRequest.ID == 0)
        //    {
        //        throw new ArgumentException("Guild does not exist.");
        //    }

        //    var guild = CallBGG<Guilds.Return>("guild", guildRequest);
        //    var pages = Convert.ToInt32(GetMaxPages(guild.Members.Count, 25));

        //    for (int i = 0; i < pages; i++)
        //    {
        //        var recurse = new Guilds.Request { ID = 6, Members = true, Page = i };
        //        var members = this.GetGuild(recurse).Members.Member.ToList();
        //    }
        //    return;
        //}


        /// <summary>
        /// Call Board Game Geek.
        /// </summary>
        /// <param name="resource">
        /// The resource.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <typeparam name="T">
        /// Unknown Unknown
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>
        /// </returns>
        /// <exception cref="Exception">
        /// Unknown Exception
        /// </exception>
        private static T CallBGG<T>(string resource, object request) where T : new()
        {
            var client = new RestClient { BaseUrl = Url.BoardGameUrl };

            // http://technet.weblineindia.com/web/basics-of-restsharp-in-dot-net/2/
            // client.CookieContainer = new System.Net.CookieContainer();

            var restRequest = new RestRequest { Resource = resource };
            foreach (var parameter in SerializeRequest(request))
            {
                restRequest.AddParameter(parameter.Key, parameter.Value);
            }

            var response = client.Execute<T>(restRequest);
            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }

            return response.Data;
        }

        /// <summary>
        /// The serialize request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        private static IEnumerable<KeyValuePair<string, string>> SerializeRequest(object request)
        {
            var parameters = new Dictionary<string, string>();

            foreach (var propertyInfo in request.GetType().GetProperties())
            {
                var value = propertyInfo.GetValue(request);
                if (value == null)
                {
                    continue;
                }

                Func<object, string> serializer;

                var propertyType = propertyInfo.PropertyType;
                if (!TypeSerializers.TryGetValue(propertyType, out serializer))
                {
                    // If this was a nullable type, look for a serializer for the underlying type
                    var underlyingType = Nullable.GetUnderlyingType(propertyType);
                    if (underlyingType != null)
                    {
                        TypeSerializers.TryGetValue(underlyingType, out serializer);
                    }
                }

                if (serializer == null)
                {
                    serializer = DefaultSerializer;
                }

                var serializedValue = serializer(value);
                if (serializedValue != null)
                {
                    parameters.Add(propertyInfo.Name.ToLower(), serializedValue);
                }
            }

            return parameters;
        }

        private static double GetMaxPages(int count, int divisor)
        {
            var math = count / (double)divisor;
            return Math.Ceiling(math);
        }
    }
}
