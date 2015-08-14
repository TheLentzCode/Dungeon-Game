using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace DungeonLibrary
{
    public class Combat
    {
        //this class will not have fields, properties or any custome ctors. 
        //it is just a warehouse for methods

        public static void DoAttack(Player player, NonPlayer monster, int first)
        {
            

            // get random num from 1-20 roll a 1d20
            Random rand = new Random();
            int diceRoll = rand.Next(21);
            SoundPlayer media = new SoundPlayer();
            string sndGetHit = @"..\..\gethit4m.wav";
            string sndSpellAttack = @"..\..\spell_5.wav";
            string sndSpellAttack2 = @"..\..\spelhit1.wav";
            string sndMiss = @"..\..\swing.wav";
            
            if(first == 1) //player first
             {
                if ((diceRoll + player.CalcHitChance()) > monster.CalcBlock())
                {
                //if attacker hit
                //calc damage
                int damageDealt = player.CalcDamage();

                //assign the damage Dealt
                monster.Life -= damageDealt;
                
                
                //write to the screen
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                             {0} hit {1} for {2} damage!",
                    player.Name,
                    monster.Name,
                    damageDealt);
                Console.ForegroundColor = ConsoleColor.Red;
                }//end if
                else
                {
                //attacker missed
                if(media.SoundLocation != System.AppDomain.CurrentDomain.BaseDirectory + sndMiss)
                {
                    media.SoundLocation = System.AppDomain.CurrentDomain.BaseDirectory + sndMiss;
                        media.Play();
                }
                else
                {
                    media.Play();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             {0} missed!",
                    player.Name);
                Console.ForegroundColor = ConsoleColor.Red;
                }//end else
 
            }//end First if
            else if (first == 2)
            {
                media.Stop();
                media.SoundLocation = System.AppDomain.CurrentDomain.BaseDirectory + monster.AtkSound;
                media.Play();
                if ((diceRoll + monster.CalcHitChance()) > player.CalcBlock())
                {
                //if attacker hit
                //calc damage
                int damageDealt = monster.CalcDamage();

                //assign the damage Dealt
                player.Life -= damageDealt;

                
                //write to the screen
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                             {0} hit {1} for {2} damage!",
                    monster.Name,
                    player.Name,
                    damageDealt);
                Console.ForegroundColor = ConsoleColor.Red;
                }//end if
                else
                {
                //attacker missed
                if(media.SoundLocation != System.AppDomain.CurrentDomain.BaseDirectory + sndMiss)
                {
                    media.SoundLocation = System.AppDomain.CurrentDomain.BaseDirectory + sndMiss;
                        media.Play();
                }
                else
                {
                    media.Play();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             {0} missed!",
                    monster.Name);
                Console.ForegroundColor = ConsoleColor.Red;
                };
            }


            
            

        }

        public static void DoBattle(Player player, NonPlayer monster)
        {
            string[] battle = {

                    "██████╗  █████╗ ████████╗████████╗██╗     ███████╗██╗",
                    "██╔══██╗██╔══██╗╚══██╔══╝╚══██╔══╝██║     ██╔════╝██║",
                    "██████╔╝███████║   ██║      ██║   ██║     █████╗  ██║",
                    "██╔══██╗██╔══██║   ██║      ██║   ██║     ██╔══╝  ╚═╝",
                    "██████╔╝██║  ██║   ██║      ██║   ███████╗███████╗██╗",
                    "╚═════╝ ╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚══════╝╚══════╝╚═╝"
                                                     
                              };

            SoundPlayer media = new SoundPlayer();

            Console.WriteLine("\n\n\n\n");
            Centered.Section(battle);
            Console.WriteLine("\n\n\n\n");


            //Player attacks first
            DoAttack(player, monster, 1);

            

            //monster attacks 2nd if they're alive
            if (monster.Life > 0)
            {
                DoAttack(player, monster, 2);
            }//end if

            
        }//end DoBattle



    }//end combat
}
