using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace ItemLibrary
{
    [Serializable()]
    public class PoGH : Item
    {
        public PoGH()
        {
            Name = "Potion of Greater Healing";
            Description = "Heals up to 20 hit points";
            ItemID = 2;
        }
    }
}
