using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Pixie : NonPlayer
    {
        private bool _isFlying;


        public bool IsFlying
        {
            get {return _isFlying;}
            set {
                Random rand = new Random();
                if(rand.Next(1,101) > 60)
                {
                    _isFlying = true;
                }
                else
                {
                    _isFlying = false;
                }
            }
        }
       

        //CTORS

        public Pixie()
        {
            //set our default values for default rabbit
            //SET MAX values first!!
            Random gp = new Random();
            MonType = "Pixie";
            MaxLife = 15;
            MaxDamage = 8;
            Name = "Justina";
            Life = 15;
            PlusToHit = 3;
            AC = 8;
            MinDamage = 1;
            Description = "Chance to x2 AC. Flying.";
            MonExp = 15;
            MonGold = gp.Next(1, 61);
            IdleSound = @"..\..\pixiehit.wav";
            AtkSound = @"..\..\pixiehit.wav";
            DieSound = @"..\..\pixiedie.wav";
        }
        
         public Pixie(int ac, int life, int maxLife, int str, int dex, int con, int minDamage, int maxDamage, 
             int monExp, int monGold)
         {
            Random gp = new Random();
            Name = "Justina";
            MonType = "Pixie";
            MaxLife = maxLife;
            Life = life;
            AC = ac;
            Str = str;
            Dex = dex;
            Con = con;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = "May have AC x2, flying";
            MonGold = monGold;
            MonExp = monExp;
            IdleSound = @"..\..\pixiehit.wav";
            AtkSound = @"..\..\pixiehit.wav";
            DieSound = @"..\..\pixiedie.wav";

         }
        //methods

        

        //Override calcblock bonus of 50% block if fluffy
        public override int CalcBlock()
        {
            //typically when dealing with a method that has a return type you create a variable
            //of the type you need to return with some default value, then write the return line
            //then write the code in between
            int calculatedBlock = AC;

            if (IsFlying)
            {
                AC += AC / 2;
            }

            return AC;
        }//end CalcBlock
        
        public override string ToString()
        {
            return "Chance to x2 AC. Flying";
        }
    }
}
