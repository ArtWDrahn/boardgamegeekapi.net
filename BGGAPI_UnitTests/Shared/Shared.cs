// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Shared.cs" company="Tyson J. Hayes">
//   © 2014 - Refer to the License.md for the project.
// </copyright>
// <summary>
//   Defines the Shared type used for use in our tests.
//   This was liberally borrwed from a stack overflow post that I can no longer find.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BGGAPI_UnitTests.Shared
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The shared test methods for unit testing.
    /// </summary>
    public static class Shared
    {
        /// <summary>
        /// The random number used for random generation.
        /// </summary>
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// Generates a random string based on the size parameter passed in.
        /// </summary>
        /// <param name="size">
        /// The size of the string to be generated.
        /// </param>
        /// <returns>
        /// The <see cref="string"/> generated.
        /// </returns>
        public static string RandomString(int size)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor((26 * Random.NextDouble()) + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Generates a random set of characters based on the size parameter.
        /// </summary>
        /// <param name="size">
        /// The size of the list to be returned.
        /// </param>
        /// <returns>
        /// The list of characters returned.
        /// </returns>
        public static List<char> RandomChar(int size)
        {
            var builder = new List<char>();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor((26 * Random.NextDouble()) + 65)));
                builder.Add(ch);
            }

            return builder;
        }

        /// <summary>
        /// Gives a random network port number and excludes some known good ones.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GiveMeANetworkPortNumber()
        {
            var exclude = new HashSet<int> { 80, 443 };
            var range = Enumerable.Range(0, 65535);

            var rand = new Random();
            var index = rand.Next(0, 65535 - exclude.Count);
            return range.ElementAt(index);
        }

        /// <summary>
        /// Generates an random number positive number.
        /// </summary>
        /// <param name="max">
        /// The max number to be generated.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int Integer(int max = Int16.MaxValue)
        {
            max = max > Int16.MaxValue ? Int16.MaxValue : max;
            return new Random().Next(1, max);
        }

        /// <summary>
        /// Generates a random binary string.
        /// </summary>
        /// <param name="length">
        /// The length of the string to be generated.
        /// Default is 8.
        /// </param>
        /// <returns>
        /// The generated <see cref="string"/>.
        /// </returns>
        public static string Binary(int length = 8)
        {
            var decNum = new Random().Next(1000, Int32.MaxValue);
            return Convert.ToString(decNum, 2)
                .Substring(0, length);
        }

        /// <summary>
        /// Generates a random date based on the start year.
        /// </summary>
        /// <param name="startYear">
        /// The start year.
        /// Default is 1995.
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>.
        /// </returns>
        public static DateTime Date(int startYear = 1995)
        {
            var start = new DateTime(startYear, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(new Random().Next(range))
                .AddSeconds(new Random().Next(86400));
        }

        /// <summary>
        /// The time.
        /// </summary>
        /// <returns>
        /// The <see cref="TimeSpan"/>.
        /// </returns>
        public static TimeSpan Time()
        {
            return Date().TimeOfDay;
        }

        public static int Bit()
        {
            return new Random().Next() % 2 == 0 ? 1 : 0;
        }

        public static bool Bool()
        {
            return new Random().Next() % 2 == 0;
        }

        public static string String(int limit = 255)
        {
            // added spaces so there will be 
            // a higher chance of spacing words
            const string Legal = "        abcdefghijklmnopqrstuvwxyz" +
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789      ";

            var s = new StringBuilder();

            // Random length for the string
            limit = new Random().Next(1, limit);
            for (int i = 0; i < limit; i++)
            {
                s.Append(Legal[new Random().Next(Legal.Length)]);
            }

            return s.ToString();
        }

        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}
