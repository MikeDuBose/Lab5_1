using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gc = new List<GameCharacter>();
            gc.Add(new Warrior("Hannah", 5, 10, "Famous coffee syrup"));
            gc.Add(new Warrior("Banana the Invoker", 2, 6, "Banana Peels"));
            gc.Add(new Wizard("Gandalf the Grey", 6, 2, 50, 1));
            gc.Add(new Wizard("Gandalf the White", 10, 10, 100, 3));
            gc.Add(new Wizard("Gandalf the Dead", 0, 0, 0, 0));


            foreach (GameCharacter p in gc)
            {
                Console.WriteLine(p.Play());
            }

        }
    }
}