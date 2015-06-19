using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionTypes.Models
{
    public abstract class GenericElection
    {
        protected List<Citizen> citizens;
        protected List<Candidate> candidates;

        public abstract void RunElection(List<Candidate> candidates, List<Citizen> citizens);
        
        protected void VoteForCandidate(int id)
        {
            Candidate c = GetCandidateByID(id);
            //casts vote only if the vote is valid.
            if (c != null)
            {
                c.VoteCount++;
            }
            else if (id != 0) //0 is reserved to indicate no vote
            {
                Console.WriteLine("An invalid vote was found and ignored");
                //throw new Exception("invalid vote");
            }
        }
        protected Candidate GetCandidateByID(int id)
        {
            return candidates.Where(candidate => candidate.ID == id).FirstOrDefault();
        }
        protected bool CandidateIsActive(int id)
        {
            return GetCandidateByID(id).IsActive;
        }

    }
}
