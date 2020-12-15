﻿using GoldBadge_02_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_02_ConsoleApp
{
    class ClaimUI
    {
        //Private Queue<ClaimContents> _listOfClaimsQ = new Queue<ClaimContents>();
        private ClaimContentRepo _claimContentRepo = new ClaimContentRepo();
        private Queue<ClaimContents> _listOfClaimsQ = new Queue<ClaimContents>();

        public void RunClaims()
        {
            QClaimSeeds();
            ClaimsMenu();
        }

        private void ClaimsMenu()
        {
            bool runningClaims = true;
            while (runningClaims)
            {
                Console.WriteLine("Choose a menu item:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        CreateAClaim();
                        break;
                    case "4":
                        Console.WriteLine("Thanks for using!");
                        runningClaims = false;
                        break;
                    default:
                        Console.WriteLine("Please select a correct choice!");
                        break;
                }
                Console.WriteLine("Please press a key to continue!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // See all claims
        private void SeeAllClaims()                     //Need to figure out alignment
        {
            Console.Clear();
            Queue<ClaimContents> _listOfClaimsQ = _claimContentRepo.GetListOfClaims();
            
            Console.WriteLine("ClaimID  " + "Type   " + "   Description    " + "        Amount     " + "    DateOfAccident     " + "    DateOfClaim    " + "    IsValid    ");
            foreach (ClaimContents claim in _listOfClaimsQ)
            {
                Console.WriteLine($"    {claim.ClaimID}    {claim.TypeOfClaim}      {claim.ClaimDescription}     {claim.ClaimAmount}         {claim.DateOfIncident}      {claim.DateOfClaim}         {claim.IsValid}");

                /*Console.WriteLine($"ClaimID: {claim.ClaimID}\n" +
                    $"Type: {claim.TypeOfClaim}\n" +
                    $"Description: {claim.ClaimDescription}\n" +
                    $"Amount: {claim.ClaimAmount}\n" +
                    $"DateOfAccident: {claim.DateOfIncident}\n" +
                    $"DateOfClaim: {claim.DateOfClaim}\n" +
                    $"IsValid: {claim.IsValid}\n");*/
            }


            /*foreach(var claim in _listOfClaimsQ)
            {
                Console.WriteLine(claim);
            }    
            
            //new Queue<ClaimContents>();


            //_listOfClaimsQ.Enqueue(ClaimContents.);
            //CLaimID Type Description Amount DateOfAccident DateOfClaim IsValid*/
        }

        // Next claim
        private void NextClaim()
        {
            Console.Clear();

            Console.WriteLine("Here are the details for the next claim to be handled:");
            Console.WriteLine();
            //Console.WriteLine("")
        }

        // New claim
        private void CreateAClaim()                                         
        {
            Console.Clear();
            //Queue<ClaimContents> newClaim = new Queue<ClaimContents>();
            ClaimContents newClaim = new ClaimContents();

            Console.WriteLine("Please enter the Claim ID number:");
            string newIDNum = Console.ReadLine();
            newClaim.ClaimID = int.Parse(newIDNum);

            Console.WriteLine("Which type of claim is this?\n" +
                "1) Car\n" +
                "2) Home\n" +
                "3) Theft");

            string claimTypeString = Console.ReadLine();
            int typeAsString = int.Parse(claimTypeString);
            newClaim.TypeOfClaim = (ClaimType)typeAsString;

            Console.WriteLine("Please enter a brief description:");
            newClaim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("What is the amount of damage?");
            string costAsString = Console.ReadLine();
            newClaim.ClaimAmount = double.Parse(costAsString);

            Console.WriteLine("On what date did the accident occur? etc: (5/11/2018)");
            string doaAsString = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(doaAsString);

            //newClaim.DateOfIncident = DateTime.Parse(doaAsString);

            Console.WriteLine("When was the claim recieved? ex: (5/20/2018)");
            string docAsString = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(docAsString);

            Console.WriteLine("Was this a valid claim? (Yes or No)");
            string isValidClaim = Console.ReadLine().ToLower();

            if (isValidClaim == "yes")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }

            /*TimeSpan diff = DateOfCla - DateOfInc;
            int theDiff2 = diff.Days;

            if(theDiff2 < 30)
            {
                return true;
                //Console.WriteLine("")
            }
            else
            {
                return false;
            }*/

            _claimContentRepo.AddClaimToQue(newClaim);

            //if (DateOfCla - DateOfInc).TotalDays;
            //(DateOfCla.Date - DateOfInc.Date).Days = validityCheck;
            //if()

            //_listOfClaimsQ.Enqueue(newClaim);

            //CLaimID Type Description Amount DateOfAccident DateOfClaim IsValid
        }

        private void QClaimSeeds()
        {
            ClaimContents claimOne = new ClaimContents(1, ClaimType.Car, "Car accident on 465.", 400.00, new DateTime(2018,04,25), new DateTime(2018, 4, 27), true);
            ClaimContents claimOTwo = new ClaimContents(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018,11,18), new DateTime(2018,12,18), true);
            ClaimContents claimThree = new ClaimContents(3, ClaimType.Theft, "Stolen pancakes.", 4.00, new DateTime(2018,4,27), new DateTime(2018,06,01), false);

            _claimContentRepo.AddClaimToQue(claimOne);
            _claimContentRepo.AddClaimToQue(claimOTwo);
            _claimContentRepo.AddClaimToQue(claimThree);

            /*_listOfClaimsQ.Enqueue(claimOne);
            _listOfClaimsQ.Enqueue(claimOTwo);
            _listOfClaimsQ.Enqueue(claimThree);*/

            //DateTime(11, 12, 2015), DateTime(11, 16, 2015), true
            //DateTime.Parse.ToString("11/12/2015")
        }
    }
}