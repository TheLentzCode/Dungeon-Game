using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace DungeonLibrary
{
    [Serializable()]
    public class Player : Character
    {
        //fields
        string sndLevelUp = @"..\..\levelup.wav";
        SoundPlayer media = new SoundPlayer();

        private int _cha;
        
        private int _exp;
        private int _level;
       

        public Race CharacterRace { get; set; }
        public Class CharacterClass { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Spells EquippedSpell { get; set; }
        public Item Slot1 { get; set; }
        public Item Slot2 { get; set; }
        public decimal Discount { get; set; }
        public decimal Gold { get; set; }
        public int MaxExp { get; set; }

        public int Cha
        {
            get { return _cha; }
            set
            {
                switch (value)
                {
                    case 18:
                        _cha = value;
                        Discount = 2m;
                        break;
                    case 17:
                        _cha = value;
                        Discount = 1.8m;
                        break;
                    case 16:
                        _cha = value;
                        Discount = 1.5m;
                        break;
                    case 15:
                        _cha = value;
                        Discount = 1.2m;
                        break;
                    case 14:
                    default:
                        _cha = value;
                        break;
                }


            }
        }

       




        #region Level Props
        public int Level
        {
            get { return _level; }
            set
            {
                switch (value)
                {
                    case 1:
                         MaxExp = 300;
                         _level = value;
                        
                        if (CharacterClass == Class.Warrior)
                        {
                            this.MaxLife += 10;
                            this.Life = MaxLife;
                        }
                        else if (CharacterClass == Class.Wizard)
                        {
                            this.MaxLife += 6;
                            this.Life = MaxLife;
                        }
                        else if (CharacterClass == Class.Theif)
                        {
                            this.MaxLife += 8;
                            this.Life = MaxLife;
                        }
                        else if (CharacterClass == Class.Cleric)
                        {
                            this.MaxLife += 8;
                            this.Life = MaxLife;
                        }
                        
                        break;
                    case 2:
                        Exp = Exp - MaxExp;
                        MaxExp = 600;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 3:
                        Exp = Exp - MaxExp;
                        MaxExp = 1700;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 4:
                        Exp = Exp - MaxExp;
                         MaxExp = 4200;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 5:
                        Exp = Exp - MaxExp;
                         MaxExp = 9250;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 6:
                        Exp = Exp - MaxExp;
                         MaxExp = 15180;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 7:
                        Exp = Exp - MaxExp;
                         MaxExp = 22450;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 9:
                        Exp = Exp - MaxExp;
                         MaxExp = 31680;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 10:
                        Exp = Exp - MaxExp;
                         MaxExp = 42250;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 11:
                        Exp = Exp - MaxExp;
                         MaxExp = 56100;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 12:
                        Exp = Exp - MaxExp;
                         MaxExp = 66000;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 13:
                        Exp = Exp - MaxExp;
                         MaxExp = 79200;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 14:
                        Exp = Exp - MaxExp;
                         MaxExp = 92400;
                         _level = value;
                         if (CharacterClass == Class.Warrior)
                         {
                             this.MaxLife += 10;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Wizard)
                         {
                             this.MaxLife += 6;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Theif)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                         else if (CharacterClass == Class.Cleric)
                         {
                             this.MaxLife += 8;
                             this.Life = MaxLife;
                         }
                        break;
                    case 15:
                        Exp = Exp - MaxExp;
                        MaxExp = 108900;
                        _level = value;
                        if (CharacterClass == Class.Warrior)
                        {
                            this.MaxLife += 10;
                            this.Life = MaxLife;
                        }
                        else if (CharacterClass == Class.Wizard)
                        {
                            this.MaxLife += 6;
                            this.Life = MaxLife;
                        }
                        else if (CharacterClass == Class.Theif)
                        {
                            this.MaxLife += 8;
                            this.Life = MaxLife;
                        }
                        else if (CharacterClass == Class.Cleric)
                        {
                            this.MaxLife += 8;
                            this.Life = MaxLife;
                        }
                        break;
                    default:
                        _level = value;
                        //MaxExp = 300;
                        break;
                }
            }
        }
        #endregion


       
   

        public int Exp
        {
            get { return _exp; }
            set
            {
                _exp = value;
                
                
                if(_exp >= MaxExp)
                {
                    Level += 1;
                    media.SoundLocation = sndLevelUp;
                    media.Play();
                }
                
                /*
                switch (value)
                {   
                    case 300:
                        Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 900:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 2700:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 6500:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 14000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 23000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 34000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 48000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 64000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 85000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 100000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 120000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 140000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
                    case 165000:
                         Level += 1;
                        media.SoundLocation = sndLevelUp;
                        media.Play();
                        break;
   
                    default:
                        break;
                }
            */
                
            }
        }

        //CTOR
       

        public Player()
        {

        }

        public Player(string load)
        {

        }

        public Player(string name, int level, int exp, int ac, int life, int maxLife, 
            int str, int dex, int con, int intel, 
            int wis, int cha, Race characterRace, Class characterClass, int gold, 
            Weapon equippedWeapon, Spells equippedSpell, Item slot1, Item slot2)
        {
            Random rand = new Random();

            Name = name;
            Level = level;
            Exp = exp;
            AC = ac;
            MaxLife = maxLife;
            Life = life;
            Str = str;
            Dex = dex;
            Con = con;
            Intel = intel;
            Wis = wis;
            Cha = cha;
            Gold = gold;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            EquippedSpell = equippedSpell;
            Slot1 = slot1;
            Slot2 = slot2;
        }

        //public Player(string name, string level, string exp, string ac, string life, string maxLife, 
        //    string str, string dex, string con, string intel, 
        //    string wis, string cha, Race characterRace, Class characterClass, string gold, 
        //    Weapon equippedWeapon, Spells equippedSpell)
        //{
            
        //    Name = name;
        //    Level = int.Parse(level);
        //    Exp = int.Parse(exp);
        //    AC = int.Parse(ac);
        //    MaxLife = int.Parse(maxLife);
        //    Life = int.Parse(life);
        //    Str = int.Parse(str);
        //    Dex = int.Parse(dex);
        //    Con = int.Parse(con);
        //    Intel = int.Parse(intel);
        //    Wis = int.Parse(wis);
        //    Cha = int.Parse(cha);
        //    Gold = int.Parse(gold);
        //    CharacterClass = characterClass;
        //    CharacterRace = characterRace;
        //    EquippedWeapon = equippedWeapon;
        //    EquippedSpell = equippedSpell;

        //}

        public override string ToString()
        {
            if(this.EquippedSpell == null)
            {
               

                return Name + " - Level: " +  Level +" " + CharacterRace + " / " + CharacterClass + ", Gold: " + Gold + ", Weapon: " + EquippedWeapon.Name;
            }
            else 
            {



                return Name + " - Level: " + Level + " " + CharacterRace + " / " + CharacterClass + ", Gold: " + Gold + ", Spell: " + EquippedSpell.Name;
            }
  
        }

        public string ItemsList()
        {
            return "Slot 1: " + Slot1.Name + "     Slot 2: " + Slot2.Name;
        }

        //override CalcDamage in player to use their weapon's prop of min/max dam
        public override int CalcDamage()
        {
            //need to create a random object
            Random rand = new Random();
            int damage = 0;
            if (this.CharacterClass == Class.Wizard)
            {
                damage = (rand.Next(EquippedSpell.MinDamage, EquippedSpell.MaxDamage + 1)) + MagicPlusToHit;
            }
            else if (this.CharacterClass == Class.Theif)
            {
                if(rand.Next(1,101) >= 70)
                {
                    //Backstab
                    damage = ((rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1)) * 3)+ PlusToHit + EquippedWeapon.BonusHitChance;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                    Centered.LineReturn("BACKSTAB!!! x 3 Damage!");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    damage = (rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1)) + PlusToHit + EquippedWeapon.BonusHitChance;
                }
            }
            else if (this.CharacterClass == Class.Cleric)
            {
                if (rand.Next(1,101)>= 70)
                {
                    //You get off a heal too
                    this.Life += (10 + this.HealPlus);
                    damage = (rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1)) + PlusToHit + EquippedWeapon.BonusHitChance;
                    Console.ForegroundColor = ConsoleColor.White;
                    Centered.LineReturn("YOU CAST A HEAL!!");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    damage = (rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1)) + PlusToHit + EquippedWeapon.BonusHitChance;
                }
            }
            else
            {
                damage = (rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1)) + PlusToHit + EquippedWeapon.BonusHitChance;
            }
            //return the damage
            return damage;
        }//end CalcDamage


        public override int CalcHitChance()
        {
            if (this.CharacterClass == Class.Wizard)
            {
                return MagicPlusToHit;
            }
            else
            {
                return PlusToHit + EquippedWeapon.BonusHitChance;
            }
        }//end CalcHitChance

       
    }//end player
}
