using System;
using System.Collections.Generic;

namespace Tutorial_StringComplement2.Lesson1
{
    class Main
    {
        public void Run()
        {
            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
            }
        }
    }
}
