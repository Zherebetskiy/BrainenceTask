using BrainenceTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainenceTask.DAL
{
    public class WordContext : DbContext
    {
        public WordContext(DbContextOptions<WordContext> options)
            : base(options)
        {
        }

        public DbSet<SearchWord> SearchWords { get; set; }
    }
}
