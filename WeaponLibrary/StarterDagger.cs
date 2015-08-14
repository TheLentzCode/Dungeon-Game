using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary 
{
    [Serializable()]
    public class StarterDagger : Weapon
    {

         public StarterDagger()
        {
            MaxDamage = 4;
            MinDamage = 1;
            Name = "Rusty Dagger";
            BonusHitChance = 0;
            WeapID = 7;
            savedWeap = "d1";
        }


    }//end StarterDagger
}
