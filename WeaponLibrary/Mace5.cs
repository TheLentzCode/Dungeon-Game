using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Mace5 : Weapon
    {
        public Mace5()
        {

            MaxDamage = 6;
            MinDamage = 1;
            Name = "Mace + 5";
            BonusHitChance = 5;
            WeapID = 18;
            savedWeap = "m6";
        }



    }
}
