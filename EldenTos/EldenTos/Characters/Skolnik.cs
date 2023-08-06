using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos.Characters
{
    internal class Skolnik : Character
    {

        public Skolnik(int hp, string name, int power) : base(hp, name, power)
        {

        }

        public override void Attack(Character opponent)
        {
            var result = AttackStyles.RockPaperScissors();

            switch (result)
            {
                case 0:
                    Console.WriteLine("Remíza");
                    opponent.DecreaseHp(Power/2);
                    break;
                case 2:
                    Console.WriteLine("AI prohrál");
                    
                    break;
                default:
                    Console.WriteLine("AI vyhrál");
                    opponent.DecreaseHp(Power);
                    break;
            }
            Validation.EnterContinue();
            Console.Clear();
        }

        public override void Info()
        {
            Utility.BasicStats(this);
        }
    }
}
