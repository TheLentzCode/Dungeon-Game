using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Mace4 : Weapon
    {
        public Mace4()
        {

            MaxDamage = 6;
            MinDamage = 1;
            Name = "Mace + 4";
            BonusHitChance = 4;
            WeapID = 17;
            savedWeap = "m5";
        }



    }
}
