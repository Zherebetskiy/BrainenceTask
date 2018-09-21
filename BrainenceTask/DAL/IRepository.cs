using BrainenceTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainenceTask.DAL
{
    public interface IRepository
    {
        IEnumerable<SearchWord> GetAll();

        void Create(SearchWord entity);

        void SaveChanges();
    }
}
