using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainenceTask.Models
{
    public class SearchWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Sentence { get; set; }
        public int Amount { get; set; }
    }
}
