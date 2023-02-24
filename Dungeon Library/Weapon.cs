using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
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
        private WeaponType _type;
        


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

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }


        //Constructors
        //1 fq ctor, and 1 unqualified ctor if you want Object Initialization Syntax



        public Weapon() { }

        public Weapon(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }
        //Methods
        //Nicely formatted ToString() override
        public override string ToString()
        {
            return $"{Name}\n\n" +
                $"Weapon Type: {Type}\n" +
                $"Max Damage: {MaxDamage}\n" +
                $"Min Damage: {MinDamage}\n" +
                $"Bonus Hit Chance: {BonusHitChance}%\n" +
                $"Two Handed Weapon: {IsTwoHanded}\n";
        }

        //Update the Weapon class to use the WeaponType enum
        //a. Add a field/property for Type with is of data type WeaponType
        //b. Add Type to the FQCTOR
        //c. Add Type to the ToString(

    }

    

}
