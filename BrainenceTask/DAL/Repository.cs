using System.Collections.Generic;
using BrainenceTask.Models;

namespace BrainenceTask.DAL
{
    public class Repository : IRepository
    {
        public readonly WordContext context;


        public Repository(WordContext context)
        {
            this.context = context;
        }

        public void Create(SearchWord entity)
        {
            context.Set<SearchWord>().Add(entity);
        }

        public IEnumerable<SearchWord> GetAll()
        {
            return context.Set<SearchWord>();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
