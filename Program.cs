using System;
using Microsoft.VisualBasic;

namespace Totsuzenshi_gen
{
    internal class Program
    {
        public static string ReadLineAndWrite(string s)
        {
            Console.Write(s);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            while(true)
                Console.Write(omg(convert(ReadLineAndWrite("入力＞")))+Environment.NewLine);
        }

        public static string omg(String s)
        {
            string res = "";
            int a1 = s.Length+2;
            res += "＿";
            for (int i = 0; i < a1; i++)
                res += "人";
            res += "＿" + Environment.NewLine;
            res += "＞　" + s + "　＜" + Environment.NewLine;
            res += "￣";
            for (int i = 0; i < a1; i++)
                res += "^Y";
            res += "￣";
            return res;
        }

        public static string convert(String s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                bool big = false;
                if (char.IsUpper(s.ToCharArray()[i])) big = true;
                string check = s.ToLower()[i].ToString();
                string res1 = "";
                if (check == "a")
                    res1 = "ａ";
                else if (check == "b")
                    res1 = "ｂ";
                else if (check == "c")
                    res1 = "ｃ";
                else if (check == "d")
                    res1 = "ｄ";
                else if (check == "e")
                    res1 = "ｅ";
                else if (check == "f")
                    res1 = "ｆ";
                else if (check == "g")
                    res1 = "ｇ";
                else if (check == "h")
                    res1 = "ｈ";
                else if (check == "i")
                    res1 = "ｉ";
                else if (check == "j")
                    res1 = "ｊ";
                else if (check == "k")
                    res1 = "ｋ";
                else if (check == "l")
                    res1 = "ｌ";
                else if (check == "m")
                    res1 = "ｍ";
                else if (check == "n")
                    res1 = "ｎ";
                else if (check == "o")
                    res1 = "ｏ";
                else if (check == "p")
                    res1 = "ｐ";
                else if (check == "q")
                    res1 = "ｑ";
                else if (check == "r")
                    res1 = "ｒ";
                else if (check == "s")
                    res1 = "ｓ";
                else if (check == "t")
                    res1 = "ｔ";
                else if (check == "u")
                    res1 = "ｕ";
                else if (check == "v")
                    res1 = "ｖ";
                else if (check == "w")
                    res1 = "ｗ";
                else if (check == "x")
                    res1 = "ｘ";
                else if (check == "y")
                    res1 = "ｙ";
                else if (check == "z")
                    res1 = "ｚ";
                else res1 = check;
                if (big)
                    res1 = res1.ToUpper();
                res += res1;
            }

            return res;
        }
    }
}
