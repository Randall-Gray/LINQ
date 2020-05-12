using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LINQ
    {
        // Member methods
        // Returns a list of strings made up of strings from the passed in list which contain "th".
        public List<string> WordsContainingTH(List<string> list)
        {
            return list.Where(s => s.ToLower().Contains("th")).ToList();
        }

        // Returns a list of strings made up of the strings from the passed in list with duplicates removed.
        public List<string> RemoveDuplicates(List<string> list)
        {
            return list.Distinct().ToList();
        }

        // Calculates class grade average after dropping the lowest grade for each student.
        public double ClassGradeAverage(List<string> list)
        {
            string[] stringArray;
            int[] intArray;
            int minInt, sumInt;
            double totalSum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sumInt = 0;
                stringArray = list[i].Split(',');
                intArray = new int[stringArray.Length];

                for (int j = 0; j < stringArray.Length; j++)
                    intArray[j] = int.Parse(stringArray[j]);

                minInt = intArray.Min();

                for (int j = 0; j < intArray.Length; j++)
                    if (intArray[j] != minInt)
                        sumInt += intArray[j];

                totalSum += sumInt / (intArray.Length - 1);
            }
            return totalSum/list.Count;

 //           s.ToArray().ToArray().Cast<int>().Except(s.ToArray().ToArray().Cast<int>().Min());

  //          var t = list.Average(s => s.ToArray().ToArray().Cast<int>().Except(s.ToArray().ToArray().Cast<int>().Min().Cast<int>()));

 //           double classAve = list.Average(j => j.Average(i => i.Except(l => l.Min(s => s.Cast<int>())   ))));
        }

        // Returns alphabetically ordered string of letter frequency.
        public string GetLetterFreq(string input)
        {
            return input;
        }
    }
}
