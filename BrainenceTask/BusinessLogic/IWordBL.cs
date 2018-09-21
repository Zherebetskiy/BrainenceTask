using BrainenceTask.Models;
using System.Collections.Generic;

namespace BrainenceTask.BusinessLogic
{
    public interface IWordBL
    {
        IEnumerable<SearchWord> Get();
        void Save(string url, string word);
    }
}
