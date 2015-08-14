using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class StarterMace : Weapon
    {
        public StarterMace()
        {
            
            MaxDamage = 6;
            MinDamage = 1;
            Name = "Rusty Mace";
            BonusHitChance = 0;
            WeapID =13;
            savedWeap = "m1";
        }
        


    }//end StarterMace
}
