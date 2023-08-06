using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos
{
    internal class Ajtak : Character
    {
        public int AttackSpeed { get; private set; }


        private int _specialCharge;

        public int SpecialCharge
        {
            get => _specialCharge;

            set
            {
                if (value >= 4)
                {
                    _specialCharge = 4;
                    SpecialReady = true;
                    return;
                }
                _specialCharge = value;
                SpecialReady = false;
            }
        }

        public Ajtak(int hp, string name, int power) : base(hp, name, power)
        {
            SpecialCharge = 0;
            AttackSpeed = 100;
            SpecialReady = false;
        }

        public override void Attack(Character opponent)
        {
            AttackSpeed = SpecialReady ? 150 : 100;

            Console.WriteLine("Your attack:");
            if (AttackStyles.Slider(AttackSpeed, false))
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
            Utility.AjtakStats(this);
        }
    }
}
