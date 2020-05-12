using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ linq = new LINQ();

            // #1 ********************************************************************************************
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            
            List<string> thWords = linq.WordsContainingTH(words);
            foreach(string s in thWords)
                Console.WriteLine(s);
            Console.ReadLine();

            // #2 ********************************************************************************************
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            List<string> nodupNames = linq.RemoveDuplicates(names);
            foreach (string s in nodupNames)
                Console.WriteLine(s);
            Console.ReadLine();

            // #3 ********************************************************************************************
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            Console.WriteLine($"Class Grade Average: {linq.ClassGradeAverage(classGrades)}");
            Console.ReadLine();

            // #4 ********************************************************************************************
            string inStr = "Terrill";

            Console.WriteLine($"{inStr} => {linq.GetLetterFreq(inStr)}");
            Console.ReadLine();
        }
    }
}
