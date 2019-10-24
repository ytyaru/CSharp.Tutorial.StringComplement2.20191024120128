using System;
using System.Collections.Generic;

namespace Tutorial_StringComplement2.Lesson2
{
    class Main
    {
        public void Run()
        {
            var cultures = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
                System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
                System.Globalization.CultureInfo.GetCultureInfo("ja-JP"),
                System.Globalization.CultureInfo.InvariantCulture
            };

            var date = DateTime.Now;
            var number = 31_415_926.536;
            FormattableString message = $"{date,20}{number,20:N3}";
            foreach (var culture in cultures)
            {
                var cultureSpecificMessage = message.ToString(culture);
                Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
            }

            // Expected output is like:
            // en-US       5/17/18 3:44:55 PM      31,415,926.536
            // en-GB      17/05/2018 15:44:55      31,415,926.536
            // nl-NL        17-05-18 15:44:55      31.415.926,536
            //            05/17/2018 15:44:55      31,415,926.536
        }
    }
}
