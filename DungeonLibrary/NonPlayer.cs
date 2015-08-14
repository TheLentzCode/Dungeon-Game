using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class NonPlayer : Character
    {
        //Businuss rule on minDamage

        //fields
        private int _minDamage;

        //properties

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public string MonType { get; set; }
        public int MonExp { get; set; }
        public int MonGold { get; set; }
        public string IdleSound { get; set; }
        public string AtkSound { get; set; }
        public string DieSound { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end MinDamge

        //ctor

        public NonPlayer()
        {

        }

        public NonPlayer(string name, string monType, int ac, int life, int maxLife, int plusToHit, int magicPlusToHit, 
            int healPlus, int str, int dex, int con, int intel, int wis, int minDamage,
            int maxDamage, string description, int monExp, int monGold,
            string idleSound, string atkSound, string dieSound)
        {
            //no fully qualified ctor in parent so we handle it all here
            //set MaxLife and MaxDamage first
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            MonType = monType;
            AC = ac;
            Life = life;
            PlusToHit = plusToHit;
            MagicPlusToHit = magicPlusToHit;
            HealPlus = healPlus;
            Str = str;
            Dex = dex;
            Con = con;
            Intel = intel;
            Wis = wis;
            MinDamage = minDamage;
            Description = description;
            IdleSound = idleSound;
            AtkSound = atkSound;
            DieSound = dieSound;

        }//end fqctor

        //methods

        public override string ToString()
        {
            return string.Format(
                " ---====<<< Monster Name: {0} >>>====---\n" +
                "           Hitpoints:       {1}/{2}\n" +
                "           Damage:          {3}-{4}\n" +
                "           Block:           {5} \n" +
                "           Descriptions:\n" +
                "   {6} \n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                AC,
                Description
                );
        }//end ToString

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }//end CalcDamage






    }//end nonPlayer
}
