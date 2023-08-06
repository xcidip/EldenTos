using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EldenTos
{
    public static class AttackStyles
    {

        #region metoda slider
        public static bool Slider(int speed)
        {
            var hit = false;
            var field = new []
            {
                "[ * - | - - | - - ]",
                "[ - * | - - | - - ]",
                "[ - - * - - | - - ]",
                "[ - - | * - | - - ]",
                "[ - - | - * | - - ]",
                "[ - - | - - * - - ]",
                "[ - - | - - | * - ]",
                "[ - - | - - | - * ]",
                "[ - - | - - | * - ]",
                "[ - - | - - * - - ]",
                "[ - - | - * | - - ]",
                "[ - - | * - | - - ]",
                "[ - - * - - | - - ]",
                "[ - * | - - | - - ]",
                "[ * - | - - | - - ]"
            };

            var index = 0;

            // do until something is clicked
            do
            {
                // for looping the animation
                if (index == field.Length)
                {
                    index = 0;
                }

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(field[index]);
                Thread.Sleep(speed);
                index++;


            } while (!Console.KeyAvailable); // vrátí false při stisknutí klávesy
            Console.ReadKey();  // sežrání znaku

            Console.Clear();

            // if last frame's position is the star's position now
            index--;
            var hitCounter = 0;
            
            for (var i = 0; i < field[index].Length; i++)
            {
                if (field[index][i] == '|')
                {
                    hitCounter++;
                }
            }

            if (hitCounter == 2)
            {
                hit = true;
            }
            return hit;
        }
        #endregion

        #region metoda hod kostkou

        public static int DiceRoll(int maxValue)
        {
            var random = new Random();
            return random.Next(maxValue + 1);
        }

        #endregion

        #region kamen nuzky papir
        public static int RockPaperScissors()
        {
            int[,] field = { { 0, 1, 2 }, { 2, 0, 1 }, { 1, 2, 0 } };
            string[] names = { "Kámen", "Nůžky", "Papír" };

            Console.WriteLine("(0) - Kámen\n(1) - Nůžky\n(2) - Papír");

            Console.Write("Tvoje volba: ");
            var choice = Validation.NumberRange(0, 2);

            var random = new Random();
            var computerChoice = random.Next(3);
            var fieldAnswer = field[computerChoice, choice];

            Console.WriteLine("Zadal jsi: " + names[choice]);
            Console.WriteLine("Počítač dal: " + names[computerChoice]);
            
            return fieldAnswer;
        }
        #endregion

    }
}
