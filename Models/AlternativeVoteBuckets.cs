using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    /// <summary>
    /// This is a different way to transfer votes in an alterntive vote election.
    /// I think this is closer to how a human would count it. Instead of cycling through 
    /// every vote after eliminating a candidate, it groups the votes into buckets based on
    /// what their current vote is, and only cycles through those and moves them into the next
    /// cooresponding bucket.
    /// </summary>
    public class AlternativeVoteBuckets : GenericElection
    {
        private static Dictionary<int, List<Citizen>> Buckets;

        public override void RunElection(List<Candidate> candidates, List<Citizen> citizens)
        {
            Buckets = new Dictionary<int, List<Citizen>>();
            this.candidates = candidates;
            this.citizens = citizens;
            InitializeBuckets();
            while(!IsElectionDone())
            {
                EliminateCandidate();
            }

        }
        private void EliminateCandidate()
        {
            int minValue = int.MaxValue;
            int minId=0;
            foreach(KeyValuePair<int,List<Citizen>> bucket in Buckets)
            {
                if(bucket.Value.Count < minValue)
                {
                    minValue = bucket.Value.Count;
                    minId = bucket.Key;
                }
            }
            GetCandidateByID(minId).IsActive = false;
            Console.WriteLine("{0} has been eliminated", GetCandidateByID(minId).Name);

            #region TransferBuckets
            Dictionary<int, List<Citizen>> newBuckets = new Dictionary<int, List<Citizen>>();
            foreach (Candidate candidate in candidates)
            {
                if(candidate.IsActive)
                    newBuckets.Add(candidate.ID, new List<Citizen>());
            }
            foreach(Citizen c in Buckets[minId])
            {
                int nextVote = GetNextVote(c);
                if(nextVote>0)
                {
                    newBuckets[nextVote].Add(c);
                }
            }
            Buckets.Remove(minId);
            foreach(KeyValuePair<int,List<Citizen>> bucket in newBuckets)
            {
                Buckets[bucket.Key].AddRange(bucket.Value);
            }

            #endregion
        }
        private void InitializeBuckets()
        {
            foreach(Candidate candidate in candidates)
            {
                Buckets.Add(candidate.ID, new List<Citizen>());
            }
            foreach(Citizen citizen in citizens)
            {
                int vote = GetNextVote(citizen);
                Buckets[vote].Add(citizen);
            }
        }
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
        private bool IsElectionDone()
        {
            bool isDone = false;

            foreach(KeyValuePair<int,List<Citizen>> bucket in Buckets)
            {
                if(bucket.Value.Count > (double)citizens.Count/2)
                {
                    Candidate c = GetCandidateByID(bucket.Key);
                    Console.WriteLine("Election Complete: {0} has {1:0.0%} of votes", c.Name, ((double)bucket.Value.Count/ citizens.Count));
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
    }
}
