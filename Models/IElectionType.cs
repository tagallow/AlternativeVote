using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    interface IElectionType
    {
        //void RunElection();
        void RunElection(List<Candidate> candidates, List<Citizen> citizens);
        //void SetCandidates(List<Candidate> candidates);
        //void CastVotes(List<Citizen> citizens);
        //void PrintResults();
    }
}
