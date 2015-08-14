using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace ItemLibrary
{
    [Serializable()]
    public class PoSH : Item
    {
        public PoSH()
        {
            Name = "Potion of Superior Healing";
            Description = "Heals up to 40 hit points";
            ItemID = 3;
        }
    }
}
