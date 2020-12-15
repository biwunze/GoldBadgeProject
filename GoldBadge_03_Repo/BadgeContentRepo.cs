using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_03_Repo
{
    public class BadgeContentRepo
    {
        Dictionary<int, string> _badgeDict = new Dictionary<int, string>();
        //Dictionary<int, Badge> _badgeDict = new Dictionary<int, Badge>();
        //Dictionary<int, string[]> _badgeDict = new Dictionary<int, string[]>();
        //Dictionary<BadgeID, Badge> _badgeDict = new Dictionary<int BadgeID, Badge>();

        //Create
        public void CreateNewBadge(int badgeID, string doorNames) 
        {
            _badgeDict.Add(badgeID, doorNames);

            /*_badgeDict.Add(12345, new string[] { "A5", "A7" });
            _badgeDict.Add(22345, new string[] { "A1", "A4", "B1", "B2" });
            _badgeDict.Add(32345, new string[] { "A4", "A5" });*/

        }

        //Read
        public Dictionary<int, string> GetDoorDict()
        {
            return _badgeDict;
        }

        //Update


        //Delete


        //Helper
        /*private Badge GetBadgeByIDNum(int badgeID)                  //23 min of REPO
        {
            foreach (Badge badgeID in _badgeDict)
            {
                if(badgeID.BadgeID)
            }
        }*/

    }
}
