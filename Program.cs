using ElectionTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Citizen> citizens = GetSampleVotes();
            List<Candidate> candidates = GetCandidateSampleData();
            IElectionType alternateVote = new AlternativeVote();
            alternateVote.RunElection(candidates, citizens);
            Console.ReadKey();
        }
        static List<Candidate> GetCandidateSampleData()
        {
            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate(1, "Turtle"));
            candidates.Add(new Candidate(2, "Gorilla"));
            candidates.Add(new Candidate(3, "Owl"));
            candidates.Add(new Candidate(4, "Leopard"));
            candidates.Add(new Candidate(5, "Tiger"));
            return candidates;
        }
        static List<Citizen> GetSampleVotes()
        {
            List<Citizen> citizens = new List<Citizen>();

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

            return citizens;
        }
    }
}
