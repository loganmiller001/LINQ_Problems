﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {


            //Problem1
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            // var lettersCount = words.Where(w => w.Contains("th")).Count();

            //Console.WriteLine("Words with the letters 'th' are: " + lettersCount);
            //Console.ReadKey();

            //Problem2
            //List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

            //var justOneName = names.Select(n => n).Distinct().ToList();
            ////List<string> names2 = names.Distinct().ToList();
            //foreach (var name in justOneName)
            //{
            //    Console.WriteLine("{0}", name);
            //}
            //Console.ReadKey();

            //Problem3
            //List<string> classGrades = new List<string>
            //{
            //    "80, 100, 92, 89, 65",
            //    "93, 91, 78, 84, 69",
            //    "73, 88, 83, 99, 64",
            //    "98, 100, 66, 74, 55"

            //};

            ////Problem4

            Problem4 problem = new Problem4();
            problem.GetCountAndAlphabetize();
        }
    }
}
