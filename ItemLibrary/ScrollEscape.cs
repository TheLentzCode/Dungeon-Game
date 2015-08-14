using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace ItemLibrary
{
    [Serializable()]
    public class ScrollEscape : Item
    {
        public ScrollEscape()
        {
            
            Name = "Scroll of Escape";
            Description = "Single use, teleport to town safely";
            ItemID = 4;
        }
    }
}
