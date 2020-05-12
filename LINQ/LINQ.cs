using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
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
            double[] doubleArray;

            double[] stringAverages = new double[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                stringArray = list[i].Split(',');
                doubleArray = new double[stringArray.Length];

                for (int j = 0; j < stringArray.Length; j++)
                    doubleArray[j] = int.Parse(stringArray[j]);

                stringAverages[i] = (doubleArray.Where(s => s != doubleArray.Min())).Average();
            }
            return stringAverages.Average();
        }

        // Returns alphabetically ordered string of letter frequency.
        public string GetLetterFreq(string input)
        {
            string rtnStr = "";

            var groups = input.ToUpper().ToArray().GroupBy(c => c).OrderBy(c => c.Key);

            foreach (var g in groups)
            {
                rtnStr += g.Key + g.Count().ToString();
            }
            return rtnStr;
        }
    }
}
