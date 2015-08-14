using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class StarterSword : Weapon
    {
        public StarterSword()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = "Rusty Longsword";
            BonusHitChance = 0;
            WeapID = 19;
            savedWeap = "s1";
        }


    }//end StarterSword
}
