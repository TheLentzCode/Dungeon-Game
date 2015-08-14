using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Mace3 : Weapon
    {
        public Mace3()
        {

            MaxDamage = 6;
            MinDamage = 1;
            Name = "Mace + 3";
            BonusHitChance = 3;
            WeapID = 16;
            savedWeap = "m4";
        }



    }
}
