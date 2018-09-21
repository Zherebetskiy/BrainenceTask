using BrainenceTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainenceTask.BusinessLogic
{
    public interface IWordBL
    {
        IEnumerable<SearchWord> Get();
        void Save(string url, string word);
    }
}
