using Dungeon_Library;
namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.Title = "DUNGEON OF DOOM!";
            Console.WriteLine("Your journey begins...\n");
            #endregion

            #region Player Creation
            //TODONE Variable to keep score
            int score = 0;
            //TODO Weapon creation
            //Possible Expansion - Display a list of pre-created weapons and let them pick one.
            //Or, pick one for them randomly.
            Weapon sword = new Weapon(8, 1, "Long Sword", 10, false, WeaponType.Katana);

            //TODONE Player Object creation
            //Potential Expansion - Allow them to enter their own name.
            //Show them the possible races and let them pick one.
            Player player = new(5,"Hatake Kazuki",40, 70, Race.Elven,sword);


            #endregion

            #region Main Game Loop
            bool exit = false;
            //int innerCount = 0;
            //int outerCount = 0;
            do
            {
                //Console.WriteLine("Outer " + ++outerCount);
                //TODO Generate a random room
                Console.WriteLine(GetRoom());
                //TODONE Select a random monster to inhabit the room
                Monsters monsters = Monsters.GetMonster();
                Console.WriteLine($"In this room {monsters.Name}!");
                #region Gameplay Menu Loop
                bool reload = false;

                do
                {
                    //Console.WriteLine("Inner: " + ++innerCount);
                    //TODONE Gameplay Menu
                    #region Menu
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODONE Combat
                            //Potential Expansion : weapon/race bonus attack
                            //if race == darkelf -> player.DoAttack(monster)
                            Combat.DoBattle(player, monsters);
                            //check if the monster is dead
                            if (monsters.Life <= 0)
                            {
                                //Combat rewards -> money, health, whatever
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monsters.Name}!");
                                Console.ResetColor();
                                //flip the inner-loop bool to true
                                reload = true;

                                score++;
                            }
                            break;

                        case ConsoleKey.R:
                            //TODO Attack of Opportunity
                            Console.WriteLine("Run away!!");
                            Console.WriteLine($"{monsters.Name} attacks you as you flee!");
                            Combat.DoAttack(monsters, player);
                            Console.WriteLine();//formatting
                            reload = true;//new room, new monster
                            break;

                        case ConsoleKey.P:
                            //TODO player info
                            Console.WriteLine("Player Info: ");
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            //TODO Monster info
                            Console.WriteLine("Monster Info: ");
                            Console.WriteLine(monsters);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            //reload = true;
                            break;
                        default:
                            break;
                    }

                    #endregion
                    //TODONE Check player life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude... you died!\a");
                        exit = true;
                    }

                } while (!reload && !exit); //If either exit or reload is true, the inner loop will exit.
                #endregion

            } while (!exit);//If exit is true, the outer loop will exit as well.

            //Show the score
            Console.WriteLine("You defeated " + score + " monster" +
                (score == 1 ? "." : "s."));

            #endregion
        }//end main

        private static string GetRoom()
        {
            string[] rooms =
            {
                "1", "2", "3", "3", "5"
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];;

            return room;
            //possible refactor
            //return rooms[new Random().Next(rooms.Length)];




        }//end GetRoom()

    }//end class
}//end namespace