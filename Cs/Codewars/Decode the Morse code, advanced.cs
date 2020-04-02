using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving_and__Algorithm_Study.Codewars
{
    class Decode_the_Morse_code__advanced
    {
        public static string DecodeBits(string bits)
        {
            string dot = "11";
            string dash = "11111100";
            string singlespace = "0000";
            string space = "000000000000";
            bits = bits.Replace(dash, "-");
            bits = bits.Replace(dot, ".");
            bits = bits.Replace(space, " _ ");
            bits = bits.Replace(singlespace, " ");
            bits = bits.Replace("0", "");
            return bits;
        }

        public static string DecodeMorse(string morseCode)
        {
            Dictionary<string, string> mc = new Dictionary<string, string>();
            mc.Add(".-","A");
            mc.Add("-...","B");
            mc.Add("-.-.","C");
            mc.Add("-..", "D");
            mc.Add(".", "E");
            mc.Add("..-.", "F");
            mc.Add("--.", "G");
            mc.Add("....", "H");
            mc.Add("..", "I");
            mc.Add(".---", "J");
            mc.Add("-.-", "K");
            mc.Add(".-..", "L");
            mc.Add("--", "M");
            mc.Add("-.", "N");
            mc.Add("---", "O");
            mc.Add(".--.", "P");
            mc.Add("--.-", "Q");
            mc.Add(".-.", "R");
            mc.Add("...", "S");
            mc.Add("-", "T");
            mc.Add("..-", "U");
            mc.Add("...-", "V");
            mc.Add(".--", "W");
            mc.Add("-..-", "X");
            mc.Add("-.--", "Y");
            mc.Add("--..", "Z");
            mc.Add("_", " ");
            string result = "";
            foreach (var s in morseCode.Split())
            {
                if(mc.ContainsKey(s))
                    result += mc[s];
            }
            result = result.Trim();
            return result;
        }
        public static void Test()
        {
            DisplayResults.Display(DecodeMorse(DecodeBits("1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"))); //E
            DisplayResults.Display(DecodeMorse(DecodeBits("01110"))); //E
            DisplayResults.Display(DecodeMorse(DecodeBits("00011100010101010001000000011101110101110001010111000101000111010111010001110101110000000111010101000101110100011101110111000101110111000111010000000101011101000111011101110001110101011100000001011101110111000101011100011101110001011101110100010101000000011101110111000101010111000100010111010000000111000101010100010000000101110101000101110001110111010100011101011101110000000111010100011101110111000111011101000101110101110101110")));
            //THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.
            DisplayResults.Display(DecodeMorse(DecodeBits("111"))); //E
        }
    }
}
