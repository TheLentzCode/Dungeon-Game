# Dungeon-Game

C# console / text based Dungeon Game made while learning C#. The basic item given in class was to have a looping 
dungeon where it would change rooms each time a monster died, and give a new room description and monster. 
You could attack and flee basically. I added the following features:

-Created a Class that would resize the console window to a more fun size and center it on the screen.

-Created a class that centeres the text on the screen. This class has three methods to do this. One for a line
 with a line break (like WriteLine()), one without the carriage return (like Write()) and one that can handle
 an array of strings centering each line.
 
-Created a custom Heads Up Display. A box in the upper left shows up to date character info, while the box 
 in the upper right will show up to date monster info when there's a monster around. There is also an
 experience status bar in the middle of the screen, that updates when monsters are killed.
  
-You can save and load one game.

-There is a character creation at the beginning of the game. There are 4 classes, 4 races and stats to roll.
 If the user doesnt enter in a name, it will give them one. You can re-roll your stats as many times as 
 as possible for now.
 
 -Each player class has it's own special use. Warriors get bonus to str, dex and hit points.
  Wizard get bonus to Intellegence which is it's plus to dam stat and it's spell upgrades end up doing
  massive damage. The theif has a chance to backstab for x3 damage! The war-priest has a chance to
  heal himself with each hit and has bonuses to heal with higher Wisdom.
 
-Coded in some basic character stat rules and combat rules, based off of a certain table top rpg

-Added background music that change depending where you go.

-Added sounds to the monsters

-Created a handful of different monster types and one boss type. More to be added later. So have special abilities!

-Created custom weapon upgrades.

-Created a few single use type items. More to be made later.

-Add in a money system

-There is a town setting where you can do a few things. 
    -Go to the shop - You can buy weapon upgrades and single use items
    -Visit the Temple - You can heal for half of your total hitpoints or fully for a cost
    -Go to the dungeon
    -Save your game
    -Exit the Game
    
-Dugeon Play-
  -The monsters scale in difficulty depending on the player's stats and level. Things get harder!
  -You can view your items and use the single use ones in the dungeon.
  -Every 10 rooms a user clears....it's Boss Fight!
  
  More to come later! Scaling needs looked at, more monsters, more loot..
  
  If you would like to download a working copy of this that is already compiled
  <br />
  [Download](http://www.thelentzcode.com/files/DungeonQuest.zip)
