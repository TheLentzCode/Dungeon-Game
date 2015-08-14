using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Sword2 : Weapon
    {
        public Sword2()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = @"Longsword + 2";
            BonusHitChance = 2;
            WeapID = 21;
            savedWeap = "s3";
        }


    }
}
