using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;
        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }

        public override string Play()
        {
            return $"Welcome, {Name} (int {Intelligence}, strength {Strength}, magic {MagicalEnergy}!";
        }
    }
}
