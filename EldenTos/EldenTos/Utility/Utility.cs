using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos
{
    // ReSharper disable once InconsistentNaming
    internal static class Utility
    {
        #region Stats

        public static void StrojarStats(Strojar strojar)
        {
            Console.WriteLine($"+----------+-------------+----------------------+");
            Console.SetCursorPosition(2, Console.CursorTop - 1);
            Console.WriteLine(strojar.Name);

            Console.WriteLine($"| HP: {strojar.Hp,4} | Power: {strojar.Power,4} | DefenderMachine: {strojar.SpecialCharge}/3 |");

            Console.WriteLine($"+----------+-------------+----------------------+");
        }
        public static void AjtakStats(Ajtak ajtak)
        {
            Console.WriteLine($"+----------+-------------+----------------+");
            Console.SetCursorPosition(2, Console.CursorTop - 1);
            Console.WriteLine(ajtak.Name);

            var specialCharge = "";
            switch (ajtak.SpecialCharge)
            {
                case 1:
                    specialCharge = "H...";
                    break;
                case 2:
                    specialCharge = "HA..";
                    break;
                case 3:
                    specialCharge = "HAC.";
                    break;
                case 4:
                    specialCharge = "HACK";
                    break;
            }
            

            Console.WriteLine($"| HP: {ajtak.Hp,4} | Power: {ajtak.Power,4} | Keyboard: {specialCharge,4} |");

            Console.WriteLine($"+----------+-------------+----------------+");
        }

        public static void BasicStats(Character character)
        {
            Console.WriteLine($"\n+----------+-------------+");
            Console.SetCursorPosition(2, Console.CursorTop - 1);
            Console.WriteLine(character.Name);

            Console.WriteLine($"| HP: {character.Hp,4} | Power: {character.Power,4} |");

            Console.WriteLine($"+----------+-------------+");
        }

        #endregion

        #region Creation
        public static int ChooseProfession()
        {
            Console.WriteLine("Tvoje povolání\n(1) Strojař\n(2) Ajťák");
            return Validation.NumberRange(1, 2);
        }

        public static string ChooseName(string whom)
        {
            Console.Write($"{whom} jméno: ");
            return Console.ReadLine();
        }

        public static int ChooseEnemy()
        {
            Console.WriteLine("Tvůj nepřítel\n(1) Školník - kamen,nuzky,papir\n(2) Učitel Dějepisu - hod kostkou\n(3) Master Of TOS - slider");
            return Validation.NumberRange(1, 3);
        }
        public static ValueTuple<int, int> ChooseStats()
        {

            Console.Write("HP 1-9999 (Default - 100)\n");
            var hp = Validation.NumberRange(1, 9999);
            Console.Write("power 1-9999 (Default - 8\n");
            var power = Validation.NumberRange(1, 9999);
            return new ValueTuple<int, int>(hp, power);
        }


        #endregion

    }
}
