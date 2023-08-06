using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos.Characters
{
    internal class UcitelDejepisu : Character
    {

        public UcitelDejepisu(int hp, string name, int power) : base(hp, name, power)
        {

        }

        public override void Attack(Character opponent)
        {
            var hit = AttackStyles.DiceRoll(Power * 2);
            opponent.DecreaseHp(hit);
            Console.WriteLine("You got hit for {0}",hit);
        }

        public override void Info()
        {
            Utility.BasicStats(this);
        }
    }
}
