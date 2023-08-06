using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenTos
{
    public static class Validation
    {
        public static void EnterContinue()
        {
            Console.WriteLine("Press ENTER to continue: ");
            Console.ReadLine();
        }

        public static int NumberRange(int start, int end)
        {
            while (true)
            {
                Console.Write($"Enter number between {start} - {end}: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out var inputNum))
                {
                    if (inputNum > end && inputNum < start)
                    {
                        Console.WriteLine("wrong number");
                    }

                    return inputNum;

                }
                Console.WriteLine("not even a number");
            }

        }
    }
}
