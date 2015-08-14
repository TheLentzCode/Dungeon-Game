using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary
{
    [Serializable()]
    public class Dagger1 : Weapon
    {

        public Dagger1()
        {
            MaxDamage = 4;
            MinDamage = 1;
            Name = @"Dagger + 1";
            BonusHitChance = 1;
            WeapID = 8;
            savedWeap = "d3";
        }


    }
}
