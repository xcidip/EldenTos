using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos
{
    // only for others to inherit
    internal abstract class Character
    {
        public int Hp { get; protected set; }
        public string Name { get; protected set; }
        public int Power { get; protected set; }
        public bool IsAlive { get; protected set; }

        public bool SpecialReady { get; set; }

        protected Character(int hp, string name, int power)
        {
            Hp = hp;
            Name = name;
            Power = power;
            IsAlive = true;
            
        }

        public void DecreaseHp(int hit)
        {
            Hp -= hit;
            if (Hp <= 0) IsAlive = false;
        }

        public abstract void Attack(Character opponent);

        public abstract void Info();

    }
}
