using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos
{
    internal class Strojar : Character
    {
        private int _defenderMachine;
        public int SpecialCharge
        {
            get => _defenderMachine;

            set
            {
                if (value >= 3)
                {
                    _defenderMachine = 3;
                    SpecialReady = true;
                    return;
                }
                _defenderMachine = value;
                SpecialReady = false;
            }
        }

        public Strojar(int hp, string name, int power) : base(hp, name, power)
        {
            SpecialCharge = 0;
            SpecialReady = false;
        }

        public override void Attack(Character opponent)
        {
            if (SpecialReady)
            {
                Console.WriteLine("Damage blocked by DefenderMachine");
                SpecialCharge = 0;
                Validation.EnterContinue();
                Console.Clear();
                Info();
                opponent.Info();
            }

            Console.WriteLine("Your attack:");
            if (AttackStyles.Slider(100))
            {
                opponent.DecreaseHp(Power);
                SpecialCharge++;
                return;
            }
            Console.WriteLine("Minul jsi....pokračuj libovolnou klávesou");
            Validation.EnterContinue();
            Console.Clear();
        }

        public override void Info()
        {
            Utility.StrojarStats(this);
        }
    }
}
