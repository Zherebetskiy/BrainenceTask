using BrainenceTask.Models;
using System.Collections.Generic;

namespace BrainenceTask.DAL
{
    public interface IRepository
    {
        IEnumerable<SearchWord> GetAll();

        void Create(SearchWord entity);

        void SaveChanges();
    }
}
