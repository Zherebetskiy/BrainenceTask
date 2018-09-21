using BrainenceTask.DAL;
using BrainenceTask.Models;
using FileWorkLibrary;
using System;
using System.Collections.Generic;

namespace BrainenceTask.BusinessLogic
{
    public class WordBL : IWordBL
    {
        private WordContext context = new WordContext();
        WordSearcher wordSearcher;

        public IEnumerable<SearchWord> Get()
        {
            return context.Set<SearchWord>();
        }

        public void Save(string url, string word)
        {
            wordSearcher = new WordSearcher(url);
            Dictionary<string, int> amountOfEntry = wordSearcher.GetSentencesWithCurrentWord(word);

            foreach (var entry in amountOfEntry.Keys)
            {
                context.Set<SearchWord>().Add(
                    new SearchWord
                    {
                        Word = word,
                        Amount = amountOfEntry[entry],
                        Sentence = Reverse(entry)
                    }
                    );
            }

            context.SaveChanges();
        }

        string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
