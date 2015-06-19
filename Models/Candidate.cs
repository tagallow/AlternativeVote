using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    public class Candidate
    {
        public Candidate()
        {

        }
        public Candidate(int id, string name)
        {
            VoteCount = 0;
            IsActive = true;
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public int VoteCount { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
