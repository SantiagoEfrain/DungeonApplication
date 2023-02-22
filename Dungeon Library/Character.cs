namespace Dungeon_Library
{
    public class Character
    {
        //Fields

        /*
         * int maxlife (assign first in ctor)
         * int life (cannot be more than maxlife)
         * string name
         * int hit chance
         * int block
         */
        private int _maxLife;
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;


        //Properties - 1 for each field
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }


        //Constructors - fully qualified, 1 default/unequalified
        public Character() { }

        public Character(int MaxLife, int Life, string Name, int HitChance, int Block)
        {
            MaxLife = _maxLife;
            Life = _life;
            Name = _name;
            HitChance = _hitChance;
            Block = Block;
        }
        //Methods
        //ToString() override

        public override string ToString()
        {
            return $"{Name}\n\n" +
                $"Max Damage: {MaxLife}\n" +
                $"Min Damage: {Life}\n" +
                $"Bonus Hit Chance: %{HitChance}\n" +
                $"Two Handed Weapon: {Block}\n";

        }
        //CalcBlock() returns an int -> return Block;
        public decimal CalcBlock()
        {
            return _block;
        }

        //CalcHitChance() returns an int -> return HitChance;
        public decimal CalcHitChance()
        {
            return (decimal)_hitChance;
        }
        //CalcDamage() returns an int -> return 0;
        public decimal CalcDamage()
        {
            return 0;
        }



        //CalcBlock() returns an int -> return Block;
        //CalcHitChance() returns an int -> returns HitChance;
        //CalcDamage() returns an int -> return 0;
    }
}