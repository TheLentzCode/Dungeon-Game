using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Zombie : NonPlayer
    {
         public Zombie()
        {
            
            Random gp = new Random();
            MonType = "Zombie";
            MaxLife = 14;
            MaxDamage = 6;
            Name = "Rob";
            Life = 14;
            PlusToHit = 1;
            AC = 8;
            MinDamage = 1;
            Description = "Likes to eat braiiins";
            MonExp = 10;
            MonGold = gp.Next(1, 51);

            IdleSound = @"..\..\zom_idl1.wav";
            AtkSound = @"..\..\zom_att.wav";
            DieSound = @"..\..\zom_die.wav";
        }
        
        public Zombie(int ac, int life, int maxLife, int str, int dex, int con, int minDamage, int maxDamage, 
             int monExp, int monGold)
         {
            Random gp = new Random();
            Name = "Rob";
            MonType = "Zombie";
            MaxLife = maxLife;
            Life = life;
            AC = ac;
            Str = str;
            Dex = dex;
            Con = con;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = "Likes to eat Braaaiins";
            MonGold = monGold;
            MonExp = monExp;
            IdleSound = @"..\..\zom_idl1.wav";
            AtkSound = @"..\..\zom_att.wav";
            DieSound = @"..\..\zom_die.wav";

         }
        
        public override string ToString()
        {
            return "Braiiiiiinssssss";
        }
    }
}
