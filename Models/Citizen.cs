using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeVote.Models
{
    public class Citizen
    {
        public Citizen(int[] ballot)
        {
            votes = new List<int>(ballot);
        }
        public List<int> votes { get; set; }
    }
}
