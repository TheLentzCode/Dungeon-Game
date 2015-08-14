using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Dagger2 : Weapon
    {

        public Dagger2()
        {
            MaxDamage = 4;
            MinDamage = 1;
            Name = "Dagger + 2";
            BonusHitChance = 2;
            WeapID = 9;
            savedWeap = "d3";
        }


    }
}
