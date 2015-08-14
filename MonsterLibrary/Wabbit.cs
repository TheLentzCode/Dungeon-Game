using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Wabbit : NonPlayer
    {

        //created a child monster with at least one unique property
        //you can use auto prop

        //fields and property
        public bool _isFluffy;


        public bool IsFluffy
        {
            get {return _isFluffy;}
            set {
                Random rand = new Random();
                if(rand.Next(1,101) > 60)
                {
                    _isFluffy = true;
                }
                else
                {
                    _isFluffy = false;
                }
            }
        }
       

        //CTORS

        public Wabbit()
        {
            //set our default values for default rabbit
            //SET MAX values first!!
            Random gp = new Random();
            MonType = "Wabbit";
            MaxLife = 4;
            MaxDamage = 3;
            Name = "Rabid Wabbit";
            Life = 6;
            PlusToHit = 5;
            AC = 4;
            MinDamage = 0;
            Description = "Chance to x2 AC. Fluffy";
            MonExp = 10;
            MonGold = gp.Next(1, 61);
        }
        
        /*
        public Wabbit(string name, int life, int maxLife, int hitChance, int block, int minDamage,
            int maxDamage, string description, bool isFluffy) 
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsFluffy = isFluffy;
        }//end fqctor

        */
        //methods

        

        //Override calcblock bonus of 50% block if fluffy
        public override int CalcBlock()
        {
            //typically when dealing with a method that has a return type you create a variable
            //of the type you need to return with some default value, then write the return line
            //then write the code in between
            int calculatedBlock = AC;

            if (IsFluffy)
            {
                AC += AC / 2;
            }

            return AC;
        }//end CalcBlock
        
        public override string ToString()
        {
            return "Chance to x2 AC. Fluffy";
        }
    }//end wabbit
}
