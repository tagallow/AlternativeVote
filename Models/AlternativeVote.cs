using ElectionTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    public class AlternativeVote : IElectionType
    {
        private List<Citizen> citizens;
        private List<Candidate> candidates;
        public AlternativeVote()
        {
            citizens = null;
            candidates = null;
        }

        #region Generic election methods
        private void RunElection()
        {
            if (citizens != null && candidates != null)
            {
                while (!IsElectionDone())
                {
                    EliminateLowestCandidate();
                }
            }
            else
            {
                throw new Exception("Election is not initialized");
            }
        }

        public void RunElection(List<Candidate> candidates, List<Citizen> citizens)
        {
            this.candidates = candidates;
            this.citizens = citizens;
            RunElection();
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

        private void CountVotes()
        {
            foreach (Candidate candidate in candidates)
            {
                candidate.VoteCount = 0;
            }
            foreach (Citizen citizen in citizens)
            {
                int vote = GetNextVote(citizen);
                if (vote > 0)
                    candidates.Where(candidate => candidate.ID == vote).FirstOrDefault().VoteCount++;
            }
        }
        private int GetNextVote(Citizen c)
        {
            for (int i = 0; i < c.votes.Count; i++)
            {
                if (CandidateIsActive(c.votes[i]))
                    return c.votes[i];
            }
            return -1;
        }
        private bool CandidateIsActive(int id)
        {
            return candidates.Where(candidate => candidate.ID == id).FirstOrDefault().IsActive;
        }
        /// <summary>
        /// Election is over when one candidate has more than 50% of all votes, or is the only candidate left
        /// </summary>
        private bool IsElectionDone()
        {
            CountVotes();
            foreach (Candidate c in candidates)
            {
                if (c.VoteCount > (double)citizens.Count / 2)
                {
                    Console.WriteLine("Election Complete: {0} has {1:0.0%} of votes", c.Name, ((double)c.VoteCount / citizens.Count));
                    return true;
                }
            }

            if (candidates.Where(c => c.IsActive == true).ToList().Count == 1)
            {
                Console.WriteLine("Election Complete: {0} is the only remaining candidate.", candidates.Where(c => c.IsActive == true).FirstOrDefault());
                return true;
            }
            return false;
        }
        #endregion
    }
}
