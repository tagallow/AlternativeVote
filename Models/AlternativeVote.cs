using ElectionTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    public class AlternativeVote : GenericElection
    {
        
        public AlternativeVote()
        {
            citizens = null;
            candidates = null;
        }

        #region Generic election methods
        override public void RunElection(List<Candidate> candidates, List<Citizen> citizens)
        {
            this.candidates = candidates;
            this.citizens = citizens;
            while (!IsElectionDone())
            {
                EliminateLowestCandidate();
            }
        }
        #endregion

        #region Alternative Vote specific methods
        private void EliminateLowestCandidate()
        {
            Candidate loser = new Candidate { ID = -1, VoteCount = int.MaxValue };
            foreach (Candidate candidate in candidates.Where(c => c.IsActive))
            {
                if (candidate.VoteCount < loser.VoteCount)
                {
                    loser.VoteCount = candidate.VoteCount;
                    loser.ID = candidate.ID;
                    loser.Name = candidate.Name;
                }
            }
            Console.WriteLine("{0} has been eliminated", loser.Name);
            candidates.Where(candidate => candidate.ID == loser.ID).FirstOrDefault().IsActive = false;
        }
        /// <summary>
        /// Every time a candidate is eliminated the votes need to be recounted, ignoring votes for that candidate.
        /// </summary>
        private void CountVotes()
        {
            foreach (Candidate candidate in candidates)
            {
                candidate.VoteCount = 0;
            }
            foreach (Citizen citizen in citizens)
            {
                int vote = GetNextVote(citizen);
                VoteForCandidate(vote);
            }
        }
        
        /// <summary>
        /// Cycles through each of a citizens vote, and casts their first valid vote.
        /// </summary>
        /// <returns>An integer representing the citizen's vote</returns>
        private int GetNextVote(Citizen c)
        {
            int vote = 0;
            for (int i = 0; i < c.votes.Count; i++)
            {
                if (CandidateIsActive(c.votes[i]))
                {
                    vote = c.votes[i];
                    break;
                }
            }
            return vote;
        }
        
        /// <summary>
        /// Election is over when one candidate has more than 50% of all votes, or is the only candidate left
        /// </summary>
        private bool IsElectionDone()
        {
            bool isDone = false;
            CountVotes();
            foreach (Candidate c in candidates)
            {
                //Checks if this candidate has more than half the votes
                if (c.VoteCount > (double)citizens.Count / 2)
                {
                    Console.WriteLine("Election Complete: {0} has {1:0.0%} of votes", c.Name, ((double)c.VoteCount / citizens.Count));
                    isDone = true;
                }
            }

            //Checks if only one candidate is remaining.
            if (candidates.Where(c => c.IsActive == true).ToList().Count == 1)
            {
                Console.WriteLine("Election Complete: {0} is the only remaining candidate.", candidates.Where(c => c.IsActive == true).FirstOrDefault());
                isDone = true;
            }
            return isDone;
        }
        #endregion
    }
}
