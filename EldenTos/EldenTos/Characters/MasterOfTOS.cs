using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos.Characters
{
    internal class MasterOfTos : Character
    {
        public int MaxHp { get; }

        public MasterOfTos(int hp, string name, int power) : base(hp, name, power)
        {
            MaxHp = hp;
        }

        public override void Attack(Character opponent)
        {
            var speed = 150;
            
            if (Hp < MaxHp * 0.9) speed = 140;
            if (Hp < MaxHp * 0.8) speed = 120;
            if (Hp < MaxHp * 0.7) speed = 100;
            if (Hp < MaxHp * 0.6) speed = 80;
            if (Hp < MaxHp * 0.5) speed = 70;
            if (Hp < MaxHp * 0.4) speed = 60;
            if (Hp < MaxHp * 0.3) speed = 50;
            if (Hp < MaxHp * 0.2) speed = 40;
            if (Hp < MaxHp * 0.1) speed = 30;

            if (AttackStyles.Slider(speed)) return;
            
            opponent.DecreaseHp(Power);
            Console.WriteLine("Minul jsi....Dostal si {0} damage", Power);
            Validation.EnterContinue();
            Console.Clear();
        }

        public override void Info()
        {
            Utility.BasicStats(this);
        }
    }
}
