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

        // CRUD
        // Create
        public void AddClaimToQue(ClaimContents claim)
        {
            _listOfClaimsQ.Enqueue(claim);
            //Queue.enqueue(claim);
        }

        /*public void SeeTheNextOne()
        {
            Console.Clear();
            Que
            //ClaimContents nextClaim = _listOfClaimsQ.Peek();
            
            
        }*/

        // Read
        public Queue<ClaimContents> GetListOfClaims()
        {
            return _listOfClaimsQ;
        }

        // Update

        // Delete
        public bool DeleteClaim(int claimID)                            // Don't need all of this!
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

            /*ClaimContents claim = GetClaimByClaimID(claimID);
            if (_listOfClaimsQ.Dequeue(claim))
            {
                return true;
            }
            return false;*/
        }

        // Helper?


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
