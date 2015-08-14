using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace ItemLibrary
{
    [Serializable()]
    public class Empty : Item
    {
        public Empty()
        {
            Name = "Empty Item Slot";
            Description = "You can buy items to use";
            ItemID = 0;
        }
    }
}
