using GoldBadge_02_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GoldBadge_02_Tests
{
    [TestClass]
    public class ClaimContentRepoTests
    {
        [TestMethod]
        public void AddToClaimQ_ShouldGetNotNull()
        {
            ClaimContentRepo cRepo = new ClaimContentRepo();
            ClaimContents cClaim = new ClaimContents(7, ClaimType.Car, "Car accident on 37.", 100.00, new DateTime(2018, 06, 20), new DateTime(2018, 6, 28), true);

            cRepo.AddClaimToQue(cClaim);
            
            Queue<ClaimContents> listOfClaimsQ = cRepo.GetListOfClaims();

            bool claimNumEq = false;

            foreach(ClaimContents claims in listOfClaimsQ)
            {
                if(claims.ClaimID == cClaim.ClaimID)
                {
                    claimNumEq = true;
                    break;
                }
            }
            Assert.IsTrue(claimNumEq);
        }

        [TestMethod]
        public void GetClaimList_NotBeNull()
        {
            ClaimContentRepo cRepo = new ClaimContentRepo();
            ClaimContents cClaim = new ClaimContents();

            Queue<ClaimContents> listOfClaimsQ = cRepo.GetListOfClaims();

            Assert.IsNotNull(listOfClaimsQ);
        }

        [TestMethod]
        public void DeleteClaim_True()
        {
            ClaimContentRepo cRepo = new ClaimContentRepo();
            ClaimContents cClaim = new ClaimContents(7, ClaimType.Car, "Car accident on 37.", 100.00, new DateTime(2018, 06, 20), new DateTime(2018, 6, 28), true);

            cRepo.AddClaimToQue(cClaim);

            bool deletedTest = cRepo.DeleteClaim(cClaim.ClaimID);

            Assert.IsTrue(deletedTest);
        }

        [TestMethod]
        public void TestGetByClaimID()
        {
            ClaimContentRepo cRepo = new ClaimContentRepo();
            ClaimContents cClaim = new ClaimContents(7, ClaimType.Car, "Car accident on 37.", 100.00, new DateTime(2018, 06, 20), new DateTime(2018, 6, 28), true);

            cRepo.AddClaimToQue(cClaim);

            ClaimContents claimByID = cRepo.GetClaimByClaimID(cClaim.ClaimID);

            bool idNumsEq = cClaim.ClaimID == claimByID.ClaimID;
            Assert.IsTrue(idNumsEq);
        }
    }
}
