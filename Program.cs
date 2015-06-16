using AlternativeVote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeVote
{
    class Program
    {
        static List<Citizen> citizens;
        static List<Candidate> candidates;
        static void Main(string[] args)
        {
            InitlializeCandidates();
            CastVotes();
            while(!IsElectionDone())
            {
                EliminateLowestCandidate();
            }
            
            //Console.WriteLine("Winner: {0}", candidates.Where(c => c.IsActive == true).FirstOrDefault().Name);
            Console.ReadKey();
        }
        static void InitlializeCandidates()
        {
            candidates = new List<Candidate>();
            candidates.Add(new Candidate(1, "Turtle"));
            candidates.Add(new Candidate(2, "Gorilla"));
            candidates.Add(new Candidate(3, "Owl"));
            candidates.Add(new Candidate(4, "Leopard"));
            candidates.Add(new Candidate(5, "Tiger"));
        }
        static void CastVotes()
        {
            citizens = new List<Citizen>();

            #region turtle
            //5 for turtle
            citizens.Add(new Citizen(new int[] { 1, 3 }));
            citizens.Add(new Citizen(new int[] { 1, 3 }));
            citizens.Add(new Citizen(new int[] { 1, 3 }));
            citizens.Add(new Citizen(new int[] { 1, 3 }));
            citizens.Add(new Citizen(new int[] { 1, 3 }));
            #endregion

            #region gorilla
            //25 for gorilla
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            citizens.Add(new Citizen(new int[] { 2, 3 }));
            #endregion

            #region owl
            //25 for owl
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            citizens.Add(new Citizen(new int[] { 3 }));
            #endregion

            #region leopard
            //30 for leopard
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            citizens.Add(new Citizen(new int[] { 4 }));
            #endregion

            #region tiger
            //15 for tiger
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            citizens.Add(new Citizen(new int[] { 5, 4 }));
            #endregion

        }
        static void CountVotes()
        {
            foreach(Candidate candidate in candidates)
            {
                candidate.VoteCount = 0;
            }
            foreach (Citizen citizen in citizens)
            {
                int vote = GetNextVote(citizen);
                candidates.Where(candidate => candidate.ID == vote).FirstOrDefault().VoteCount++;
            }
        }
        static void EliminateLowestCandidate()
        {
            Candidate loser = new Candidate { ID = -1, VoteCount = int.MaxValue };
            foreach(Candidate candidate in candidates.Where(c=>c.IsActive))
            {
                if (candidate.VoteCount < loser.VoteCount)
                {
                    loser.VoteCount = candidate.VoteCount;
                    loser.ID = candidate.ID;
                    loser.Name = candidate.Name;
                }
            }
            Console.WriteLine("{0} has been eliminated", loser.Name);
            candidates.Where(candidate => candidate.ID == loser.ID).FirstOrDefault().IsActive=false;
        }
        /// <summary>
        /// More than 50% of all votes, or only candidate left
        /// </summary>
        /// <returns></returns>
        static bool IsElectionDone()
        {
            CountVotes();
            foreach(Candidate c in candidates)
            {
                if (c.VoteCount > (double)citizens.Count/2)
                {
                    Console.WriteLine("Election Complete: {0} has {1:0.0%} of votes", c.Name, ((double)c.VoteCount / citizens.Count));
                    return true;
                }
            }
            
            if(candidates.Where(c => c.IsActive == true).ToList().Count == 1)
            {
                Console.WriteLine("Election Complete: {0} is the only remaining candidate.", candidates.Where(c => c.IsActive == true).FirstOrDefault());
                return true;
            }
            return false;
        }
        static int GetNextVote(Citizen c)
        {
            for(int i=0;i<c.votes.Count;i++)
            {
                if (CandidateIsActive(c.votes[i]))
                    return c.votes[i];
            }
            return -1;
        }
        static bool CandidateIsActive(int id)
        {
            return candidates.Where(candidate => candidate.ID == id).FirstOrDefault().IsActive;
        }
    }
}
