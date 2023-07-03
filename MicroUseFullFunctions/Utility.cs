using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MicroUseFullFunctions
{
    public static class Utility
    {
        /// <summary>
        /// Split List<T> into nth Lists of List<List<T>>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        public static List<List<T>> ToChunk<T>(this IList<T> source, int chunkSize)
        => source
            .Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / chunkSize)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

        /// <summary>
        /// Delay for nth seconds
        /// </summary>
        /// <param name="durationIn"></param>
        /// <param name="debugVisible"></param>
        public static void Delay(TimeSpan durationIn, bool debugVisible = false)
        {
            var stopwatch = Stopwatch.StartNew();

            stopwatch.Start();
            while (stopwatch.Elapsed.TotalSeconds <= durationIn.Seconds)
            {
                if (debugVisible) Debug.WriteLine(stopwatch.Elapsed.TotalSeconds);
            }
            stopwatch.Stop();
        }

        /// <summary>
        /// Removes duplicates in List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="olist"></param>
        /// <returns></returns>
        public static List<T> RemoveDuplicates<T>(this List<T> olist) => olist.Distinct().ToList();

        /// <summary>
        /// Remove a string or remove a string[] of strings from the original string
        /// </summary>
        /// <param name="word"></param>
        /// <param name="wordsToRemove"></param>
        /// <returns></returns>
        public static string RemoveString(this string word , string[] wordsToRemove)
        {
            for (var ndx = 0; ndx < wordsToRemove.Length; ndx++)
            {
                word = word.Replace(wordsToRemove[ndx], "");
            }
            return word;
        }
    }
}
