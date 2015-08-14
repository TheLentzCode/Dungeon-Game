using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    [Serializable()]
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemID { get; set; }
    }
}
