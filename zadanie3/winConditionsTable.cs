using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie3
{
    class winConditionsTable
    {   
        public static void drawTable(string[] strings)
        {
            int width= maxLength(strings)+2;
            if (width < 5) width = 5;
            int midValue = (strings.Length - 1) / 2 ;
            Console.Write("{0}", "".PadLeft(width));
            foreach (var str in strings) Console.Write("{0}", str.PadLeft(width));
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("\n{0}", strings[i].PadLeft(width));
                for (int j = 0; j < strings.Length; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0}", "Draw".PadLeft(width));
                        continue;
                    }
                    if (Math.Abs(j - i) <= midValue)
                    {
                        Console.Write((j > i ? "Win" : "Lose").PadLeft(width));
                    }
                    else
                    {
                        Console.Write( (j > i ? "Lose" : "Win").PadLeft(width));
                    }
                }
            }
            Console.WriteLine();
        }
        static int maxLength(string[] strings)
        {
            int value = 0;
            foreach (var x in strings) if (value < x.Length) value = x.Length;
            return value;
        }
       
            

    }
}
