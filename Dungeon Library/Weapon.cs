using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    //Make it public!
    public class Weapon
    {
        //Fields
        /*
         * int for mix damage (cannot be less than 0 or > max)
         * int for max damage (cannot be less than 0) - assign first in your ctor
         * string for the name
         * int for bonusHitChance
         * bool isTwoHanded
         */
        private int _maxDamage;
        private int _minDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;


        //Props - 1 for each field
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }       
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        //Constructors
        //1 fq ctor, and 1 unqualified ctor if you want Object Initialization Syntax

        public Weapon() { }

        public Weapon(int MaxDamage, int MinDamage, string Name, int BonusHitChance, bool IsTwoHanded)
        {
            MaxDamage = _maxDamage;
            MinDamage = _minDamage;
            Name = _name;
            BonusHitChance = _bonusHitChance;
            IsTwoHanded = _isTwoHanded;
        }
        //Methods
        //Nicely formatted ToString() override
        public override string ToString()
        {
            return $"{Name}\n\n" +
                $"Max Damage: {MaxDamage}\n" +
                $"Min Damage: {MinDamage}\n" +
                $"Bonus Hit Chance: %{BonusHitChance}\n" +
                $"Two Handed Weapon: {IsTwoHanded}\n";

        }

    }
}
