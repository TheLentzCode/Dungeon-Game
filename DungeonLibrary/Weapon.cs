using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    [Serializable()]
    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;

        public int WeapID { get; set; }
        public string savedWeap { get; set; }
        
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//end MaxDam

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//end BonusHitChance

        

        //Business rule for mindamage.
        //Cannot be more then maxdamage
        //cannot be less then 0

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }

        }

        public Weapon() { }

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance)
        {
            //if you have any properties that have business rules that are based off any other
            //properties, set those properties first.
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            


        }//end constructor

        //Methods
        public override string ToString()
        {
            return string.Format("{0}\t{1}-{2} Damage + {3} Hit/Damage",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance);
        }
    }//end Weapon
}
