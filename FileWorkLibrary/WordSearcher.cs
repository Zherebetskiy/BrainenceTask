using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FileWorkLibrary
{
    public class WordSearcher
    {
        string[] splitedText;

        public Dictionary<string,int> GetSentencesWithCurrentWord(string word)
        {
            Dictionary<string, int> amountOfEntry = new Dictionary<string, int>();

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

        public void SplitText(string text)
        {
            splitedText = text.Split('.');
        }
    }
}
