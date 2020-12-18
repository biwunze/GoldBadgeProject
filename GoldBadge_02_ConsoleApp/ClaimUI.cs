using GoldBadge_02_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_02_ConsoleApp
{
    class ClaimUI
    {
        private ClaimContentRepo _claimContentRepo = new ClaimContentRepo();
        public Queue<ClaimContents> _listOfClaimsQ = new Queue<ClaimContents>();
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

        private void SeeAllClaims()
        {
            Console.Clear();
            Queue<ClaimContents> _listOfClaimsQ = _claimContentRepo.GetListOfClaims();
            
            Console.WriteLine("ClaimID  " + "Type   " + "   Description    " + "        Amount     " + "    DateOfAccident     " + "    DateOfClaim    " + "    IsValid    ");
            foreach (ClaimContents claim in _listOfClaimsQ)
            {
                Console.WriteLine($"    {claim.ClaimID}    {claim.TypeOfClaim}      {claim.ClaimDescription}     {claim.ClaimAmount}      {claim.DateOfIncident}      {claim.DateOfClaim}         {claim.IsValid}");
            }
        }

        private void NextClaim()
        {

            Console.Clear();
            Queue<ClaimContents> _listOfClaimsQ = _claimContentRepo.GetListOfClaims();
            Console.WriteLine("Here are the details for the next claim to be handled:");
           
            foreach(ClaimContents claim in _listOfClaimsQ)
            {
                Console.WriteLine($"ClaimID: {claim.ClaimID}\n" +
                    $"Type: {claim.TypeOfClaim}\n" +
                    $"Description: {claim.ClaimDescription}\n" +
                    $"Amount: {claim.ClaimAmount}\n" +
                    $"DateOfAccident: {claim.DateOfIncident}\n" +
                    $"DateOfClaim: {claim.DateOfClaim}\n" +
                    $"IsValid: {claim.IsValid}\n");
                Console.WriteLine();
                Console.WriteLine("Do you want to deal with this claim now? (y/n)");
                string userChoice = Console.ReadLine().ToLower();
                if (userChoice == "n")
                {
                    break;
                }
                _listOfClaimsQ.Peek();
                Console.Clear();
            }
        }

        private void CreateAClaim()                                         
        {
            Console.Clear();
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

            _claimContentRepo.AddClaimToQue(newClaim);
        }

        public void QClaimSeeds()
        {
            Queue<ClaimContents> _listOfClaimsQ = new Queue<ClaimContents>();
            ClaimContents claimOne = new ClaimContents(1, ClaimType.Car, "Car accident on 465.", 400.00, new DateTime(2018,04,25), new DateTime(2018, 4, 27), true);
            ClaimContents claimOTwo = new ClaimContents(2, ClaimType.Home, "House fire in kitchen.", 4000.00, new DateTime(2018,11,18), new DateTime(2018,12,18), true);
            ClaimContents claimThree = new ClaimContents(3, ClaimType.Theft, "Stolen pancakes.", 4.00, new DateTime(2018,4,27), new DateTime(2018,06,01), false);

            _claimContentRepo.AddClaimToQue(claimOne);
            _claimContentRepo.AddClaimToQue(claimOTwo);
            _claimContentRepo.AddClaimToQue(claimThree);
        }
    }
}
