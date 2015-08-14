using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Gremlin : NonPlayer
    {

        //fields and props
        
        public int HourChangeBack { get; set; }

        public Gremlin()
        {
            MonType = "Gremlin";
            MaxLife = 25;
            MaxDamage = 8;
            Life = 25;
            MinDamage = 1;
            AC = 0;
            PlusToHit = 1;
            Name = "Mogwai";
            Description = "x2 Damage at night";
            HourChangeBack = 6; //dangerous until 6am
            MonExp = 25;
            MonGold = 2;
        }
/*
        public Gremlin(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, int hourChangeBack)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            HourChangeBack = hourChangeBack;
        }

        //Methods

        public override string ToString()
        {
            return base.ToString() + "\nHour to change back: " + HourChangeBack;
        }//end tostring

        //Override before the hour it changes back it does double damage
        public override int CalcDamage()
        {
            //typically when dealing with a method that has a return type you create a variable
            //of the type you need to return with some default value, then write the return line
            //then write the code in between
            int damage = base.CalcDamage();

            if (HourChangeBack >= DateTime.Now.Hour)
            {
                damage *= 2;
            }

            return damage;
        }//end CalcDamage
 */
        public override string ToString()
        {
            return "x2 Damage at night";
        }//end tostring
    }//end gremlin
}
