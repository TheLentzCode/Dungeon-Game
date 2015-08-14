using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Mace1 : Weapon
    {
        public Mace1()
        {

            MaxDamage = 6;
            MinDamage = 1;
            Name = "Mace + 1";
            BonusHitChance = 1;
            WeapID = 14;
            savedWeap = "m2";
        }



    }
}
