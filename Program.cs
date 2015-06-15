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
                RunElection();
            }
            Console.WriteLine("Election Done");
            Console.WriteLine("Winner: {0}", candidates.Where(c => c.IsActive == true).FirstOrDefault().Name);
            Console.ReadKey();
        }
        static void InitlializeCandidates()
        {
            candidates = new List<Candidate>();
        }
        static void CastVotes()
        {
            citizens = new List<Citizen>();
        }
        static void RunElection()
        {
            foreach(Citizen citizen in citizens)
            {
                int vote = GetNextVote(citizen);
                candidates.Where(candidate => candidate.ID == vote).FirstOrDefault().VoteCount++;
            }
        }
        static bool IsElectionDone()
        {
            return candidates.Where(c => c.IsActive == true).ToList().Count == 1;
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
