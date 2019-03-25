using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = "1 a2 aa3 aaaaa6 a,a4 aaa,5";
            string symbols2 = "1s11,,, 2 qwewqe";
            string symbols3 = "Дай, Джим, на счастье лапу мне, Такую лапу не видал я сроду.";

            //DeleteLongestWord(symbols);
            //ReplaceLongestShortest(symbols);
            //CountLettersPunctuation(symbols);
            StringToArray(symbols3);

            void StringToArray(string x)
            {
                string[] symbolsArray = x.Split(' ');
                // stackoverflow LINQ
                //Array.Sort(symbolsArray, (z,y) => y.Length.CompareTo(z.Length));

                string temp = "";

                for (int i = 0; i < symbolsArray.Length; i++)
                {
                    for (int j = 0; j < symbolsArray.Length - 1; j++)
                    {
                        if (symbolsArray[j].Length < symbolsArray[j + 1].Length)
                        {
                            temp = symbolsArray[j];
                            symbolsArray[j] = symbolsArray[j + 1];
                            symbolsArray[j + 1] = temp;
                        }
                    }
                }
                
                foreach (var item in symbolsArray)
                {
                    Console.WriteLine(item);
                }
            }
            void CountLettersPunctuation(string x)
            {
                int charDigitCount = x.Count(char.IsLetter) + x.Count(char.IsPunctuation);
                Console.WriteLine(charDigitCount);
            }
            void ReplaceLongestShortest(string x)
            {
                string[] arrSymbols = x.Split(' ');

                int maxLength = 0;
                int minLength = 0;
                int longestPosition = 0;
                int shortestPosition = 0;
                string longestWord = "";
                string shortestWord = "";

                for (int i = 0; i < arrSymbols.Length; i++)
                {
                    if (maxLength < arrSymbols[i].Length)
                    {
                        maxLength = arrSymbols[i].Length;
                        longestPosition = i;
                    }

                    if (minLength > arrSymbols[i].Length)
                    {
                        minLength = arrSymbols[i].Length;
                        shortestPosition = i;
                    }
                }

                longestWord = arrSymbols[longestPosition];
                shortestWord = arrSymbols[shortestPosition];
                arrSymbols[longestPosition] = shortestWord;
                arrSymbols[shortestPosition] = longestWord;

                string swappedString = string.Join(" ", arrSymbols);
                Console.WriteLine(swappedString);
            }
            void DeleteLongestWord(string x)
            {
                string[] arrSymbols = x.Split(' ');

                int maxLength = 0;
                int longestPosition = 0;
                string longestWord = "";

                for (int i = 0; i < arrSymbols.Length; i++)
                {
                    if (maxLength < arrSymbols[i].Length)
                    {
                        maxLength = arrSymbols[i].Length;
                        longestPosition = i;
                    }
                }

                // add + " " to remove space after replacing. Because if we will simply delete the word we will have two spaces 
                longestWord = arrSymbols[longestPosition] + " ";

                Console.WriteLine(x.Replace(longestWord, ""));
            }

            Console.Read();
        }
    }
}
