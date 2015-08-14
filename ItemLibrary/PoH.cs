using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace ItemLibrary
{
    [Serializable()]
    public class PoH : Item
    {
        public PoH()
        {
            Name = "Potion of Healing";
            Description = "Heals up to 10 hit points";
            ItemID = 1;
        }
    }
}
