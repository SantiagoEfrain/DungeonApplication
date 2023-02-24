using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

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
            set { _maxDamage = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 0; }
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

        public Monsters(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description)
            : base (maxLife, name, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
         
        }

        //Method
        public override string ToString()
        {

            return base.ToString() +
                $"MaxDamage: {MaxDamage}\n" +
                $"MinDamage: {MinDamage} \n";


        }

        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(MinDamage, MaxDamage + 1);
            //return the damage
            return damage;
        }
        public static Monsters GetMonster()
        {
            // Creat a variety of monsters
            Monsters m1 = new(name: "White rabbit", hitChance: 50, block: 20, maxLife: 25, maxDamage: 8, minDamage: 2, description: "Thats no ordinary rabbit! Look at the bones!");
            Monsters m2 = new(name: "Dracula",hitChance: 70,block: 8,maxLife: 30,maxDamage: 8,minDamage: 1, "Father of all the undead.");
            Monsters m3 = new(name: "Mikey", hitChance: 50, block: 10, maxLife: 25, maxDamage: 4, minDamage: 1, description: "He is no longer a teenager");
            Monsters m4 = new(name: "Smaug", hitChance: 65, block: 20, maxLife: 20, maxDamage: 15,minDamage: 1, description: "The last great dragon");
            //Add the monsters to a collection
            List<Monsters> monsters = new()
            {
                m1,
                m2,
                m3,
                m4,

            };

            //Pick one at random to place in our dungeon room
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}
