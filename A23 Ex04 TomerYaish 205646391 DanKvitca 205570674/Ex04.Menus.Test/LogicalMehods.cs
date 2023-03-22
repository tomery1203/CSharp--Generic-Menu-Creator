using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    internal static class LogicalMethods
    {
        internal static void ShowVersion()
        {
            Console.WriteLine("Version:23.1.4.8859");
        }
        internal static void CountUpperCaseLetters()
        {
            int numOfWords;
            string StringInput;

            Console.WriteLine("Please enter a phrase:");
            StringInput = Console.ReadLine();
            numOfWords = CountUpperCase(StringInput);
            Console.WriteLine("There are {0} words in the phrase '{1}'", numOfWords.ToString(), StringInput);
        }
        private static int CountUpperCase(string i_Phrase)
        {
            int r_Count = 0;
            foreach (char c in i_Phrase)
            {
                if (char.IsUpper(c))
                {
                    r_Count++;
                }
            }
            return r_Count;
        }
        internal static void ShowTime()
        {
            Console.WriteLine("Current time: {0}", DateTime.Now.ToString("h:mm:ss tt"));
        }
        internal static void ShowDate()
        {
            Console.WriteLine("Current date: {0}", DateTime.Now.ToString("dd/MM/yy"));
        }
    }
}
