using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace SpellLibrary
{
    [Serializable()]
    public class Spell2 : Spells
    {

        public Spell2()
        {
            MaxDamage = 12;
            MinDamage = 3;
            Name = "Frost Beam";
            SpellID = 3;
            savedSp = "sp3";
        }
    }
}
