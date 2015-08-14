using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace SpellLibrary
{
    [Serializable()]
    public class Spell4 : Spells
    {
        
        public Spell4()
        {
            MaxDamage = 20;
            MinDamage = 6;
            Name = "Lightning Bolt";
            SpellID = 5;
            savedSp = "sp5";
        }
    }
}
