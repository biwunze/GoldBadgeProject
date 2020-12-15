using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_03_Repo
{
    class Badge
    {
        public int BadgeID { get; set; }
        public string DoorNames { get; set; }

        public Badge() {}

        public Badge(string doorNames)
        {
            //BadgeID = badgeID;
            DoorNames = doorNames;
        }

    }
}
