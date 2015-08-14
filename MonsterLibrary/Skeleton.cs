using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Skeleton : NonPlayer
    {
        public Skeleton()
        {
            
            Random gp = new Random();
            MonType = "Skeleton";
            MaxLife = 20;
            MaxDamage = 8;
            Name = "Jack";
            Life = 20;
            PlusToHit = 1;
            AC = 10;
            MinDamage = 1;
            Description = "Bones, hard to hit";
            MonExp = 20;
            MonGold = gp.Next(1, 51);

            IdleSound = @"..\..\skelatt1.wav";
            AtkSound = @"..\..\skelatt2.wav";
            DieSound = @"..\..\skel_die.wav";
        }
        
        public Skeleton(int ac, int life, int maxLife, int str, int dex, int con, int minDamage, int maxDamage, 
             int monExp, int monGold)
         {
            Random gp = new Random();
            Name = "Jack";
            MonType = "Skeleton";
            MaxLife = maxLife;
            Life = life;
            AC = ac;
            Str = str;
            Dex = dex;
            Con = con;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = "Bones, hard to break..";
            MonGold = monGold;
            MonGold = monExp;
            IdleSound = @"..\..\skelatt1.wav";
            AtkSound = @"..\..\skelatt2.wav";
            DieSound = @"..\..\skel_die.wav";

         }
        
        public override string ToString()
        {
            return "Bones, hard to hit.";
        }
    }
}
