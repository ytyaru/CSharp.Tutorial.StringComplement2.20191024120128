using System;
using System.Collections.Generic;

namespace Tutorial_StringComplement2.Lesson0
{
    class Main
    {
        public void Run()
        {
            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ",xs)}}} and {{{string.Join(", ",ys)}}} sets.");

            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);

            // Expected output:
            // Find the intersection of the {1, 2, 7, 9} and {7, 9, 12} sets.
            // C:\Users\Jane\Documents
            // C:\Users\Jane\Documents
        }
    }
}
