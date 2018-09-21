using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FileWorkLibrary
{
    public class WordSearcher
    {
        FileSplitter fileSplitter;

        public WordSearcher(string fileUrl)
        {
            fileSplitter = new FileSplitter(fileUrl);
        }

        public Dictionary<string,int> GetSentencesWithCurrentWord(string word)
        {
            Dictionary<string, int> amountOfEntry = new Dictionary<string, int>();
            string[] splitedText = fileSplitter.GetSplitedTextBySentence();

            foreach (var sentence in splitedText)
            {
                var amount = Regex.Matches(sentence, word).Count;

                if (amount != 0)
                {
                    amountOfEntry.Add(sentence, amount);
                } 
            }

            return amountOfEntry;
        }
    }
}
