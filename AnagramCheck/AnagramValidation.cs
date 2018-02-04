
using System.Linq;

namespace AnagramCheck
{
    public class AnagramValidation
    {
        private readonly WordCount.WordCountValidation wordCount;

        public AnagramValidation()
        {
            wordCount = new WordCount.WordCountValidation();
        }

        public bool IsAnagram(string word1, string word2)
        {
            var word1Count = wordCount.CountWords(word1);

            var word2Count = wordCount.CountWords(word2);

            if (word1Count.Count != word2Count.Count)
                return false;

            var word1Ordered = word1Count.OrderBy(w => w.Key);
            var word2Ordered = word2Count.OrderBy(w => w.Key);

            for (int i = 0; i < word1Count.Count; i++)
            {
                var current1Letter = word1Ordered.ElementAt(i);
                var current2Letter = word2Ordered.ElementAt(i);

                if (current1Letter.Key != current2Letter.Key || current1Letter.Value != current2Letter.Value)
                    return false;
            }
            return true;
        }
    }
}
