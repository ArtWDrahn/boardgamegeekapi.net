namespace BGGAPI_UnitTests.Shared
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Shared
    {
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

        public static string RandomString(int size)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor((26 * Random.NextDouble()) + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public static List<char> RandomChar(int size)
        {
            var builder = new List<char>();
            for (int i = 0; i < size; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor((26 * Random.NextDouble()) + 65)));
                builder.Add(ch);
            }

            return builder;
        }

        public static int GiveMeANetworkPortNumber()
        {
            var exclude = new HashSet<int> { 80, 443 };
            var range = Enumerable.Range(0, 65535);

            var rand = new Random();
            int index = rand.Next(0, 65535 - exclude.Count);
            return range.ElementAt(index);
        }

        public static int Integer(int max = Int16.MaxValue)
        {
            max = max > Int16.MaxValue ? Int16.MaxValue : max;
            return new Random().Next(1, max);
        }

        public string Binary(int length = 8)
        {
            int decNum = new Random().Next(1000, int.MaxValue);
            return Convert.ToString(decNum, 2)
                .Substring(0, length);
        }

        public DateTime Date(int startYear = 1995)
        {
            var start = new DateTime(startYear, 1, 1);
            int range = (DateTime.Today - start)
                .Days;
            return start.AddDays(new Random().Next(range))
                .AddSeconds(new Random().Next(86400));
        }

        public TimeSpan Time()
        {
            return this.Date().TimeOfDay;
        }

        public int Bit()
        {
            return new Random().Next() % 2 == 0 ? 1 : 0;
        }

        public static bool Bool()
        {
            return new Random().Next() % 2 == 0 ? true : false;
        }

        public string String(int limit = 255)
        {
            // added spaces so there will be 
            // a higher chance of spacing words
            const string legal = "        abcdefghijklmnopqrstuvwxyz" +
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789      ";

            var s = new StringBuilder();

            //Random length for the string
            limit = new Random().Next(1, limit);
            for (int i = 0; i < limit; i++)
            {
                s.Append(legal[new Random().Next(legal.Length)]);
            }

            return s.ToString();
        }
    }

    public static class EnumerableExtension
    {
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
