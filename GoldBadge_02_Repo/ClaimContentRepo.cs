using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_02_Repo
{
    public class ClaimContentRepo
    {
        private Queue<ClaimContents> _listOfClaimsQ = new Queue<ClaimContents>();

        public void AddClaimToQue(ClaimContents claim)
        {
            _listOfClaimsQ.Enqueue(claim);
        }


        public Queue<ClaimContents> GetListOfClaims()
        {
            return _listOfClaimsQ;
        }

        public bool DeleteClaim(int claimID)
        {
            ClaimContents claim = GetClaimByClaimID(claimID);

            if(claim == null)
            {
                return false;
            }

            _listOfClaimsQ.Dequeue();
            int originalNumberOfClaims = _listOfClaimsQ.Count;

            if(originalNumberOfClaims > _listOfClaimsQ.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ClaimContents GetClaimByClaimID(int claimID)
        {
            foreach(ClaimContents claim in _listOfClaimsQ)
            {
                if(claim.ClaimID == claimID)
                {
                    return claim;
                }
            }
            return null;
        }
    }
}
