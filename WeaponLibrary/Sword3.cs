using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Sword3 : Weapon
    {
        public Sword3()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = @"Longsword + 3";
            BonusHitChance = 3;
            WeapID =22;
            savedWeap = "s4";
        }


    }
}
