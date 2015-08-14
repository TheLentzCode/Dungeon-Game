using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    [Serializable()]
    public class Character
    {
        //We brought over all of fields and props shared between PC and NPC then 
        //comment them out in the player class. This will allow inheritance to
        //optimize our code use
        

        private int _life;
        private int _str;
        private int _dex;
        private int _con;
        private int _intel;
        private int _wis;
        

        public string Name { get; set; }
        public int AC { get; set; }
        public int MaxLife { get; set; }
        public int PlusToHit { get; set; }
        public int MagicPlusToHit { get; set; }
        public int HealPlus { get; set; }
        

        public int Str
        {
            get { return _str; }
            set
            {
                switch (value)
                {
                    case 20:
                       _str = value;
                       PlusToHit = 6;
                       break;
                    case 19:
                       _str = value;
                       PlusToHit = 5;
                       break;
                    case 18:
                       _str = value;
                       PlusToHit = 4;
                       break;
                    case 17:
                        _str = value;
                        PlusToHit = 3;
                        break;
                    case 16:
                        _str = value;
                        PlusToHit = 2;
                        break;
                    case 15:
                        _str = value;
                        PlusToHit = 1;
                        break;
                    case 14:
                    default:
                        _str = value;
                        break;
                }
            }
        }

        public int Dex
        {
            get { return _dex; }
            set
            {
                switch (value)
                {
                    case 20:
                        _dex = value;
                        AC += 6;
                        break;
                    case 19:
                        _dex = value;
                        AC += 5;
                        break;
                    case 18:
                        _dex = value;
                        AC += 4;
                        break;
                    case 17:
                        _dex = value;
                        AC += 3;
                        break;
                    case 16:
                        _dex = value;
                        AC += 2;
                        break;
                    case 15:
                        _dex = value;
                        AC += 1;
                        break;
                    case 14:
                    default:
                        _dex = value;
                        break;
                }

            }
        }

        public int Con
        {
            get { return _con; }
            set
            {
                switch (value)
                {
                    case 20:
                        _con = value;
                        MaxLife += 35;
                        Life += 35;
                        break;
                    case 19:
                        _con = value;
                        MaxLife += 30;
                        Life += 30;
                        break;
                    case 18:
                        _con = value;
                        MaxLife += 25;
                        Life += 25;
                        break;
                    case 17:
                        _con = value;
                        MaxLife += 20;
                        Life += 20;
                        break;
                    case 16:
                        _con = value;
                        MaxLife += 15;
                        Life += 15;
                        break;
                    case 15:
                        _con = value;
                        MaxLife += 10;
                        Life += 10;
                        break;
                    case 14:
                    default:
                        _con = value;
                        break;
                }

            }
        }

        public int Intel
        {
            get { return _intel; }
            set
            {
                switch (value)
                {
                    case 20:
                        _intel = value;
                        MagicPlusToHit += 6;
                        break;
                    case 19:
                        _intel = value;
                        MagicPlusToHit += 5;
                        break;
                    case 18:
                        _intel = value;
                        MagicPlusToHit += 4;
                        break;
                    case 17:
                        _intel = value;
                        MagicPlusToHit += 3;
                        break;
                    case 16:
                        _intel = value;
                        MagicPlusToHit += 2;
                        break;
                    case 15:
                        _intel = value;
                        MagicPlusToHit += 1;
                        break;
                    case 14:
                    default:
                        _intel = value;
                        break;
                }

            }
        }

        public int Wis
        {
            get { return _wis; }
            set
            {
                switch (value)
                {
                    case 20:
                        _wis = value;
                        HealPlus += 12;
                        break;
                    case 19:
                        _wis = value;
                        HealPlus += 10;
                        break;
                    case 18:
                        _wis = value;
                        HealPlus += 8;
                        break;
                    case 17:
                        _wis = value;
                        HealPlus += 6;
                        break;
                    case 16:
                        _wis = value;
                        HealPlus += 4;
                        break;
                    case 15:
                        _wis = value;
                        HealPlus += 2;
                        break;
                    case 14:
                    default:
                        _wis = value;
                        break;
                }

            }
        }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else

            }//end set
        }//end Life

        

        //Since we don't inherit CTOR and we already did a lot of work on the one in player
        //we will not create any ctor here. The default will remain.

        //methods. No need to override the tostring. We will never create a character object
        //it will always be a PC or NPC

        //Below are methods we want to be inherited by PC and NPC so we are created default
        //versions of those here

        public virtual int CalcBlock()
        {
            //To be able to override this in a child class make it virtual.

            //This version just returns block, but will give us the option to do something
            //different in the child classed.

            return AC;

        }//end CalcBlock

        public virtual int CalcHitChance()
        {

            return PlusToHit;
        }//end CalcHitChance

        public virtual int CalcDamage()
        {
            return 0;
            //Starting this method with just returning 0 so we can use the method from
            //a instance of a character. We will override in child classes
        }

        public virtual int CalcMagicDamage()
        {
            return 0;
            //Starting this method with just returning 0 so we can use the method from
            //a instance of a character. We will override in child classes
        }

        public virtual int CalcHeal()
        {
            return 0;
            //Starting this method with just returning 0 so we can use the method from
            //a instance of a character. We will override in child classes
        }

    }//end Character
}
