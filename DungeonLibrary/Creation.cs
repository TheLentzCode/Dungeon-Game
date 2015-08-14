using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Creation
    {
        

    public static void Menu()
        {
            //Random for dice roll
            Random rand = new Random();
            int threed6 = rand.Next(19);
            

            //Stat variable
            int str = threed6;
            int dex = threed6;
            int con = threed6;
            int intel = threed6;
            int wis = threed6;
            int cha = threed6;

            //Creation Stat Choosing
            string[] c1 = {
                    "Let's have a look at your stats. You may re-roll until you like.",
                     "+---------------------------------+",
                     "|    Character Ability Scores:    |",
                     "|                                 |"
                       };
            string c2 = string.Format("Strength:       {0} ", str);
            string c3 = string.Format("Dexterity:      {0} ", dex);
            string c4 = string.Format("Constitution:   {0} ", con);
            string c5 = string.Format("Intelligence:   {0} ", intel);
            string c6 = string.Format("Wisdom:         {0} ", wis);
            string c7 = string.Format("Charisma:       {0} ", cha);
            string[] c8 = {
                    "|                                 |",
                    "+---------------------------------+\n"
                      };

            Centered.Section(c1);
            Centered.LineReturn(c2);
            Centered.LineReturn(c3);
            Centered.LineReturn(c4);
            Centered.LineReturn(c5);
            Centered.LineReturn(c6);
            Centered.LineReturn(c7);
            Centered.Section(c8);
           
        }


    }//end creation
}
