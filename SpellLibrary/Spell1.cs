using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace SpellLibrary
{
    [Serializable()]
    public class Spell1 : Spells
    {

        public Spell1()
        {
            MaxDamage = 10;
            MinDamage = 2;
            Name = "Fire Blast";
            SpellID = 2;
            savedSp = "sp2";
        }
    }
}
