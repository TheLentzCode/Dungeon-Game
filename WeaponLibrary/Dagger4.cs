using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Dagger4 : Weapon
    {

        public Dagger4()
        {
            MaxDamage = 4;
            MinDamage = 1;
            Name = "Dagger + 4";
            BonusHitChance = 4;
            WeapID = 11;
            savedWeap = "d5";
        }


    }
}
