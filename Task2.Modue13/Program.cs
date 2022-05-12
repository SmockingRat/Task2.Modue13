using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2.Modue13
{
    /// <summary>
    /// Central class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Central method
        /// </summary>
        /// <param name="args">Entry parameter</param>
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("C:\\Users\\Михаил\\Downloads\\Text1.txt");
            Dictionary<string, int> sorDict = new Dictionary<string, int>();
            var text = read.ReadToEnd();
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] f;
            f = noPunctuationText.Split(' ');

            foreach (string w in f)
            {
                if (sorDict.ContainsKey(w))
                {
                    sorDict[w]++;
                }
                else
                {
                    sorDict.Add(w, 1);
                }
            }

            foreach (var i in sorDict.OrderByDescending(x => x.Value).Take(10))
            {
                Console.WriteLine($"Слово '{i.Key}' повторилось '{i.Value}' раз");
            }

            Console.ReadLine();
 
            

        }
    }
}
