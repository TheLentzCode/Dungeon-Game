using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using DungeonLibrary;
using MonsterLibrary;
using WeaponLibrary;
using SpellLibrary;
using ItemLibrary;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowChange.WinPos();
            Console.ForegroundColor = ConsoleColor.Red;

            //Sound player and Variables for sound files
            SoundPlayer media = new SoundPlayer();
            SoundPlayer theme = new SoundPlayer();
            string sndTheme = @"..\..\eqtheme.wav";
            string sndCombat = @"..\..\combattheme1.wav";
            string sndDeath = @"..\..\deaththeme.wav";
            string sndTemple = @"..\..\GuildHall.wav";
            string sndTown = @"..\..\poknowledge.wav";
            string sndInn = @"..\..\potranq.wav";
            string sndBuyItem = @"..\..\buyitem.wav";

            string sndHeal = @"..\..\spelhit2.wav";



            //String Variables for game text

            #region Start Up Variables

            string[] gameTitle = {
    
                "  ▓█████▄  █    ██  ███▄    █   ▄████ ▓█████  ▒█████   ███▄    █ ",
                "  ▒██▀ ██▌ ██  ▓██▒ ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▒  ██▒ ██ ▀█   █ ",
                "  ░██   █▌▓██  ▒██░▓██  ▀█ ██▒▒██░▄▄▄░▒███   ▒██░  ██▒▓██  ▀█ ██▒",
                "  ░▓█▄   ▌▓▓█  ░██░▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ▒██   ██░▓██▒  ▐▌██▒",
                "  ░▒████▓ ▒▒█████▓ ▒██░   ▓██░░▒▓███▀▒░▒████▒░ ████▓▒░▒██░   ▓██░",
                "   ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ",
                "   ░ ▒  ▒ ░░▒░ ░ ░ ░ ░░   ░ ▒░  ░   ░  ░ ░  ░  ░ ▒ ▒░ ░ ░░   ░ ▒░",
                "   ░ ░  ░  ░░░ ░ ░    ░   ░ ░ ░ ░   ░    ░   ░ ░ ░ ▒     ░   ░ ░ ",
                "     ░       ░              ░       ░    ░  ░    ░ ░           ░ ",
                "    ░█████   █    ██ ▓█████   ██████ ▄▄▄█████▓                    ",
                "   ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒                    ",
                "   ▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░                    ",
                "   ░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░                     ",
                "   ░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░                     ",
                "   ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░                       ",
                "    ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░                        ",
                "      ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░                          ",
                "       ░       ░        ░  ░      ░                               "

                                    };

            string startUp = "S)Start New Game                                    L)Load Saved Game";

            const string saveChar = @"..\..\saveGame.txt";
            const string saveItems = @"..\..\saveGameItems.txt";
            const string saveFile = @"..\..\saveGame.txt";
            const string saveBin = @"..\..\saveGame.bin";
            FileInfo save = new FileInfo(saveFile);
            string charText = System.IO.File.ReadAllText(saveChar);
            string itemsText = System.IO.File.ReadAllText(saveItems);
            string savedChar = "The following game is saved. Would you like to load it? Y/N";
            string[] loadScreen = {
                 "╔═════════════════════════════════════════════════════════════════════════════════════════════════╗",
                 "║                                                                                                 ║",
                 string.Format("║               {0, -68}              ║", charText),
                 string.Format("║               {0, -68}              ║", itemsText),
                 "║                                                                                                 ║",
                 "╚═════════════════════════════════════════════════════════════════════════════════════════════════╝",
                       
                       
                       };

            #endregion


            #region Town Variables

            string[] TownDescription = {
                    "You enter the town of Silverymoon. A bustling town of peace ",
                    "and commerce built at the base of a huge snowcapped mountain.",
                    "All races have banded together in this bastion of hope and   ",
                    "light. There is something for everyone here. \n",
                    "                                     ",
                    "What would you like to do?"

                                       };//end array


            string[] menu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        G) Go Shopping!          ║",
                     "║        V) Visit The Temple      ║",
                     "║        T) The Inn               ║",
                     "║        A) Adventure!            ║",
                     "║        I) Inventory             ║",
                     "║        S) Save Game             ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };//end array

            #endregion


            #region Dungeon Variables



            string[] advTime = {
                           "Getting to know the town, you've come to understand that ",
                           "it's peacefulness strained by the constant threat of the ",
                           "denizens of the labyrinth under the mountain. The town   ",
                           "sends adventurers like yourself, into the tunnels to help",
                           "secure the safety of the town. Any riches found are yours.\n\n",
                           "Dungeon Crawl Time? Y/N"
                                     };//end array

            string[] dungeonMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        A) Attack                ║",
                     "║        F) Flee                  ║",
                     "║        U) Use Item              ║",
                     "║        I) Inventory             ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };
            string flee = "Flee, Fool....FLEE!";
            string flee2 = "You're attacked as you run like a frightened child!";
            string death = "You're dead dog.... HAHAHAHAHA. No Rez for j00..\a";

            int bossCount = 0;

            string[] useItemDis1 = {
                 "╔═══════════════════════════════════════════════════════════════════════════════╗",
                 "║                                                                               ║"
                                   };

            string[] useItemDis4 = {
                 "║                                                                               ║",
                 "╚═══════════════════════════════════════════════════════════════════════════════╝"
                                   };


            string[] useItemMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        1) Use Item in Slot 1    ║",
                     "║        2) Use Item in Slot 2    ║",
                     "║                                 ║",
                     "║        R) Return to Battle      ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };
            string[] invMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║                                 ║",
                     "║                                 ║",
                     "║                                 ║",
                     "║        R) Return to Battle      ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };

            int heal = 0;
            int missileDam = 0;
            #endregion


            #region Character Creation Variables

            //Random for dice roll
            Random rand = new Random();
            int threed6 = rand.Next(19);

            //Character Creation Variables

            int str = 1;
            int dex = 1;
            int con = 1;
            int intel = 1;
            int wis = 1;
            int cha = 1;


            string classChoice = "";
            string charName = "";
            Race charRace = Race.Dwarf;
            Class charClass = Class.Cleric;
            StarterSword s1 = new StarterSword();
            StarterSpell sp1 = new StarterSpell();
            StarterMace m1 = new StarterMace();
            StarterDagger d1 = new StarterDagger();
            Empty noItem = new Empty();
            Player player = new Player();





            string introduction = "Welcome to the world mortal.";
            string charCreation = "We will now create your character.";
            string charCreation2 = "Please answer the following questions";
            string charCreation3 = "What would you like your name to be? ";
            string charNameLimit = "Enter a name up to 10 characters long.";
            string[] charCreation4 = {
                    "What Race of The Realms would you be? Choose from the following:",
                    "1) Human - Standard Humans. The common race in The Realms.      ",
                    "2) Elf   - Pointed ears, tall and long living.                  ",
                    "3) Dwarf - Short, Bearded, gruff, barrel-chested hardy folk.    ",
                    "4) Halfling - Tall at 3 foot, Halflings are small folk.         "
                                     };
            string[] charCreation5 = {
                    "What Class of Adventurer would you be? Choose from the following: ",
                    "1) MeatShield - Fighter that can take, damage and deal it too.    ",
                    "2) AgroMaster - Magic-User that uses spells to damage foes.       ",
                    "3) SneakyPete - One that can hide & deal extra damage from behind.",
                    "4) War Priest - Can beat some butt, and heal up with god power.   "
                                     };

            string[] statExplain = {
                                       "Stats Quickie Review:",
                                       "The higher the stat, it may add to other attributes",
                                       "Str - Adds + Hit/Dam for all but AgroMaster.",
                                       "Dex - Adds to AC                            ",
                                       "Con - Adds to hit points                    ",
                                       "Int - Adds + Hit/Dam for AgroMaster         ",
                                       "Wis - Adds + to heals for War Priest        ",
                                       "Cha - possible to give discounts            "
                                   };

            string charCreation6 = "Would you like to re-roll scores? Y/N:     ";

            #endregion


            #region Temple Variables

            string[] templeDescrip = {
                                     "You enter the large ornate doors of the Temple of Tyr.",
                                     "As you enter into the large house of the god, you feel ",
                                     "a sense of peace. You know this is a place of goodness.",
                                     ""                                     
                                 };

            string[] templeMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        H) Heal 1/2   150gp      ║",
                     "║        F) Full Heal  300gp      ║",
                     "║        R) Return to Town        ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };

            string halfHeal = "You pay a Cleric of Tyr to heal most of your wounds.";
            string fullHeal = "You pay a Cleric of Tyr to fully heal your wounds!";


            #endregion


            #region Inn Variables

            string[] innDescrip = {
                                      "As you enter the loud and bustling Inn, you are greeted",
                                      "with the sight of many patrons in the common room eating,",
                                      "drinking and having a good time. You get the feel this is",
                                      "one of the town's main gathering spots. A large man stands",
                                      "behind a desk smiling and waving you over.",
                                      "What would you like to do in the Inn?",
                                  };

            string[] innMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        G) Get a Room  15gp      ║",
                     "║                                 ║",
                     "║        R) Return to Town        ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };
            string[] sleptNight = {
                                      "You ate a hardy meal and then slept for the night. Depending",
                                      "on how well you slept and rested your body, you may have healed",
                                      "for a little bit."
                                  };

            #endregion


            #region Shop Variables

            string[] shopMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        W) Weapon/Spell          ║",
                     "║        I) Items                 ║",
                     "║        R) Return to Town        ║",
                     "║        X) Exit Game             ║",
                     "╚═════════════════════════════════╝\n"
                                    };
            string[] buyMenu = {
                     "╔═════════════════════════════════╗",
                     "║       Choose your action:       ║",
                     "║        1) Buy Item #1           ║",
                     "║        2) Buy Item #2           ║",
                     "║        3) Buy Item #3           ║",
                     "║        4) Buy Item #4           ║",
                     "║        5) Buy Item #5           ║",
                     "║        R) Done Browsing         ║",
                     "╚═════════════════════════════════╝\n"
                                    };



            string[] shopDescrip ={
                        "You enter what seemed like a small building, only to",
                        "see a huge multi level building. It seems to be bigger",
                        "on the inside... At a counter among the shelves and ",
                        "glass cases floats a Halfling man reading a book. He ",
                        "looks up and sees you. He smiles and welcomes you to ",
                        "Stuff-Mart....What would you like to do?"
                                };
            string newSpell = "You have purchased a spell upgrade. Use it well!";
            string newWeapon = "You have purchased a weapon upgrade. Use it well!";
            string notUpgrade = "This choice is not an upgrade. Not purchased.";

            Dagger1 d2 = new Dagger1();
            Dagger2 d3 = new Dagger2();
            Dagger3 d4 = new Dagger3();
            Dagger4 d5 = new Dagger4();
            Dagger5 d6 = new Dagger5();
            Mace1 m2 = new Mace1();
            Mace2 m3 = new Mace2();
            Mace3 m4 = new Mace3();
            Mace4 m5 = new Mace4();
            Mace5 m6 = new Mace5();
            Spell1 sp2 = new Spell1();
            Spell2 sp3 = new Spell2();
            Spell3 sp4 = new Spell3();
            Spell4 sp5 = new Spell4();
            Spell5 sp6 = new Spell5();
            Sword1 s2 = new Sword1();
            Sword2 s3 = new Sword2();
            Sword3 s4 = new Sword3();
            Sword4 s5 = new Sword4();
            Sword5 s6 = new Sword5();
            PoH pot1 = new PoH();
            PoGH pot2 = new PoGH();
            PoSH pot3 = new PoSH();
            ScrollEscape scroll1 = new ScrollEscape();
            WandMissiles wand1 = new WandMissiles();


            #endregion

            //Commonly used 
            string yourChoice = "Your choice:    ";
            string invalidEntry = "That's not one of the choices, there bud. Try again.";
            string notEnoughGold = "Nice try there Nimrod. You don't have enough gold!";





            //Loop condition bools
            bool start = false;
            bool charCreated = false;
            bool racePick = false;
            bool classPick = false;
            bool exit = false;
            bool leaveTown = false;
            bool reload = false;
            bool reroll = true;
            bool leaveInn = false;
            bool leaveTemp = false;
            bool newRoom = false;
            bool leaveShop = false;
            bool weapShopping = true;
            bool itemShopping = true;
            bool useItem = true;
            bool useInv = true;

            do //do loop that controls entire game
            {

                #region Start Up
                theme.SoundLocation = sndTheme;
                theme.PlayLooping();
                Console.Title = "---=== Dungeon Quest ===---";

                do
                {

                    Console.WriteLine("\n\n");
                    //Console.WriteLine(test);
                    Centered.Section(gameTitle);
                    Console.WriteLine("\n\n");
                    Centered.LineReturn(startUp);
                    Console.Write("                                                 ");
                    string startChoice = Console.ReadLine().ToUpper();
                    startChoice = startChoice.Substring(0, 1);
                    switch (startChoice)
                    {
                        case "S":
                            start = true;
                            break;
                        case "L":
                            if (save.Length > 0)
                            {

                                if (File.Exists(saveBin))
                                {

                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\n\n");
                                    Centered.LineReturn(savedChar);
                                    Console.WriteLine("\n\n");
                                    Centered.Section(loadScreen);
                                    Console.WriteLine("\n\n\n");

                                    string loadChoice = Console.ReadLine().ToUpper();
                                    loadChoice = loadChoice.Substring(0, 1);

                                    switch (loadChoice)
                                    {
                                        case "Y":
                                            Stream TestFileStream = File.OpenRead(saveBin);
                                            BinaryFormatter deserializer = new BinaryFormatter();
                                            player = (Player)deserializer.Deserialize(TestFileStream);
                                            TestFileStream.Close();

                                            start = true;
                                            charCreated = true;

                                            break;
                                        case "N":
                                            start = true;
                                            break;
                                        default:
                                            Centered.LineReturn(invalidEntry);
                                            break;
                                    }


                                }
                                else
                                {
                                    Centered.LineReturn("No saved games....move along.");

                                    start = true;
                                    Console.ReadKey();
                                }

                            }
                            break;
                        default:

                            break;
                    }

                } while (!start);
                #endregion

                #region Character Creation
                //do //do loop that controls char creation
                while (!charCreated && !exit)
                {
                    //string test = Environment.CurrentDirectory;

                    Console.Clear();
                    Console.WriteLine("\n\n\n\n");
                    Centered.LineReturn(introduction);
                    Console.WriteLine("\n\n\n");
                    Centered.LineReturn(charCreation);
                    Centered.LineReturn(charCreation2);
                    Console.WriteLine("\n\n");
                    Centered.LineReturn(charCreation3);
                    Centered.LineReturn(charNameLimit);
                    Console.WriteLine("\n\n");
                    Centered.Line(yourChoice);
                    charName = Console.ReadLine();
                    if (charName.Length > 10)
                    {
                        //Cuts off the character name if > 10
                        charName = charName.Substring(0, 10);
                    }
                    else if (charName.Length == 0)
                    {
                        charName = "Zero";
                    }
                    Console.Clear();
                    do
                    {
                        Console.WriteLine();
                        Centered.Section(charCreation4);
                        Centered.Line(yourChoice);
                        string raceChoice = Console.ReadLine();
                        switch (raceChoice)
                        {
                            case "1":
                                charRace = Race.Human;
                                racePick = true;
                                break;
                            case "2":
                                charRace = Race.Elf;
                                racePick = true;
                                break;
                            case "3":
                                charRace = Race.Dwarf;
                                racePick = true;
                                break;
                            case "4":
                                charRace = Race.Halfling;
                                racePick = true;
                                break;
                            default:
                                Centered.Line(invalidEntry);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    } while (!racePick);

                    do
                    {
                        Console.WriteLine();
                        Centered.Section(charCreation5);
                        Centered.Line(yourChoice);
                        classChoice = Console.ReadLine();
                        switch (classChoice)
                        {
                            case "1":
                                charClass = Class.Warrior;
                                classPick = true;
                                break;
                            case "2":
                                charClass = Class.Wizard;
                                classPick = true;
                                break;
                            case "3":
                                charClass = Class.Theif;
                                classPick = true;
                                break;
                            case "4":
                                charClass = Class.Cleric;
                                classPick = true;
                                break;
                            default:
                                Centered.Line(invalidEntry);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    } while (!classPick);
                    Console.Clear();
                    do
                    {
                        str = rand.Next(1, 19);
                        dex = rand.Next(1, 19);
                        con = rand.Next(1, 19);
                        intel = rand.Next(1, 19);
                        wis = rand.Next(1, 19);
                        cha = rand.Next(1, 19);

                        string[] c1 = {
                            "Let's have a look at your stats. You may re-roll until you like.",
                            "                                   ",
                            "╔═════════════════════════════════╗",
                            "║    Character Ability Scores:    ║",
                            "║                                 ║"
                                         };

                        string c2 = string.Format("║      Strength:       {0,-3}        ║", str);
                        string c3 = string.Format("║      Dexterity:      {0,-3}        ║", dex);
                        string c4 = string.Format("║      Constitution:   {0,-3}        ║", con);
                        string c5 = string.Format("║      Intelligence:   {0,-3}        ║", intel);
                        string c6 = string.Format("║      Wisdom:         {0,-3}        ║", wis);
                        string c7 = string.Format("║      Charisma:       {0,-3}        ║", cha);
                        string[] c8 = {
                             "║                                 ║",
                             "╚═════════════════════════════════╝\n"
                                     };
                        Console.WriteLine("\n\n");
                        Centered.Section(c1);
                        Centered.LineReturn(c2);
                        Centered.LineReturn(c3);
                        Centered.LineReturn(c4);
                        Centered.LineReturn(c5);
                        Centered.LineReturn(c6);
                        Centered.LineReturn(c7);
                        Centered.Section(c8);
                        Centered.Section(statExplain);
                        Console.WriteLine("\n\n");
                        Centered.Line(charCreation6);
                        string rerollChoice = Console.ReadLine().ToUpper();
                        //rerollChoice = rerollChoice.Substring(0, 1);
                        switch (rerollChoice)
                        {
                            case "Y":
                            case "YES":
                                Console.Clear();
                                break;
                            case "N":
                            case "NO":
                                reroll = false;
                                break;
                            case "GOD":
                                str = 18;
                                dex = 18;
                                con = 18;
                                intel = 18;
                                wis = 18;
                                cha = 18;
                                reroll = false;
                                break;
                            default:
                                Console.Clear();
                                Centered.Line(invalidEntry);
                                break;
                        }

                        //Making Player
                        //Warrior:  +1 str, +1 dex, +1 con
                        //Wizard:   +1 dex, +2 Intel 
                        //Thief     +1 str, +2 Dex
                        //Cleric    +1 con, +2Wis

                        if (classChoice == "1")
                        {
                            player = new Player(charName, 1, 0, 14, 20, 20, str + 1, dex + 1, con + 1, intel,
                                wis, cha, charRace, charClass, rand.Next(20, 501), s1, null, noItem, noItem);
                            charCreated = true;
                        }
                        else if (classChoice == "2")
                        {
                            player = new Player(charName, 1, 0, 10, 8, 8, str + 1, dex, con, intel + 2,
                                wis, cha, charRace, charClass, rand.Next(20, 501), null, sp1, noItem, noItem);
                            charCreated = true;
                        }
                        else if (classChoice == "3")
                        {
                            player = new Player(charName, 1, 0, 15, 15, 15, str + 1, dex + 2, con, intel,
                                wis, cha, charRace, charClass, rand.Next(20, 501), d1, null, noItem, noItem);
                            charCreated = true;
                        }
                        else if (classChoice == "4")
                        {
                            player = new Player(charName, 1, 0, 12, 12, 12, str, dex, con + 1, intel,
                                wis + 2, cha, charRace, charClass, rand.Next(20, 501), m1, null, noItem, noItem);
                            charCreated = true;
                        }

                        //Console.WriteLine(player); //throw in to test player is made
                    } while (reroll);
                }
                #endregion

                do //do loop that controls town
                {

                    if (media.SoundLocation != sndTown)
                    {
                        media.Stop();
                        media.SoundLocation = sndTown;
                        media.PlayLooping();
                    }
                    else
                    {
                        media.PlayLooping();
                    }
                    Console.Clear();
                    HUD.InstallHUD(player);
                    Centered.Section(TownDescription);

                    Centered.Section(menu);
                    Centered.Line(yourChoice);
                    //Console.WriteLine(player.Level);
                    //Console.WriteLine(player.Exp);  //test to make sure Exp is assigned
                    //Console.WriteLine(player.MaxExp); //test to make sure MaxExp is set
                    string userChoice = Console.ReadLine().ToUpper();
                    //userChoice = userChoice.Substring(0, 1);

                    //TODO Clear console after the input
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "G":
                            leaveShop = false;
                            #region Go To Shop
                            do
                            {
                                Console.Clear();
                                HUD.InstallHUD(player);
                                Centered.Section(shopDescrip);
                                Centered.Section(shopMenu);
                                Console.WriteLine("\n");
                                Console.Write("                     " + yourChoice);
                                string shopChoice = Console.ReadLine().ToUpper();

                                switch (shopChoice)
                                {
                                    case "W":
                                        weapShopping = true;
                                        if (player.CharacterClass == Class.Wizard)
                                        {
                                            do
                                            {
                                                Console.Clear();
                                                HUD.InstallHUD(player);
                                                Console.WriteLine("\n\n");
                                                Centered.LineReturn(sp1.Name + "    300gp");
                                                Centered.LineReturn(sp2.Name + "    600gp");
                                                Centered.LineReturn(sp3.Name + "   1000gp");
                                                Centered.LineReturn(sp4.Name + "   1400gp");
                                                Centered.LineReturn(sp5.Name + "   2000gp");
                                                Console.WriteLine("\n\n");
                                                Centered.Section(buyMenu);
                                                Centered.Line(yourChoice);
                                                string wizChoice = Console.ReadLine();
                                                switch (wizChoice)
                                                {
                                                    case "1":
                                                        if (player.EquippedSpell.SpellID >= 2)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 300)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newSpell);
                                                            player.EquippedSpell = sp2;
                                                            player.Gold -= 300;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "2":
                                                        if (player.EquippedSpell.SpellID >= sp3.SpellID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 600)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newSpell);
                                                            player.EquippedSpell = sp3;
                                                            player.Gold -= 600;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "3":
                                                        if (player.EquippedSpell.SpellID >= sp4.SpellID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newSpell);
                                                            player.EquippedSpell = sp4;
                                                            player.Gold -= 1000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "4":
                                                        if (player.EquippedSpell.SpellID >= sp5.SpellID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1400)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newSpell);
                                                            player.EquippedSpell = sp5;
                                                            player.Gold -= 1400;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "5":
                                                        if (player.EquippedSpell.SpellID >= sp6.SpellID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 2000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newSpell);
                                                            player.EquippedSpell = sp6;
                                                            player.Gold -= 2000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "R":
                                                    case "r":
                                                        weapShopping = false;
                                                        break;
                                                    default:
                                                        Centered.LineReturn(invalidEntry);
                                                        break;
                                                }

                                            } while (weapShopping);
                                        }
                                        else if (player.CharacterClass == Class.Warrior)
                                        {
                                            do
                                            {
                                                Console.Clear();
                                                HUD.InstallHUD(player);
                                                Console.WriteLine("\n\n");
                                                Centered.LineReturn(s2.Name + "    300gp");
                                                Centered.LineReturn(s3.Name + "    600gp");
                                                Centered.LineReturn(s4.Name + "   1000gp");
                                                Centered.LineReturn(s5.Name + "   1400gp");
                                                Centered.LineReturn(s6.Name + "   2000gp");
                                                Console.WriteLine("\n\n");
                                                Centered.Section(buyMenu);
                                                Centered.Line(yourChoice);
                                                string warChoice = Console.ReadLine();
                                                switch (warChoice)
                                                {
                                                    case "1":
                                                        if (player.EquippedWeapon.WeapID >= s2.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 300)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = s2;
                                                            player.Gold -= 300;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "2":
                                                        if (player.EquippedWeapon.WeapID >= s3.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 600)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = s3;
                                                            player.Gold -= 600;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "3":
                                                        if (player.EquippedWeapon.WeapID >= s4.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = s4;
                                                            player.Gold -= 1000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "4":
                                                        if (player.EquippedWeapon.WeapID >= s5.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1400)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = s5;
                                                            player.Gold -= 1400;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "5":
                                                        if (player.EquippedWeapon.WeapID >= s6.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 2000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = s6;
                                                            player.Gold -= 2000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "R":
                                                    case "r":
                                                        weapShopping = false;
                                                        break;
                                                    default:
                                                        Centered.LineReturn(invalidEntry);
                                                        break;
                                                }

                                            } while (weapShopping);

                                        }
                                        else if (player.CharacterClass == Class.Theif)
                                        {
                                            do
                                            {
                                                Console.Clear();
                                                HUD.InstallHUD(player);
                                                Console.WriteLine("\n\n");
                                                Centered.LineReturn(d2.Name + "    300gp");
                                                Centered.LineReturn(d3.Name + "    600gp");
                                                Centered.LineReturn(d4.Name + "   1000gp");
                                                Centered.LineReturn(d5.Name + "   1400gp");
                                                Centered.LineReturn(d6.Name + "   2000gp");
                                                Console.WriteLine("\n\n");
                                                Centered.Section(buyMenu);
                                                Centered.Line(yourChoice);
                                                string thiefChoice = Console.ReadLine();
                                                switch (thiefChoice)
                                                {
                                                    case "1":
                                                        if (player.EquippedWeapon.WeapID >= d2.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 300)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = d2;
                                                            player.Gold -= 300;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "2":
                                                        if (player.EquippedWeapon.WeapID >= d3.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 600)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = d3;
                                                            player.Gold -= 600;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "3":
                                                        if (player.EquippedWeapon.WeapID >= d4.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = d4;
                                                            player.Gold -= 1000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "4":
                                                        if (player.EquippedWeapon.WeapID >= d5.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1400)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = d5;
                                                            player.Gold -= 1400;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "5":
                                                        if (player.EquippedWeapon.WeapID >= d6.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 2000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = d6;
                                                            player.Gold -= 2000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "R":
                                                    case "r":
                                                        weapShopping = false;
                                                        break;
                                                    default:
                                                        Centered.LineReturn(invalidEntry);
                                                        break;
                                                }

                                            } while (weapShopping);
                                        }
                                        else if (player.CharacterClass == Class.Cleric)
                                        {
                                            do
                                            {
                                                Console.Clear();
                                                HUD.InstallHUD(player);
                                                Console.WriteLine("\n\n");
                                                Centered.LineReturn(m2.Name + "    300gp");
                                                Centered.LineReturn(m3.Name + "    600gp");
                                                Centered.LineReturn(m4.Name + "   1000gp");
                                                Centered.LineReturn(m5.Name + "   1400gp");
                                                Centered.LineReturn(m6.Name + "   2000gp");
                                                Console.WriteLine("\n\n");
                                                Centered.Section(buyMenu);
                                                Centered.Line(yourChoice);
                                                string clrChoice = Console.ReadLine();
                                                switch (clrChoice)
                                                {
                                                    case "1":
                                                        if (player.EquippedWeapon.WeapID >= m2.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 300)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = m2;
                                                            player.Gold -= 300;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "2":
                                                        if (player.EquippedWeapon.WeapID >= m3.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 600)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = m3;
                                                            player.Gold -= 600;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "3":
                                                        if (player.EquippedWeapon.WeapID >= m4.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = m4;
                                                            player.Gold -= 1000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "4":
                                                        if (player.EquippedWeapon.WeapID >= m5.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 1400)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = m5;
                                                            player.Gold -= 1400;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "5":
                                                        if (player.EquippedWeapon.WeapID >= m6.WeapID)
                                                        {
                                                            Centered.LineReturn(notUpgrade);
                                                            Console.ReadKey();
                                                        }
                                                        else if (player.Gold >= 2000)
                                                        {
                                                            Console.WriteLine("\n\n");
                                                            Centered.LineReturn(newWeapon);
                                                            player.EquippedWeapon = m6;
                                                            player.Gold -= 2000;
                                                            media.SoundLocation = sndBuyItem;
                                                            media.Play();
                                                            Console.ReadKey();
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn(notEnoughGold);
                                                            Console.ReadKey();
                                                        }
                                                        break;
                                                    case "R":
                                                    case "r":
                                                        weapShopping = false;
                                                        break;
                                                    default:
                                                        Centered.LineReturn(invalidEntry);
                                                        break;
                                                }

                                            } while (weapShopping);
                                        }


                                        break;
                                    case "I":
                                        itemShopping = true;
                                        do
                                        {
                                            Console.Clear();
                                            HUD.InstallHUD(player);
                                            Console.WriteLine("\n\n");
                                            Centered.LineReturn(pot1.Name + " - " + pot1.Description + "            150gp");
                                            Centered.LineReturn(pot2.Name + " - " + pot2.Description + "    300gp");
                                            Centered.LineReturn(pot3.Name + " - " + pot3.Description + "   800gp");
                                            Centered.LineReturn(scroll1.Name + " - " + scroll1.Description + "   200gp");
                                            Centered.LineReturn(wand1.Name + " - " + wand1.Description + "         1000gp");
                                            Console.WriteLine("\n\n");
                                            Centered.Section(buyMenu);
                                            Centered.Line(yourChoice);
                                            string itemChoice = Console.ReadLine();

                                            switch (itemChoice)
                                            {
                                                case "1":
                                                    if (player.Gold >= 150)
                                                    {
                                                        if (player.Slot1 == noItem)
                                                        {
                                                            player.Slot1 = pot1;
                                                            player.Gold -= 150;
                                                        }
                                                        else if (player.Slot2 == noItem)
                                                        {
                                                            player.Slot2 = pot1;
                                                            player.Gold -= 150;
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn("You have no free item slots.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Centered.LineReturn(notEnoughGold);
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "2":
                                                    if (player.Gold >= 300)
                                                    {
                                                        if (player.Slot1 == noItem)
                                                        {
                                                            player.Slot1 = pot2;
                                                            player.Gold -= 300;
                                                        }
                                                        else if (player.Slot2 == noItem)
                                                        {
                                                            player.Slot2 = pot2;
                                                            player.Gold -= 3000;
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn("You have no free item slots.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Centered.LineReturn(notEnoughGold);
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "3":
                                                    if (player.Gold >= 800)
                                                    {
                                                        if (player.Slot1 == noItem)
                                                        {
                                                            player.Slot1 = pot3;
                                                            player.Gold -= 800;
                                                        }
                                                        else if (player.Slot2 == noItem)
                                                        {
                                                            player.Slot2 = pot3;
                                                            player.Gold -= 800;
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn("You have no free item slots.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Centered.LineReturn(notEnoughGold);
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "4":
                                                    if (player.Gold >= 200)
                                                    {
                                                        if (player.Slot1 == noItem)
                                                        {
                                                            player.Slot1 = scroll1;
                                                            player.Gold -= 200;
                                                        }
                                                        else if (player.Slot2 == noItem)
                                                        {
                                                            player.Slot2 = scroll1;
                                                            player.Gold -= 200;
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn("You have no free item slots.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Centered.LineReturn(notEnoughGold);
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "5":
                                                    if (player.Gold >= 1000)
                                                    {
                                                        if (player.Slot1 == noItem)
                                                        {
                                                            player.Slot1 = wand1;
                                                            player.Gold -= 1000;
                                                        }
                                                        else if (player.Slot2 == noItem)
                                                        {
                                                            player.Slot2 = wand1;
                                                            player.Gold -= 1000;
                                                        }
                                                        else
                                                        {
                                                            Centered.LineReturn("You have no free item slots.");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Centered.LineReturn(notEnoughGold);
                                                        Console.ReadKey();
                                                    }
                                                    break;
                                                case "R":
                                                case "r":
                                                    itemShopping = false;
                                                    break;
                                                default:
                                                    Centered.LineReturn(invalidEntry);
                                                    break;
                                            }
                                        } while (itemShopping);

                                        break;
                                    case "R":
                                        leaveShop = true;
                                        break;
                                    case "X":
                                    case "E":
                                        Console.WriteLine();
                                        Centered.LineReturn("No one likes a quitter....");
                                        Console.WriteLine("\n\n\n");
                                        GameOver.Exit();
                                        exit = true;
                                        break;
                                    default:
                                        Centered.LineReturn(invalidEntry);
                                        break;
                                }
                            } while (!exit && !leaveShop);
                            #endregion
                            break;
                        case "V":

                            leaveTemp = false;
                            #region Go To Temple
                            do
                            {
                                if (media.SoundLocation != sndTemple)
                                {
                                    media.Stop();
                                    media.SoundLocation = sndTemple;
                                    media.PlayLooping();
                                }
                                //else
                                //{
                                //    media.PlayLooping();
                                //}
                                Console.Clear();
                                HUD.InstallHUD(player);
                                Centered.Section(templeDescrip);
                                Centered.Section(templeMenu);
                                Console.WriteLine("\n");
                                Console.Write("                     " + yourChoice);
                                string tempChoice = Console.ReadLine().ToUpper();

                                switch (tempChoice)
                                {
                                    case "H":
                                        if (player.Gold >= 150)
                                        {

                                            Console.WriteLine("\n\n");
                                            Centered.LineReturn(halfHeal);
                                            player.Life += (player.MaxLife / 2);
                                            player.Gold -= 150;
                                            media.SoundLocation = sndHeal;
                                            media.Play();


                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\n");
                                            Centered.LineReturn(notEnoughGold);
                                            Console.ReadKey();
                                        }
                                        break;
                                    case "F":
                                        if (player.Gold >= 300)
                                        {
                                            Console.WriteLine("\n\n");
                                            Centered.LineReturn(fullHeal);
                                            player.Life = player.MaxLife;
                                            player.Gold -= 300;
                                            media.SoundLocation = sndHeal;
                                            media.Play();
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\n");
                                            Centered.LineReturn(notEnoughGold);
                                            Console.ReadKey();
                                        }
                                        break;
                                    case "R":
                                        leaveTemp = true;
                                        break;
                                    case "X":
                                    case "E":
                                        Console.WriteLine();
                                        Centered.LineReturn("No one likes a quitter....");
                                        Console.WriteLine("\n\n\n");
                                        GameOver.Exit();
                                        exit = true;
                                        break;
                                    default:
                                        Centered.LineReturn(invalidEntry);
                                        break;
                                }
                            } while (!exit && !leaveTemp);
                            #endregion
                            break;
                        case "T":
                            leaveInn = false;
                            #region Go To Inn
                            do
                            {
                                if (media.SoundLocation != sndInn)
                                {
                                    media.Stop();
                                    media.SoundLocation = sndInn;
                                    media.PlayLooping();
                                }
                                //else
                                //{
                                //    media.PlayLooping();
                                //}
                                Random healRand = new Random();
                                Console.Clear();
                                HUD.InstallHUD(player);
                                Centered.Section(innDescrip);
                                Centered.Section(innMenu);
                                Console.WriteLine("\n");
                                Console.Write("                     " + yourChoice);
                                string innChoice = Console.ReadLine().ToUpper();

                                switch (innChoice)
                                {
                                    case "G":
                                        if (player.Gold >= 15)
                                        {
                                            Console.WriteLine("\n\n");
                                            Centered.Section(sleptNight);
                                            player.Life += healRand.Next(1, 6);
                                            player.Gold -= 15;
                                            media.SoundLocation = sndBuyItem;
                                            media.Play();
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\n");
                                            Centered.LineReturn(notEnoughGold);
                                            Console.ReadKey();
                                        }
                                        break;
                                    case "R":
                                        leaveInn = true;
                                        break;
                                    case "X":
                                    case "E":
                                        Console.WriteLine();
                                        Centered.LineReturn("No one likes a quitter....");
                                        Console.WriteLine("\n\n\n");
                                        GameOver.Exit();
                                        exit = true;
                                        break;
                                    default:
                                        Centered.LineReturn(invalidEntry);
                                        break;
                                }
                            } while (!exit && !leaveInn);

                            #endregion
                            break;
                        case "A":
                            HUD.InstallHUD(player);
                            Centered.Section(advTime);
                            Centered.Line(yourChoice);
                            string choice = Console.ReadLine().ToUpper();
                            choice = choice.Substring(0, 1);
                            switch (choice)
                            {
                                case "Y":

                                    #region Go To Dungeon
                                    do
                                    {
                                        reload = false;
                                        newRoom = false;
                                        string[] room = Rooms.GetRoom();

                                        #region Scaling & Monster Spawn
                                        Zombie z1 = new Zombie((player.AC - 10), (player.MaxLife - 10), (player.MaxLife - 10), (player.Str - 4), (player.Dex - 4),
                                           (player.Con - 4), 1, 6, 20, rand.Next(1, 61));
                                        Goblin gob1 = new Goblin((player.AC - 10), (player.MaxLife - 5), (player.MaxLife - 5), (player.Str - 4), (player.Dex - 4),
                                            (player.Con - 4), 1, 6, 35, rand.Next(1, 101));
                                        Skeleton skel1 = new Skeleton((player.AC - 10), (player.MaxLife - 10), (player.MaxLife - 10), (player.Str - 4), (player.Dex - 4),
                                            (player.Con - 4), 1, 6, 20, rand.Next(1, 61));
                                        Pixie pix1 = new Pixie((player.AC - 8), (player.MaxLife - 10), (player.MaxLife - 10), (player.Str - 4), (player.Dex - 4),
                                            (player.Con - 4), 1, 6, 20, rand.Next(1, 61));
                                        Specter spec1 = new Specter((player.AC - 8), (player.MaxLife - 5), (player.MaxLife - 5), (player.Str - 4), (player.Dex - 4),
                                            (player.Con - 4), 1, 6, 20, rand.Next(1, 81));

                                        NonPlayer[] monsters2 =
                                                    {
                                                       z1, gob1, skel1, pix1, spec1,
                                                       z1, gob1, skel1, pix1, spec1
                                                    };
                                        Zombie z2 = new Zombie((player.AC - 7), (player.MaxLife - 5), (player.MaxLife - 5), (player.Str - 3), (player.Dex - 3),
                                          (player.Con - 4), 1, 6, 50, rand.Next(1, 61));
                                        Goblin gob2 = new Goblin((player.AC - 6), (player.MaxLife), (player.MaxLife), (player.Str - 2), (player.Dex - 2),
                                            (player.Con - 4), 1, 6, 85, rand.Next(1, 101));
                                        Skeleton skel2 = new Skeleton((player.AC - 6), (player.MaxLife - 5), (player.MaxLife - 5), (player.Str - 2), (player.Dex - 4),
                                            (player.Con - 6), 1, 6, 65, rand.Next(1, 61));
                                        Pixie pix2 = new Pixie((player.AC - 3), (player.MaxLife - 5), (player.MaxLife - 5), (player.Str - 3), (player.Dex - 1),
                                            (player.Con - 6), 1, 6, 45, rand.Next(1, 61));
                                        Specter spec2 = new Specter((player.AC - 4), (player.MaxLife), (player.MaxLife), (player.Str - 4), (player.Dex - 4),
                                            (player.Con - 6), 1, 6, 55, rand.Next(1, 81));

                                        NonPlayer[] monsters4 =
                                                    {
                                                       z2, gob2, skel2, pix2, spec2,
                                                       z2, gob2, skel2, pix2, spec2
                                                    };
                                        Zombie z3 = new Zombie((player.AC - 5), (player.MaxLife + 15), (player.MaxLife + 15), (player.Str - 1), (player.Dex - 1),
                                          (player.Con - 3), 1, 6, 185, rand.Next(1, 91));
                                        Goblin gob3 = new Goblin((player.AC - 3), (player.MaxLife + 25), (player.MaxLife + 25), (player.Str), (player.Dex - 1),
                                            (player.Con - 2), 1, 6, 255, rand.Next(1, 151));
                                        Skeleton skel3 = new Skeleton((player.AC - 4), (player.MaxLife + 15), (player.MaxLife + 15), (player.Str), (player.Dex - 3),
                                            (player.Con - 3), 1, 6, 220, rand.Next(1, 101));
                                        Pixie pix3 = new Pixie((player.AC - 4), (player.MaxLife + 15), (player.MaxLife + 15), (player.Str - 2), (player.Dex),
                                            (player.Con - 2), 1, 6, 175, rand.Next(1, 101));
                                        Specter spec3 = new Specter((player.AC - 2), (player.MaxLife + 15), (player.MaxLife + 15), (player.Str - 2), (player.Dex - 2),
                                            (player.Con - 2), 1, 6, 190, rand.Next(1, 151));

                                        NonPlayer[] monsters6 =
                                                    {
                                                       z3, gob3, skel3, pix3, spec3,
                                                       z3, gob3, skel3, pix3, spec3
                                                    };
                                        Zombie z4 = new Zombie((player.AC - 3), (player.MaxLife + 25), (player.MaxLife + 25), (player.Str), (player.Dex),
                                          (player.Con - 1), 1, 6, 420, rand.Next(1, 131));
                                        Goblin gob4 = new Goblin((player.AC - 2), (player.MaxLife + 35), (player.MaxLife + 35), (player.Str + 1), (player.Dex),
                                            (player.Con - 1), 1, 6, 635, rand.Next(1, 151));
                                        Skeleton skel4 = new Skeleton((player.AC - 2), (player.MaxLife + 25), (player.MaxLife + 25), (player.Str + 2), (player.Dex - 1),
                                            (player.Con - 2), 1, 6, 535, rand.Next(1, 161));
                                        Pixie pix4 = new Pixie((player.AC - 2), (player.MaxLife + 20), (player.MaxLife + 20), (player.Str - 1), (player.Dex + 1),
                                            (player.Con - 1), 1, 6, 390, rand.Next(1, 161));
                                        Specter spec4 = new Specter((player.AC - 1), (player.MaxLife + 20), (player.MaxLife + 20), (player.Str - 1), (player.Dex - 1),
                                            (player.Con - 1), 1, 6, 440, rand.Next(1, 181));

                                        NonPlayer[] monsters8 =
                                                    {
                                                       z4, gob4, skel4, pix4, spec4,
                                                       z4, gob4, skel4, pix4, spec4
                                                    };
                                        Zombie z5 = new Zombie((player.AC - 1), (player.MaxLife + 40), (player.MaxLife + 40), (player.Str + 2), (player.Dex + 2),
                                          (player.Con), 1, 6, 1020, rand.Next(1, 161));
                                        Goblin gob5 = new Goblin((player.AC), (player.MaxLife + 50), (player.MaxLife + 50), (player.Str + 2), (player.Dex + 1),
                                            (player.Con), 1, 6, 1335, rand.Next(1, 171));
                                        Skeleton skel5 = new Skeleton((player.AC - 1), (player.MaxLife + 35), (player.MaxLife + 35), (player.Str + 3), (player.Dex),
                                            (player.Con - 1), 1, 6, 1220, rand.Next(1, 61));
                                        Pixie pix5 = new Pixie((player.AC - 1), (player.MaxLife + 25), (player.MaxLife + 25), (player.Str), (player.Dex + 2),
                                            (player.Con), 1, 6, 1120, rand.Next(1, 91));
                                        Specter spec5 = new Specter((player.AC - 1), (player.MaxLife + 35), (player.MaxLife + 35), (player.Str), (player.Dex),
                                            (player.Con), 1, 6, 1250, rand.Next(1, 81));

                                        NonPlayer[] monsters10 =
                                                    {
                                                       z5, gob5, skel5, pix5, spec5,
                                                       z5, gob5, skel5, pix5, spec5
                                                    };
                                        Demon demon1 = new Demon();
                                        Demon demon2 = new Demon(16, 110, 110, (player.Str - 1), (player.Dex - 1), (player.Con - 1), 2, 8, 250,
                                            rand.Next(20, 121));
                                        Demon demon3 = new Demon(17, 160, 160, (player.Str), (player.Dex), (player.Con), 2, 8, 250,
                                            rand.Next(20, 121));
                                        Demon demon4 = new Demon(18, 190, 190, (player.Str + 1), (player.Dex + 1), (player.Con + 1), 2, 8, 250,
                                            rand.Next(20, 121));
                                        Demon demon5 = new Demon(19, 210, 210, (player.Str + 2), (player.Dex + 2), (player.Con + 2), 2, 8, 250,
                                            rand.Next(20, 121));




                                        Random rand1 = new Random();
                                        NonPlayer monster = new NonPlayer();
                                        NonPlayer demon = new NonPlayer();

                                        if (player.Level <= 2)
                                        {
                                            int randNum = rand1.Next(monsters2.Length);
                                            monster = monsters2[randNum];
                                        }
                                        else if (player.Level <= 4 && player.Level > 2)
                                        {
                                            int randNum = rand1.Next(monsters4.Length);
                                            monster = monsters4[randNum];
                                        }
                                        else if (player.Level <= 6 && player.Level > 4)
                                        {
                                            int randNum = rand1.Next(monsters6.Length);
                                            monster = monsters6[randNum];
                                        }
                                        else if (player.Level <= 8 && player.Level > 6)
                                        {
                                            int randNum = rand1.Next(monsters8.Length);
                                            monster = monsters8[randNum];
                                        }
                                        else
                                        {
                                            int randNum = rand1.Next(monsters10.Length);
                                            monster = monsters10[randNum];
                                        }










                                        #endregion
                                        //randomly select a monster from array

                                        if (player.Life <= 0)
                                        {
                                            reload = false;
                                            break;
                                        }


                                        Console.Clear();
                                        //HUD.InstallHUD(player, monster);
                                        //Console.WriteLine("\n\n");
                                        //Centered.Section(Rooms.GetRoom());
                                        //Console.WriteLine();
                                        //Centered.LineReturn("In this room..." + monster.Name);
                                        if (bossCount == 10)
                                        {
                                            Console.Clear();
                                            BossFight.Fight();
                                            Console.ReadKey();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Clear();
                                        }

                                        do
                                        {
                                            if (bossCount == 10)
                                            {

                                                if (player.Level <= 2)
                                                {
                                                    demon = demon1;
                                                }
                                                else if (player.Level <= 4 && player.Level > 2)
                                                {
                                                    demon = demon2;
                                                }
                                                else if (player.Level <= 6 && player.Level > 4)
                                                {
                                                    demon = demon3;
                                                }
                                                else if (player.Level <= 8 && player.Level > 6)
                                                {
                                                    demon = demon4;
                                                }
                                                else
                                                {
                                                    demon = demon5;
                                                }

                                                HUD.InstallHUD(player, demon1);
                                                Console.WriteLine("\n\n");
                                                Centered.Section(room);
                                                Console.WriteLine();
                                                Centered.LineReturn("In this room..." + demon1.Name);
                                                media.SoundLocation = demon1.IdleSound;
                                                media.Play();
                                                Centered.Section(dungeonMenu);
                                                Centered.Line(yourChoice);
                                            }
                                            else
                                            {

                                                HUD.InstallHUD(player, monster);
                                                Console.WriteLine("\n\n");
                                                Centered.Section(room);
                                                Console.WriteLine();
                                                Centered.LineReturn("In this room..." + monster.Name);
                                                media.SoundLocation = monster.IdleSound;
                                                media.Play();
                                                Centered.Section(dungeonMenu);
                                                Centered.Line(yourChoice);
                                            }
                                            string choice2 = Console.ReadLine().ToUpper();
                                            
                                            Console.Clear();

                                            switch (choice2)
                                            {
                                                case "A":

                                                    if (media.SoundLocation != sndCombat)
                                                    {
                                                        media.Stop();
                                                        media.SoundLocation = sndCombat;
                                                        media.Play();
                                                    }


                                                    if (bossCount == 10)
                                                    {

                                                        Combat.DoBattle(player, demon);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        if (demon.Life <= 0)
                                                        {
                                                            //it's dead. You can have options for player to get items,
                                                            //search room....etc..

                                                            bossCount = 0;

                                                            player.Exp += demon.MonExp;
                                                            player.Gold += demon.MonGold;
                                                            media.Stop();
                                                            media.SoundLocation = demon.DieSound;
                                                            media.Play();
                                                            Console.WriteLine("\n\n\n\n\n                                 You have defeated {0}!!\n",
                                                                demon.Name);
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            newRoom = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Combat.DoBattle(player, monster);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        if (monster.Life <= 0)
                                                        {
                                                            //it's dead. You can have options for player to get items,
                                                            //search room....etc..
                                                            player.Exp += monster.MonExp;
                                                            player.Gold += monster.MonGold;
                                                            media.Stop();
                                                            media.SoundLocation = monster.DieSound;
                                                            media.Play();

                                                            bossCount++;

                                                            Console.WriteLine("\n\n\n\n\n                                 You have defeated {0}!!\n",
                                                                monster.Name);
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            newRoom = true;
                                                        }
                                                    }


                                                    break;
                                                case "F":

                                                    if (bossCount == 10)
                                                    {
                                                        Centered.LineReturn(flee);
                                                        Centered.LineReturn(flee2);
                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                        Console.ReadKey();
                                                        newRoom = true;
                                                        reload = true;//Returns to town
                                                    }
                                                    else
                                                    {
                                                        Centered.LineReturn(flee);
                                                        Centered.LineReturn(flee2);
                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                        Console.ReadKey();
                                                        newRoom = true;
                                                        reload = true;//Returns to town
                                                    }
                                                    break;
                                                case "U":
                                                    useItem = true;
                                                    do
                                                    {
                                                        string useItemDis2 = string.Format("║         Slot 1:   {0, -20} - {1,-22}           ║", player.Slot1.Name, player.Slot1.Description);
                                                        string useItemDis3 = string.Format("║         Slot 2:   {0, -20} - {1,-22}           ║", player.Slot2.Name, player.Slot2.Description);
                                                        Console.Clear();
                                                        HUD.InstallHUD(player, monster);
                                                        Console.WriteLine("\n\n");

                                                        Centered.Section(useItemDis1);
                                                        Centered.LineReturn(useItemDis2);
                                                        Centered.LineReturn(useItemDis3);
                                                        Centered.Section(useItemDis4);

                                                        Console.WriteLine("\n\n");
                                                        Centered.Section(useItemMenu);
                                                        string useItemChoice = Console.ReadLine();

                                                        switch (useItemChoice)
                                                        {
                                                            case "1":
                                                                if (player.Slot1.ItemID == 1)
                                                                {
                                                                    heal = rand.Next(1, 11);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You were healed for: " + heal);
                                                                    player.Life += heal;
                                                                    player.Slot1 = noItem;
                                                                    useItem = false;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else if (player.Slot1.ItemID == 2)
                                                                {
                                                                    heal = rand.Next(5, 21);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You were healed for: " + heal);
                                                                    player.Life += heal;
                                                                    player.Slot1 = noItem;
                                                                    useItem = false;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else if (player.Slot1.ItemID == 3)
                                                                {
                                                                    heal = rand.Next(9, 41);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You were healed for: " + heal);
                                                                    player.Life += heal;
                                                                    player.Slot1 = noItem;
                                                                    useItem = false;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else if (player.Slot1.ItemID == 4)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You read the scroll and a portal opens back to town!");
                                                                    Console.ReadKey();
                                                                    player.Slot1 = noItem;
                                                                    useItem = false;
                                                                    reload = true;
                                                                }
                                                                else if (player.Slot1.ItemID == 5)
                                                                {
                                                                    missileDam = rand.Next(13, 49);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("Your wand fires a dozen missiles at your foe.");
                                                                    player.Slot1 = noItem;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Centered.LineReturn(demon.Name + " was hit for " + missileDam + " !!");
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Centered.LineReturn(monster.Name + " was hit for " + missileDam + " !!");
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    useItem = false;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else
                                                                    Centered.LineReturn("That slot is empty....");
                                                                break;
                                                            case "2":
                                                                if (player.Slot2.ItemID == 1)
                                                                {
                                                                    heal = rand.Next(1, 11);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You were healed for: " + heal);
                                                                    player.Life += heal;
                                                                    player.Slot2 = noItem;
                                                                    useItem = false;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else if (player.Slot2.ItemID == 2)
                                                                {
                                                                    heal = rand.Next(5, 21);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You were healed for: " + heal);
                                                                    player.Life += heal;
                                                                    player.Slot2 = noItem;
                                                                    useItem = false;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else if (player.Slot2.ItemID == 3)
                                                                {
                                                                    heal = rand.Next(9, 41);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You were healed for: " + heal);
                                                                    player.Life += heal;
                                                                    player.Slot2 = noItem;
                                                                    useItem = false;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else if (player.Slot2.ItemID == 4)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("You read the scroll and a portal opens back to town!");
                                                                    Console.ReadKey();
                                                                    player.Slot2 = noItem;
                                                                    useItem = false;
                                                                    reload = true;
                                                                }
                                                                else if (player.Slot2.ItemID == 5)
                                                                {
                                                                    missileDam = rand.Next(13, 49);
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Centered.LineReturn("Your wand fires a a dozen missiles at your foe.");
                                                                    player.Slot2 = noItem;
                                                                    if (bossCount == 10)
                                                                    {
                                                                        Centered.LineReturn(demon.Name + " was hit for " + missileDam + " !!");
                                                                        Combat.DoAttack(player, demon, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    else
                                                                    {
                                                                        Centered.LineReturn(monster.Name + " was hit for " + missileDam + " !!");
                                                                        Combat.DoAttack(player, monster, 2); //monster free attack
                                                                        Console.ReadKey();
                                                                    }
                                                                    useItem = false;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                                else
                                                                    Centered.LineReturn("That slot is empty....");

                                                                break;
                                                            case "R":
                                                            case "r":
                                                                useItem = false;
                                                                break;
                                                            case "X":
                                                            case "E":
                                                                Console.WriteLine();
                                                                Centered.LineReturn("No one likes a quitter....");
                                                                Console.WriteLine("\n\n\n");
                                                                GameOver.Exit();
                                                                exit = true;
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                    } while (useItem);

                                                    break;
                                                case "I":
                                                    useInv = true;
                                                    do
                                                    {
                                                        string itemDis2 = string.Format("║         Slot 1:   {0, -20} - {1,-20}             ║", player.Slot1.Name, player.Slot1.Description);
                                                        string itemDis3 = string.Format("║         Slot 2:   {0, -20} - {1,-20}             ║", player.Slot2.Name, player.Slot2.Description);
                                                        Console.Clear();
                                                        HUD.InstallHUD(player, monster);
                                                        Console.WriteLine("\n\n");
                                                        Centered.Section(useItemDis1);
                                                        Centered.LineReturn(itemDis2);
                                                        Centered.LineReturn(itemDis3);
                                                        Centered.Section(useItemDis4);

                                                        Console.WriteLine("\n\n");
                                                        Centered.Section(invMenu);
                                                        string invChoice = Console.ReadLine().ToUpper();

                                                        switch (invChoice)
                                                        {
                                                            case "R":
                                                                useInv = false;
                                                                Console.Clear();
                                                                break;
                                                            case "E":
                                                            case "X":
                                                                Console.WriteLine();
                                                                Centered.LineReturn("No one likes a quitter....");
                                                                Console.WriteLine("\n\n\n");
                                                                GameOver.Exit();

                                                                exit = true;
                                                                break;
                                                            default:
                                                                break;
                                                        }

                                                    } while (useInv);
                                                    break;
                                                case "X":
                                                case "E":
                                                    Console.WriteLine();
                                                    Centered.LineReturn("No one likes a quitter....");
                                                    Console.WriteLine("\n\n\n");
                                                    GameOver.Exit();

                                                    exit = true;
                                                    break;
                                                default:
                                                    Console.WriteLine("That's not one of the choices, there bud. Try again.");
                                                    break;
                                            }//end switch

                                            if (player.Life <= 0)
                                            {

                                                media.Stop();
                                                media.SoundLocation = sndDeath;
                                                media.Play();
                                                GameOver.Exit();
                                                Centered.LineReturn(death);
                                                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xfr64zoBTAQ");
                                                leaveTown = true;
                                                exit = true;
                                            }//end if player is dead



                                            //if (monster.Life <= 0)
                                            //{
                                            //    player.Exp += monster.MonExp;
                                            //    player.Gold += monster.MonGold;
                                            //    media.Stop();
                                            //    media.SoundLocation = monster.DieSound;
                                            //    media.Play();
                                            //}
                                            //else if (demon1.Life <= 0)
                                            //{
                                            //    player.Exp += demon1.MonExp;
                                            //    player.Gold += demon1.MonGold;
                                            //    media.Stop();
                                            //    media.SoundLocation = demon1.DieSound;
                                            //    media.Play();
                                            //}

                                        } while (!exit && !newRoom);

                                        //if (monster.Life <= 0)
                                        //{
                                        //    player.Exp += monster.MonExp;
                                        //    player.Gold += monster.MonGold;
                                        //    media.Stop();
                                        //    media.SoundLocation = monster.DieSound;
                                        //    media.Play();
                                        //}
                                        //else if (demon1.Life <= 0)
                                        //{
                                        //    player.Exp += demon1.MonExp;
                                        //    player.Gold += demon1.MonGold;
                                        //    media.Stop();
                                        //    media.SoundLocation = demon1.DieSound;
                                        //    media.Play();
                                        //}


                                    } while (!exit && !reload);
                                    break;
                                    #endregion
                                case "N":

                                    break;
                                default:
                                    Centered.Line(invalidEntry);
                                    break;

                            }
                            break;
                        case "I":
                            
                            #region Inventory
                            useInv = true;
                            do
                            {
                                string itemDis2 = string.Format("║         Slot 1:   {0, -20} - {1,-20}             ║", player.Slot1.Name, player.Slot1.Description);
                                string itemDis3 = string.Format("║         Slot 2:   {0, -20} - {1,-20}             ║", player.Slot2.Name, player.Slot2.Description);
                                Console.Clear();
                                HUD.InstallHUD(player);
                                Console.WriteLine("\n\n");
                                Centered.Section(useItemDis1);
                                Centered.LineReturn(itemDis2);
                                Centered.LineReturn(itemDis3);
                                Centered.Section(useItemDis4);

                                Console.WriteLine("\n\n");
                                Centered.Section(invMenu);
                                string invChoice = Console.ReadLine().ToUpper();

                                switch (invChoice)
                                {
                                    case "R":
                                        useInv = false;
                                        Console.Clear();
                                        break;
                                    case "E":
                                    case "X":
                                        Console.WriteLine();
                                        Centered.LineReturn("No one likes a quitter....");
                                        Console.WriteLine("\n\n\n");
                                        GameOver.Exit();

                                        exit = true;
                                        break;
                                    default:
                                        break;
                                }
                            } while (useInv);

                            #endregion
                            break;
                        case "S":
                            #region Save Game
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n\n\n");
                            Centered.LineReturn("Only one game may be saved at a time. If there is one already");
                            Centered.LineReturn("saved you will overwrite it by saving this one. Would you like");
                            Centered.Line("to save your game? Y/N  :      ");
                            string saveChoice = Console.ReadLine().ToUpper();
                            //saveChoice = saveChoice.Substring(0, 1);
                            switch (saveChoice)
                            {
                                case "Y":
                                    System.IO.File.WriteAllText(saveChar, player.ToString());
                                    System.IO.File.WriteAllText(saveItems, player.ItemsList());


                                    Stream TestFileStream = File.Create(saveBin);
                                    BinaryFormatter serializer = new BinaryFormatter();
                                    serializer.Serialize(TestFileStream, player);
                                    TestFileStream.Close();
                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\n\n\n");
                                    Centered.LineReturn("Your progress has been saved.");
                                    Console.ReadKey();
                                    break;
                                case "N":
                                    break;
                                default:
                                    Centered.LineReturn(invalidEntry);
                                    break;
                            }



                            #endregion
                            break;
                        case "X":
                        case "E":
                            Console.WriteLine();
                            Centered.LineReturn("No one likes a quitter....");
                            Console.WriteLine("\n\n\n");
                            GameOver.Exit();
                            exit = true;
                            break;
                        default:
                            Centered.Line(invalidEntry);
                            break;


                    }

                    //TODO Ultimate place to address the player's life

                    //if (player.Life <= 0)
                    //{
                    //    GameOver.Exit();
                    //    Centered.LineReturn(death);
                    //    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xfr64zoBTAQ");
                    //    leaveTown = true;
                    //    exit = true;
                    //}//end if player is dead


                } while (!exit && !leaveTown);




            } while (!exit);

            //add a Console.ReadKey() to make the program pause before closing
            Console.ReadKey();



        }//end main



    }
}
