using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Sword1:Weapon
    {
        
        public Sword1()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = @"Longsword + 1";
            BonusHitChance = 1;
            WeapID = 20;
            savedWeap = "s2";
        }


    }
}
