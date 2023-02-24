using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Player : Character
    {
        //Fields

        //Probs
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Constructors

        public Player()
        {

        }
        public Player(int MaxLife, int Life, string Name, int HitChance, int Block, Race playerRace, Weapon equippedWeapon) 
            : base(MaxLife, Life, Name, HitChance, Block)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Draconic:
                    break;
                case Race.Elven:
                    HitChance += 5;

                    break;
                case Race.Fairy:
                    break;
                case Race.Human:
                    break;
                case Race.Half_Wolf:
                    break;
                default:
                    break;
            }
            #endregion


        }
        //Methods

        public override string ToString()
        {
            string description = PlayerRace.ToString();
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n" +
                $"Description: {description}";
        }

        public override int CalcDamage()
        {
            //Create a Randoom object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return the damage
            return damage;
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
