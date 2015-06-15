using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeVote.Models
{
    public class Candidate
    {
        public Candidate()
        {
            VoteCount = 0;
            IsActive = true;
        }
        public int ID { get; set; }
        public int VoteCount { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
