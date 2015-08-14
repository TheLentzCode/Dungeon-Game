using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    [Serializable()]
    public class Spells
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;

        public string savedSp { get; set; }
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

        public int SpellID { get; set; }

        public Spells() { }

        public Spells(int minDamage, int maxDamage, string name, int spellID)
        {
            //if you have any properties that have business rules that are based off any other
            //properties, set those properties first.
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            SpellID = spellID;
            
        }//end constructor

        //Methods
        public override string ToString()
        {
            return string.Format("Spell: {0}\t{1} to {2} Damage\n",
                Name,
                MinDamage,
                MaxDamage);
        }
    }//end Spell
}
