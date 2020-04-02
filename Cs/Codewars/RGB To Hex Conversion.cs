using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class RGB_To_Hex_Conversion
    {
        public static string Rgb(int r, int g, int b)
        {
            if (r > 255)
                r = 255;
            if (g > 255)
                g = 255;
            if (b > 255)
                b = 255;
            if (r < 0)
                r = 0;
            if (g < 0)
                g = 0;
            if (b < 0)
                b = 0;
            string[] hex = new string[16] {"0", "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F" };
            string rHex1 = hex[r / 16];
            string rHex2 = hex[r % 16];
            string gHex1 = hex[g / 16];
            string gHex2 = hex[g % 16];
            string bHex1 = hex[b / 16];
            string bHex2 = hex[b % 16];
            string result = rHex1 + rHex2 + gHex1 + gHex2 + bHex1 + bHex2;
            return result;
        }
        public static void Test()
        {
            DisplayResults.Display(Rgb(255, 255, 255));
            DisplayResults.Display(Rgb(255, 255, 300));
        }
    }
}
