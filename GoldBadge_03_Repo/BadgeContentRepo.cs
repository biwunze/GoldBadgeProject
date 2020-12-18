using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_03_Repo
{
    public class BadgeContentRepo
    {

        private Dictionary<int, Badge> _badgeDict = new Dictionary<int, Badge>();
        
        public void AddBadges()
        {
            Dictionary<int, Badge> badgeDict = new Dictionary<int, Badge>();
            badgeDict.Add(12345, Badge.GetDoors();
        }
        /*private static Dictionary<int, Badge> _badgeDict;

        private static void Add(int badgeID, Badge badge)
        {
            _badgeDict.Add(badgeID, badge);
        }*/

        //public List<string> doorAccess = new List<string>();

        //Dictionary<int, Badge> _badgeDict = new Dictionary<int, Badge>();
        //Dictionary<int, string[]> _badgeDict = new Dictionary<int, string[]>();
        //Dictionary<BadgeID, Badge> _badgeDict = new Dictionary<int BadgeID, Badge>();

        //Create
        public void AddBadgeToList(Dictionary<int, Badge>)
        {
            _badgeDict.Add(int, newBadge);
        }

        public void CreateNewBadge(int badgeNumber, Badge doorNames) //Only works when private
        {
            _badgeDict.Add(badgeNumber, doorNames);

            /*_badgeDict.Add(12345, new string[] { "A5", "A7" });
            _badgeDict.Add(22345, new string[] { "A1", "A4", "B1", "B2" });
            _badgeDict.Add(32345, new string[] { "A4", "A5" });*/

        }

        private void AddBadge(int newBadgeID, Badge badgeDoors)
        {
            _badgeDict.Add(newBadgeID, badgeDoors);
        }

        //Read
        public void GetDoorDict()
        {
            GetDoors();
            //return _badgeDict;
            //return _badgeDict;
        }

        //Update


        //Delete


        //Helper
        /*private Badge GetDoorByIDNum(int iD, string doorAcc)
        {
            foreach (KeyValuePair<int, string> badgeDoor in _badgeDict)
            {
                Console.WriteLine("")
            }
            
            return null;
        }*/

        /*private Badge GetDoorByIDNum(int iD)
        {
            foreach (Badge badge in _badgeDict)
            {
                if (badge.BadgeID == iD)
                {
                    return badge;
                }
            }
            return null;
        }*/

        /*private Badge GetBadgeByIDNum(int badgeID)                  //23 min of REPO
        {
            foreach (Badge badgeID in _badgeDict)
            {
                if(badgeID.BadgeID)
            }
        }*/
        
    }
}
