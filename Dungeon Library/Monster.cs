using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Monsters : Character
    {
        //Fields
        private int _maxDamage;
        private int _minDamage;
        private string _description;
        private Monsters _monster;

        //Props
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value >= _minDamage && value <= _minDamage ? value : 20; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Monsters Monster
        {
            get { return _monster; }
            set { _monster = value; }
        }

        //Constructors/Ctors

        public Monsters(int MaxLife, string Name, int HitChance, int Block, int MaxDamage, int MinDamage, string Description, Monsters Monster)
            : base (MaxLife, Name, HitChance, Block)
        {
            MaxDamage = _maxDamage;
            MinDamage = _minDamage;
            Description = _description;
            Monster = _monster;
        }

        //Method
        public override string ToString()
        {
            return base.ToString() + $"MaxDamage: {MaxDamage}\n" +
                $"MinDamage: {MinDamage} \n" +
                $"Monster: {Monster}";
        }

        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(Monster.MinDamage, Monster.MaxDamage);
            //return the damage
            return damage;
        }
    }
}
