using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Dagger5 : Weapon
    {

        public Dagger5()
        {
            MaxDamage = 4;
            MinDamage = 1;
            Name = "Dagger + 5";
            BonusHitChance = 5;
            WeapID = 12;
            savedWeap = "d6";
        }


    }
}
