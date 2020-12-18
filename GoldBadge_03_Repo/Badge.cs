using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_03_Repo
{
    class Badge
    {
        //List<string> WhichDoors = new List<string>();

        public int BadgeID { get; set; }
        //public string DoorNames { get; set; }
        public List<string> DoorAccess { get; set; } //= new List<string>();

        public Badge() { }

        public Badge(int badgeID, List<string> doorNames)
        {
            BadgeID = badgeID;
            DoorAccess = doorNames;
        }


        public void GetDoors(Badge doorAcc)
        {
            Dictionary<int, List<string>> theDoors = new Dictionary<int, List<string>>();
            theDoors.Add(12345, new List<string> { "A1", "A2" });
            theDoors.Add(22345, new List<string> { "B1", "B2" });
            theDoors.Add(32345, new List<string> { "C1", "C2" });
        }
        /*public static Dictionary<int, Badge> GetDoors()
        {
           

            var badges = new Dictionary<int, Badge>();
            var theDoors = new Badge(12345, new List<string>());
            badges.Add(12345, theDoors);
            theDoors = new Badge(22345, new List<string>());
            badges.Add(22345, theDoors);


            return badges;
        }*/
    }
}
