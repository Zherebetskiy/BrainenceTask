using BrainenceTask.DAL;
using BrainenceTask.Models;
using FileWorkLibrary;
using System;
using System.Collections.Generic;

namespace BrainenceTask.BusinessLogic
{
    public class WordBL : IWordBL
    {
        readonly IRepository repository;
        WordSearcher wordSearcher;

        public WordBL(IRepository repository)
        {
            this.repository = repository;
            wordSearcher = new WordSearcher();
        }

        public IEnumerable<SearchWord> Get()
        {
            return repository.GetAll();
        }

        public void Save(string text, string word)
        {
            wordSearcher.SplitText(text);
            Dictionary<string, int> amountOfEntry = wordSearcher.GetSentencesWithCurrentWord(word);

            foreach (var entry in amountOfEntry.Keys)
            {
                repository.Create(
                new SearchWord
                {
                    Word = word,
                    Amount = amountOfEntry[entry],
                    Sentence = Reverse(entry)
                }
                    );
            }

            repository.SaveChanges();
        }

        string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
