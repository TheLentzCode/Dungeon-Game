using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Specter : NonPlayer
    {

        

        public Specter()
        {
            
            Random gp = new Random();
            MonType = "Spectre";
            MaxLife = 20;
            MaxDamage = 8;
            Name = "Dr. No";
            Life = 20;
            PlusToHit = 1;
            AC = 8;
            MinDamage = 1;
            Description = "May drain life to heal.";
            MonExp = 20;
            MonGold = gp.Next(1, 51);

            IdleSound = @"..\..\spec_hit.wav";
            AtkSound = @"..\..\spec_att.wav";
            DieSound = @"..\..\spec_die.wav";
        }
        
        public Specter(int ac, int life, int maxLife, int str, int dex, int con, int minDamage, int maxDamage, 
             int monExp, int monGold)
         {
            Random gp = new Random();
            Name = "Dr. No";
            MonType = "Spectre";
            MaxLife = maxLife;
            Life = life;
            AC = ac;
            Str = str;
            Dex = dex;
            Con = con;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = "May drain life to heal.";
            MonGold = monGold;
            MonExp = monExp;
            IdleSound = @"..\..\spec_hit.wav";
            AtkSound = @"..\..\spec_att.wav";
            DieSound = @"..\..\spec_die.wav";

         }
        public override string ToString()
        {
            return "May drain life to heal.";
        }

        public override int CalcDamage()
        {
            //typically when dealing with a method that has a return type you create a variable
            //of the type you need to return with some default value, then write the return line
            //then write the code in between
            int damage = base.CalcDamage();
            Random rand = new Random();

            if (rand.Next(1, 101) >= 50)
            {
                
                this.Life += 5;
            }

            return damage;
        }
    }
}
