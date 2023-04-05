using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    internal class Program
  {
        static string Nword(int a)
        {
            string t = "";
            switch (a)
            {
                case 1: t = " one "; break;
                case 2: t = " two "; break;
                case 3: t = " three "; break;
                case 4: t = " four "; break;
                case 5: t = " five "; break;
                case 6: t = " six "; break;
                case 7: t = " seven "; break;
                case 8: t = " eight "; break;
                case 9: t = " nine "; break;
                default: break;
            }
            return t;
        }

        static string Sword(int a)
        {
            string t = "";
            switch (a)
            {
                case 1: t = " ten "; break;
                case 2: t = " twenty "; break;
                case 3: t = " thirty "; break;
                case 4: t = " forty "; break;
                case 5: t = " fivty "; break;
                case 6: t = " sixty "; break;
                case 7: t = " seventy "; break;
                case 8: t = " eighty "; break;
                case 9: t = " ninety "; break;
                default: break;
            }
            return t;
        }

        static string Teen(int a) 
        {
            string t = "";
            switch (a)
            {
                case 10: t = " ten "; break;
                case 11: t = " eleven "; break;
                case 12: t = " twelve "; break;
                case 13: t = " thirteen "; break;
                case 14: t = " forteen "; break;
                case 15: t = " fifteen "; break;
                case 16: t = " sixteen "; break;
                case 17: t = " seventeen "; break;
                case 18: t = " eighteen "; break;
                case 19: t = " nineteen "; break;
                default: break;
            }
            return t;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int num, digit; 
                string text = "";

                Console.WriteLine("Enter a Number Between 0 And 999,999,999");
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 999999999 && num >= 0)
                {
                    if (num == 0)
                        Console.WriteLine("zero");

                    for (int i = 8; i >= 0; i--)
                    {
                        digit = num / (int)Math.Pow(10, i);

                        if (digit != 0)
                        {
                            if (i == 7 || i == 4 || i == 1)
                            {
                                if (digit != 1)
                                {
                                    text += Sword(digit);
                                }
                                else
                                {
                                    digit = num / (int)Math.Pow(10, i - 1);
                                    text += Teen(digit);
                                    i--;
                                }
                            }
                            else
                            {
                                text += Nword(digit);
                            }
                            if (i == 3) text += "thounsand";
                            if (i == 6) text += "million";
                            if (i == 8 || i == 5 || i == 2) text += "hundred";
                        }
                        num %= (int)Math.Pow(10, i);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                Console.WriteLine(text);
            }
        }
    }
}
