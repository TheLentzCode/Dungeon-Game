using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace ItemLibrary
{
    [Serializable()]
    public class WandMissiles : Item
    {
        public WandMissiles()
        {
            Name = "Wand of Missiles";
            Description = "Single use, but always hits.";
            ItemID = 5;
        }
    }
}
