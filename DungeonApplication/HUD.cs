using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace DungeonApplication
{
    class HUD
    {
        public static void InstallHUD(Player player)
        {
            string name = player.Name;
            int str = player.Str;
            int dex = player.Dex;
            int con = player.Con;
            int intel = player.Intel;
            int wis = player.Wis;
            int cha = player.Cha;
            int maxLife = player.MaxLife;
            int life = player.Life;
            int ac = player.AC;
            int maxExp = player.MaxExp;
            int exp = player.Exp;
            int plusToHit = player.PlusToHit;
            int level = player.Level;
            int healPlus = player.HealPlus;
            decimal gp = player.Gold;
            Race charRace = player.CharacterRace;
            Class charClass = player.CharacterClass;

            Weapon w1 = new Weapon();
            Spells s1 = new Spells();

            if (player.CharacterClass == Class.Wizard)
            {
                plusToHit = player.MagicPlusToHit;
                s1 = player.EquippedSpell;
            }
            else
            {
                w1 = player.EquippedWeapon;
            }
            string xp = string.Format("                                          Level: {0,-3}                                  ", level );
            string c1 = string.Format("╔═════════════════════════╗                                             ╔═════════════════════════╗");
            string c2 = string.Format("║  Name:    {0,-10}    ║                                             ║                         ║", name);
            string c3 = string.Format("║  Race:    {0,-10}    ║                                             ║                         ║", charRace);
            string c4 = string.Format("║  Class:   {0,-7}       ║                                             ║                         ║", charClass);
            string c5 = string.Format("║  HP:    {0,-3} /  {1,-3}      ║                                             ║                         ║", life, maxLife);
            string c6 = string.Format("║    Str: {0,-3}  Int: {1,-3}   ║                                             ║                         ║", str, intel);
            string c7 = string.Format("║    Dex: {0,-3}  Wis: {1,-3}   ║                                             ║                         ║", dex, wis);
            string c8 = string.Format("║    Con: {0,-3}  Cha: {1,-3}   ║                                             ║                         ║", con, cha);
            string c9 = string.Format("║    AC:  {0,-3}             ║                                             ║                         ║", ac);
            string c10 = string.Format("║    + To Hit: {0,-3}        ║                                             ║                         ║", plusToHit);
            string c11 = string.Format("║    Equipped Weapon:     ║                                             ║                         ║");
            string c12 = string.Format("║    {0,-15}      ║                                             ║                         ║", w1.Name);
            string c13 = string.Format("║    {0,-3}-  {1,-3} Damage     ║                                             ║                         ║", w1.MinDamage, w1.MaxDamage);

            string c14 = string.Format("║  + {0} to Hit & Damage    ║                                             ║                         ║", w1.BonusHitChance);
            string c15 = string.Format("║  Gold: {0,-15:N1}  ║                                             ║                         ║", gp);
            string c16 = "╚═════════════════════════╝                                             ╚═════════════════════════╝";


            //Wizard Option
            string wiz1 = string.Format("║    Equipped Spell:      ║                                             ║                         ║");
            string wiz2 = string.Format("║    {0,-15}     ║                                             ║                         ║", s1.Name);
            string wiz3 = string.Format("║    {0,-3}- {1,-3}  Damage     ║                                             ║                         ║", s1.MinDamage, s1.MaxDamage);

            //Cleric Option
            string cleric1 = string.Format("║    + To Heal: {0,-3}       ║                                             ║                         ║", healPlus);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine(c9);
            Console.WriteLine(c10);
            if (player.CharacterClass == Class.Wizard)
            {
                Console.WriteLine(wiz1);
                Console.WriteLine(wiz2);
                Console.WriteLine(wiz3);
            }
            else if (player.CharacterClass == Class.Cleric)
            {
                Console.WriteLine(cleric1);
                Console.WriteLine(c11);
                Console.WriteLine(c12);
                Console.WriteLine(c13);
                Console.WriteLine(c14);
            }
            else
            {
                Console.WriteLine(c11);
                Console.WriteLine(c12);
                Console.WriteLine(c13);
                Console.WriteLine(c14);
            }
            Console.WriteLine(c15);
            Console.WriteLine(c16);
            Console.WriteLine(xp);
            Console.Write("\t\t\t\t    ");
            ExpProgressBar.DrawProgressBar(exp, maxExp, 20, '█');

            Console.WriteLine("\n\n\n");


        }

        public static void InstallHUD(Player player, NonPlayer monster)
        {
            string name = player.Name;
            int str = player.Str;
            int dex = player.Dex;
            int con = player.Con;
            int intel = player.Intel;
            int wis = player.Wis;
            int cha = player.Cha;
            int maxLife = player.MaxLife;
            int life = player.Life;
            int ac = player.AC;
            int maxExp = player.MaxExp;
            int exp = player.Exp;
            int plusToHit = player.PlusToHit;
            int level = player.Level;
            int healPlus = player.HealPlus;

            Race charRace = player.CharacterRace;
            Class charClass = player.CharacterClass;
            decimal gp = player.Gold;
            Weapon w1 = new Weapon();
            Spells s1 = new Spells();

            string monName = monster.Name;
            string monType = monster.MonType;
            int mMaxLife = monster.MaxLife;
            int mLife = monster.Life;
            int mMinDam = monster.MinDamage;
            int mMaxDam = monster.MaxDamage;
            int mAC = monster.AC;
            string descript = monster.Description;

            if (player.CharacterClass == Class.Wizard)
            {
                plusToHit = player.MagicPlusToHit;
                s1 = player.EquippedSpell;
            }
            else
            {
                w1 = player.EquippedWeapon;
            }
            string xp = string.Format("                                          Level: {0,-3}                                  ", level);
            string c1 = string.Format("╔═════════════════════════╗                                             ╔═════════════════════════╗");
            string c2 = string.Format("║  Name:    {0,-10}    ║                                             ║  Name: {1,-15}  ║", name, monName);
            string c3 = string.Format("║  Race:    {0,-10}    ║                                             ║  Type: {1,-15}  ║", charRace, monType);
            string c4 = string.Format("║  Class:   {0,-7}       ║                                             ║                         ║", charClass);
            string c5 = string.Format("║  HP:    {0,-3} /  {1,-3}      ║                                             ║  HP:    {2,-3} /  {3,-3}      ║", life, maxLife, mLife, mMaxLife);
            string c6 = string.Format("║    Str: {0,-3}  Int: {1,-3}   ║                                             ║  AC:  {2,-3}               ║", str, intel, mAC);
            string c7 = string.Format("║    Dex: {0,-3}  Wis: {1,-3}   ║                                             ║                         ║", dex, wis);
            string c8 = string.Format("║    Con: {0,-3}  Cha: {1,-3}   ║                                             ║  {2,-3}-  {3,-3} Damage       ║", con, cha, mMinDam, mMaxDam);
            string c9 = string.Format("║    AC:  {0,-3}             ║                                             ║  Ability:               ║", ac);
            string c10 = string.Format("║    + To Hit: {0,-3}        ║                                             ║{1,24} ║", plusToHit, descript);
            string c11 = string.Format("║    Equipped Weapon:     ║                                             ║                         ║");
            string c12 = string.Format("║    {0,-15}      ║                                             ║                         ║", w1.Name);
            string c13 = string.Format("║    {0,-3}-  {1,-3} Damage     ║                                             ║                         ║", w1.MinDamage, w1.MaxDamage);

            string c14 = string.Format("║  + {0} to Hit & Damage    ║                                             ║                         ║", w1.BonusHitChance);
            string c15 = string.Format("║  Gold: {0,-6:N1}           ║                                             ║                         ║", gp);
            string c16 = "╚═════════════════════════╝                                             ╚═════════════════════════╝";


            //Wizard Option
            string wiz1 = string.Format("║    Equipped Spell:      ║                                             ║                         ║");
            string wiz2 = string.Format("║    {0,-10}          ║                                             ║                         ║", s1.Name);
            string wiz3 = string.Format("║    {0,-3}- {1,-3}  Damage     ║                                             ║                         ║", s1.MinDamage, s1.MaxDamage);

            //Cleric Option
            string cleric1 = string.Format("║    + To Heal: {0,-3}       ║                                             ║                         ║", healPlus);

            
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine(c9);
            Console.WriteLine(c10);
            if (player.CharacterClass == Class.Wizard)
            {
                Console.WriteLine(wiz1);
                Console.WriteLine(wiz2);
                Console.WriteLine(wiz3);
            }
            else if (player.CharacterClass == Class.Cleric)
            {
                Console.WriteLine(cleric1);
                Console.WriteLine(c11);
                Console.WriteLine(c12);
                Console.WriteLine(c13);
                Console.WriteLine(c14);
            }
            else
            {
                Console.WriteLine(c11);
                Console.WriteLine(c12);
                Console.WriteLine(c13);
                Console.WriteLine(c14);
            }
            Console.WriteLine(c15);
            Console.WriteLine(c16);
            Console.WriteLine(xp);
            Console.Write("\t\t\t\t    ");
            ExpProgressBar.DrawProgressBar(exp, maxExp, 20, '█');
            Console.WriteLine();
            //Centered.LineReturn("              "+player.Exp + "               "+player.MaxExp        ); //Just for testing

        }


    }
}
/*


▓█████▄  █    ██  ███▄    █   ▄████ ▓█████  ▒█████   ███▄    █ 
▒██▀ ██▌ ██  ▓██▒ ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▒  ██▒ ██ ▀█   █ 
░██   █▌▓██  ▒██░▓██  ▀█ ██▒▒██░▄▄▄░▒███   ▒██░  ██▒▓██  ▀█ ██▒
░▓█▄   ▌▓▓█  ░██░▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ▒██   ██░▓██▒  ▐▌██▒
░▒████▓ ▒▒█████▓ ▒██░   ▓██░░▒▓███▀▒░▒████▒░ ████▓▒░▒██░   ▓██░
 ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ 
 ░ ▒  ▒ ░░▒░ ░ ░ ░ ░░   ░ ▒░  ░   ░  ░ ░  ░  ░ ▒ ▒░ ░ ░░   ░ ▒░
 ░ ░  ░  ░░░ ░ ░    ░   ░ ░ ░ ░   ░    ░   ░ ░ ░ ▒     ░   ░ ░ 
   ░       ░              ░       ░    ░  ░    ░ ░           ░ 
 ░█████   █    ██ ▓█████   ██████ ▄▄▄█████▓                    
▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒                    
▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░                    
░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░                     
░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░                     
░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░                       
 ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░                        
   ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░                          
    ░       ░        ░  ░      ░                               
                                                               














*/