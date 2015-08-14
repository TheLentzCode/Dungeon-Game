using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace SpellLibrary
{
     [Serializable()]
    public class StarterSpell : Spells
    {
       
        public StarterSpell()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = "Energy Bolt";
            SpellID = 1;
            savedSp = "sp1";
        }
    }//end StarterSpell
}
