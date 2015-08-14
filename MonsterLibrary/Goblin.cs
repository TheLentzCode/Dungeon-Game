using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
     public class Goblin : NonPlayer
    {
       
          

        //CTORS

        public Goblin()
        {
            
            //SET MAX values first!!
            Random gp = new Random();
            MonType = "Goblin";
            MaxLife = 15;
            MaxDamage = 8;
            Name = "David Bowie";
            Life = 25;
            PlusToHit = 3;
            AC = 8;
            MinDamage = 1;
            Description = "May throw a grenade!";
            MonExp = 25;
            MonGold = gp.Next(1, 101);
            IdleSound = @"..\..\gbn_idl.wav";
            AtkSound = @"..\..\gbn_atk.wav";
            DieSound = @"..\..\gbn_dth.wav";
        }
        
         public Goblin(int ac, int life, int maxLife, int str, int dex, int con, int minDamage, int maxDamage, 
             int monExp, int monGold)
         {
            Random gp = new Random();
            Name = "David Bowie";
            MonType = "Goblin";
            MaxLife = maxLife;
            Life = life;
            AC = ac;
            Str = str;
            Dex = dex;
            Con = con;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = "Might throw a grenade!";
            MonGold = monGold;
            MonExp = monExp;
            IdleSound = @"..\..\gbn_idl.wav";
            AtkSound = @"..\..\gbn_atk.wav";
            DieSound = @"..\..\gbn_dth.wav";

         }
        //methods

        

        
        public override int CalcDamage()
        {
            int damage = base.CalcDamage();
            Random rand = new Random();

            if (rand.Next(1, 101) >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Centered.LineReturn("Goblin threw a grenade and it EXPLODED!");
                Console.ForegroundColor = ConsoleColor.Red;
                damage += 10;
            }

            return damage;
        }//end CalcDam
        
        public override string ToString()
        {
            return "May throw a grenade!";
        }

    }
}
