using System;
using System.Collections.Generic;

namespace Tutorial_StringComplement2.Lesson3
{
    class Main
    {
        public void Run()
        {
            string messageInInvariantCulture = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
            Console.WriteLine(messageInInvariantCulture);

            // Expected output is like:
            // Date and time in invariant culture: 05/17/2018 15:46:24
        }
    }
}
