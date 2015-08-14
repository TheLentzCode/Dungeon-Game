using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace SpellLibrary
{
    [Serializable()]
    public class Spell5 : Spells
    {
        
        public Spell5()
        {
            MaxDamage = 25;
            MinDamage = 8;
            Name = "Meteor";
            SpellID = 6;
            savedSp = "sp6";
        }
    }
}
