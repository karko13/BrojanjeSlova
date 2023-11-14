using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neku recenicu ");
            string word = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (letters.ContainsKey(word[i]))
                {
                    letters[word[i]]++;
                }
                else
                {
                    letters[word[i]] = 1;
                }
            }
            int maxLetterFreq = 0;
            char maxLetterKey = ' ';
            foreach (var c in letters)
            {
                if (maxLetterFreq < c.Value)
                {
                    maxLetterFreq = c.Value;
                    maxLetterKey = c.Key;
                }
            }
            string str = " ";
            int j = 1;
                foreach (var c in letters)
                {
                    if (char.IsLetter(c.Key))
                    {
                        if (j == 1)
                        {
                            Console.WriteLine("Najvise ponovljenog slova je " + maxLetterKey + ", a ponovilo se  " + maxLetterFreq + ".");
                            j++;
                        }
                    }

                }

            
            Console.ReadKey();
        }
    }
}