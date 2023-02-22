using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Library;

namespace Dungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //Build and test the fuctionality of our library.
            Character c1 = new Character()
            {
                Name = "Hatake Kazuki",
                MaxLife = 32,
                Life = 28,
                HitChance = 87,
                Block = 12,
            };
            Console.WriteLine(c1);



            //Build and test a weapon
            Weapon w1 = new Weapon()
            {
                Name = "\n\nMonohoshizao",
                MaxDamage = 22,
                MinDamage = 15,
                BonusHitChance = 22,
                IsTwoHanded = true,
            };
            Console.WriteLine(w1);

            //Build and test a Character - include CalcBlock(), CalcHitChance(), CalcDamage()
            Console.WriteLine($"{c1.Name} has a block of {c1.CalcBlock()}");
            Console.WriteLine($"{c1.Name} has a block of {c1.CalcHitChance()}");
            Console.WriteLine($"{c1.Name} has a block of {c1.CalcDamage()}");


        }
    }
}
