namespace Dungeon_Library
{
    //"abstract" denotes an "incomplete" class or method.
    //This tells the program that we will not create any Character objects directly

    public abstract class Character
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


        protected Character(int maxLife, string name, int hitChance, int block)
        {
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = maxLife;
        }

        //Methods
        //ToString() override

        public override string ToString()
        {
            return $"{Name}\n\n" +
                $"Life:{Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}\n";

        }
        //CalcBlock() returns an int -> return Block;
        public virtual int CalcBlock()
        {
            return Block;
        }

        //CalcHitChance() returns an int -> return HitChance;
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        //CalcDamage() returns an int -> return 0;
        public abstract int CalcDamage(); //an abstract just says somewhere down the line, one of the child classes MUST 
            //implement this with some functionality
      


        //CalcBlock() returns an int -> return Block;
        //CalcHitChance() returns an int -> returns HitChance;
        //CalcDamage() returns an int -> return 0;
    }
}