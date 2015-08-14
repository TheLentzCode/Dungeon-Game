using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Sword5 : Weapon
    {
        public Sword5()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = @"Longsword + 5";
            BonusHitChance = 5;
            WeapID = 24;
            savedWeap = "s6";
        }


    }
}
