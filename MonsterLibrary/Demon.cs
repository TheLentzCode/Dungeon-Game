using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Demon : NonPlayer
    {
         public Demon()
        {
            //Boss
            Random gp = new Random();
            MonType = "Demon";
            MaxLife = 80;
            MaxDamage = 8;
            Name = "Beezlebob";
            Life = 80;
            PlusToHit = 5;
            AC = 15;
            MinDamage = 1;
            Description = "Throws Fire Bolts";
            MonExp = 55;
            MonGold = gp.Next(100, 201);
            IdleSound = @"..\..\fsg_idl.wav";
            AtkSound = @"..\..\fsg_atk.wav";
            DieSound = @"..\..\fsg_dth.wav";
        }
        
        public Demon(int ac, int life, int maxLife, int str, int dex, int con, int minDamage, int maxDamage, 
             int monExp, int monGold)
         {
            Random gp = new Random();
            Name = "Larry";
            MonType = "Demon";
            MaxLife = maxLife;
            Life = life;
            AC = ac;
            Str = str;
            Dex = dex;
            Con = con;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = "Throws Fire Bolts";
            MonGold = monGold;
            MonExp = monExp;
            IdleSound = @"..\..\fsg_idl.wav";
            AtkSound = @"..\..\fsg_atk.wav";
            DieSound = @"..\..\fsg_dth.wav";

         }
        //methods

        

        
        public override int CalcDamage()
        {
            int damage = base.CalcDamage();
            Random rand = new Random();

            if (rand.Next(1, 101) >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Centered.LineReturn("You are hit by a FIRE BOLT!!");
                Console.ForegroundColor = ConsoleColor.Red;
                damage += 15;
            }

            return damage;
        }//end CalcDam
    }//end Demon
}
