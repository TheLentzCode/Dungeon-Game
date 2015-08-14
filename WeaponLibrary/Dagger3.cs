using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Dagger3 : Weapon
    {

        public Dagger3()
        {
            MaxDamage = 4;
            MinDamage = 1;
            Name = "Dagger + 3";
            BonusHitChance = 3;
            WeapID = 10;
            savedWeap = "d4";
        }


    }
}
