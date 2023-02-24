using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Dungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //Build and test the fuctionality of our library.
            //Build and test a weapon
            Weapon w1 = new Weapon()//change to constructor method like the get monster method SIKE JK
            {
                Name = "\nMonohoshizao",
                MaxDamage = 22,
                MinDamage = 15,
                BonusHitChance = 22,
                IsTwoHanded = true,
            };
            Console.WriteLine(w1);

            //Build and test a Character - include CalcBlock(), CalcHitChance(), CalcDamage()
            Player p1 = new()
            {
                Name = "Hatake Kazuki",
                MaxLife = 32,
                Life = 28,
                HitChance = 72,
                Block = 12,
                PlayerRace = Race.Human,
                EquippedWeapon = w1
            };
            Console.WriteLine(p1);
            Console.WriteLine($"{p1.Name} has a block of {p1.CalcBlock()}");
            Console.WriteLine($"{p1.Name} has a hit chance of {p1.CalcHitChance()}");
            Console.WriteLine($"{p1.Name} has a damage of {p1.CalcDamage()}\n");

            Console.WriteLine(Monsters.GetMonster());//use this method because it doesnt want to work with windows 11 SIKE JK
            Monsters monsters = Monsters.GetMonster();
            

            Console.WriteLine("\n\n***************COMBAT***************\n\n");
            Combat.DoBattle(p1, monsters);
        }
    }
}
