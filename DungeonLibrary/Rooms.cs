using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rooms
    {

        


        public static string[] GetRoom()
        {
            string[][] rooms = {

            new string[] {
                "Rounded green stones set in the floor form a snake's head " ,
                "that points in the direction of the doorway you stand in. " ,
                "The body of the snake flows back and toward the wall to go" ,
                "round about the room in ever smaller circles, creating a  " ,
                "spiral pattern on the floor. Similar green-stone snakes   " ,
                "wind along the walls, seemingly at random heights, and    " ,
                "heir long bodies make wave shapes.\n\n"
                },
            new string[]{
                "Unlike the flagstone common throughout the dungeon, this  " ,
                "room is walled and floored with black marble veined with  " ,
                "white. The ceiling is similarly marbled, but the thick    " ,
                "pillars that hold it up are white. A brown stain drips    " ,
                "down one side of a nearby pillar.\n\n"
                },
            new string[]{
                "Neither light nor darkvision can penetrate the gloom in   ",
                "this chamber. An unnatural shade fills it, and the room's ",
                "farthest reaches are barely visible. Near the room's center",
                "you can just barely perceive a lump about the size of a   ",
                "human lying on the floor. (It might be a dead body, a pile",
                "of rags, or a sleeping monster that can take advantage of ",
                "the room's darkness.)\n\n "

                },
            new string[]{
                "Several white marble busts that rest on white pillars dominate",
                "this room. Most appear to be male or female humans of middle ",
                "age, but one clearly bears small horns projecting from its " ,
                "forehead and another is spread across the floor in a thousand ",
                "pieces, leaving one pillar empty.\n\n"

                },
            new string[]{
                "When looking into this chamber, you're confronted by a thousand",
                "reflections of yourself looking back. Mirrored walls set at ",
                "different angles fill the room. A path seems to wind through ",
                "the mirrors, although you can't tell where it leads.\n\n"

                },
            new string[]{
                "Rusting spikes line the walls and ceiling of this chamber. The ",
                "dusty floor shows no sign that the walls move over it, but you ",
                "can see the skeleton of some humanoid impaled on some wall ",
                "spikes nearby.\n\n"
                
                },
            new string[]{
                "Dozens of dead, winged beings lie scattered about the floor, ",
                "each about the size of a cat. Their broken bodies are bat-like ",
                "and bug-like at the same time. Each had two sets of bat wings," ,
                "a long nose like a mosquito, and six legs, but many were split",
                "in half or had limbs or wings lopped off. Their forms are little",
                "more than dried husks now, and there's no sign of what killed " ,
                "them."

                }
                           }; //end array array

            Random rand = new Random();
            int indexNum = rand.Next(rooms.Length);
            string[] room = new string[rooms.Length];


            //Array.Copy(rooms[indexNum], room, rooms[indexNum].Length);


            //string room = rooms[indexNum];

            return rooms[indexNum];
        }//end GetRoom


    }
}
