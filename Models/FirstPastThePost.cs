using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    public class FirstPastThePost : GenericElection
    {
        /// <summary>
        /// First past the post election system. Whoever has the most votes wins.
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="citizens"></param>
        public override void RunElection(List<Candidate> candidates, List<Citizen> citizens)
        {
            this.candidates = candidates;
            this.citizens = citizens;
            foreach(Citizen c in citizens)
            {
                GetCandidateByID(c.votes[0]).VoteCount++;
            }
            Candidate winner = candidates.OrderByDescending(c => c.VoteCount).First();
            Console.WriteLine("Winner: {0} with {1} votes",winner.Name,winner.VoteCount);
            
        }
    }
}
