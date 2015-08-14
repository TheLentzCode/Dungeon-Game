using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Sword4 : Weapon
    {
        
        public Sword4()
        {
            MaxDamage = 8;
            MinDamage = 1;
            Name = @"Longsword + 4";
            BonusHitChance = 4;
            WeapID = 23;
            savedWeap = "s5";
        }


    }
}
