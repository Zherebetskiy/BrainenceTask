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
        public DbSet<SearchWord> SearchWords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YAROSLAV\SQLEXPRESS;Database=BrainenceTask;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
