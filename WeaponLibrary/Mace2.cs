using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Mace2 : Weapon
    {
        public Mace2()
        {

            MaxDamage = 6;
            MinDamage = 1;
            Name = "Mace + 2";
            BonusHitChance = 2;
            WeapID = 15;
            savedWeap = "m3";
        }



    }
}
