using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SortCharacter
    {
        private string[] vowels = ["a", "i", "u", "e", "o"];
        private string procVowel(string param)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < param.Length; i++)
            {
                foreach (string vowel in vowels)
                {
                    if (param.Substring(i, 1) == vowel)
                    {
                        list.Add(vowel);
                    }
                }
            }

            if (list.Count == 0)
            {
                return "No Vowel";
            }

            return string.Join("", sortData(list));
        }

        private string procConsonant(string param)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < param.Length; i++)
            {
                Boolean available = false;
                foreach (string vowel in vowels)
                {
                    if (param.Substring(i, 1) == vowel)
                    {
                        available = true;
                    }
                }

                if (!available)
                {
                    list.Add(param.Substring(i, 1));
                }

            }

            if (list.Count == 0)
            {
                return "No Consonant";
            }

            return string.Join("", sortData(list));
        }

        private List<string> sortData(List<string> input)
        {
            List<string> distinctData = input.Distinct().ToList();
            List<string> sortedData = new List<string>();

            for (int i = 0; i < distinctData.Count; i++)
            {
                foreach (var character in input)
                {
                    if (distinctData.ElementAt(i) == character)
                    {
                        sortedData.Add(character);
                    }
                }
            }

            return sortedData;
        }

        public void run()
        {
            Console.Write("Input one line of words (S) : ");
            try
            {
                string input = Console.ReadLine().Replace(" ", "").ToLower();

                string charVowel = procVowel(input);
                string charConsonant = procConsonant(input);

                Console.WriteLine("Vowel characters : ");
                Console.WriteLine(charVowel);
                Console.WriteLine("Consonant Characters : ");
                Console.WriteLine(charConsonant);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
