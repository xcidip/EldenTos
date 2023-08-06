using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EldenTos.Characters;

namespace EldenTos
{
    public static class Program
    {
        public static void Main()
        {
            //todo make the other attack styles work
            //todo make other enemies: Skolnik, Ucitel dejepisu, MasterOfTos
            //todo rename all variable to random czech words

            Console.WriteLine("Welcome to EldenTOS");

            var name = Utility.ChooseName("Tvoje");
            Console.Clear();
            var profession = Utility.ChooseProfession();
            Console.Clear();
            var stats = Utility.ChooseStats();
            Console.Clear();

            while (true)
            {
                var enemyChoice = Utility.ChooseEnemy();
                Console.Clear();


                Character player = profession switch
                {
                    1 => new Strojar(stats.Item1, name, stats.Item2),
                    _ => new Ajtak(stats.Item1, name, stats.Item2),
                };
                Character enemy = enemyChoice switch
                {
                    1 => new Skolnik(100, "Skolnik", 4),
                    2 => new UcitelDejepisu(100, "UcitelDejepisu", 4),
                    _ => new MasterOfTos(100, "MasterOfTos", 4)
                };

                // fight
                do
                {
                    player.Info();
                    enemy.Info();
                    player.Attack(enemy);
                    if (enemy.Hp < 1) break;
                    player.Info();
                    enemy.Info();
                    // defender machine
                    if (!(player is Strojar && player.SpecialReady)) enemy.Attack(player);
                    Console.Clear();

                } while (player.IsAlive && enemy.IsAlive);

                Console.WriteLine(player.IsAlive ? "You won congrats" : "The enemy won, rip you");
                Console.Read();
                Environment.Exit(0);
            }
            

        }
    }
}
