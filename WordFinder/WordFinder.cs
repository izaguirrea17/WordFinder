namespace WordFinder
{
    public class WordFinder
    {
        private readonly List<string> matrix;
        private readonly int numRows;
        private readonly int numCols;

        public WordFinder(IEnumerable<string> matrix)
        {
            //The constructor sets global values
            this.matrix = matrix.ToList();
            numRows = 64;
            numCols = 64;
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            //I used Hashset so I don't need to look for duplicated values
            var wordSet = new HashSet<string>(wordstream); 
            var wordCount = new Dictionary<string, int>();

            //Count how many times each word appears in the matrix and add the information in the dictionary
            foreach (var word in wordSet)
            {
                wordCount.Add(word, CountWord(word));
            }

            //Sort the dictionary by value to know which are the top 10 words
            return wordCount
                .OrderByDescending(kv => kv.Value)
                .Take(10)
                .Select(kv => kv.Key);
        }

        public int CountWord(string word)
        {
            int count=0;
            //Look for the word horizontally
            for (int row = 0; row < numRows; row++)
            {
                if (matrix[row].Contains(word))
                    count++;
            }

            //Look for the word vertically
            for (int col = 0; col < numCols; col++)
            {
                string verticalWord = string.Empty;
                for (int row = 0; row < numRows; row++)
                {
                    verticalWord += matrix[row][col];
                }
                if (verticalWord.Contains(word))
                    count++;
            }
            //IMPORTANT: I assumed a word could be only once by row or column, It wasn't specified in the problem
            return count;
        }

    }
}
