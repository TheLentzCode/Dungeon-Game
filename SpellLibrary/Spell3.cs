using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace SpellLibrary
{
     [Serializable()]
    public class Spell3 : Spells
    {
       
        public Spell3()
        {
            MaxDamage = 16;
            MinDamage = 4;
            Name = "Fire Ball";
            SpellID = 4;
            savedSp = "sp4";
        }
    }
}
