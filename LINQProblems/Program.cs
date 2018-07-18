using System;
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
            List<string> classGrades = new List<string>
            {
                "80, 100, 92, 89, 65",
                "93, 91, 78, 84, 69",
                "73, 88, 83, 99, 64",
                "98, 100, 66, 74, 55"

            };
            List<double> studentAverage = new List<double>();
            double classAverage;
            

            for (int i = 0; i < classGrades.Count; i++)
            {
                var usersGrades = classGrades[i].Split(',').Select(s => int.Parse(s)).ToList();
                var ascendingOrder = usersGrades.OrderBy(j => j).ToList();
                Console.WriteLine("Sort");
                foreach(var item in ascendingOrder)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");

                var dropLowest = from lowestScore in ascendingOrder
                                 where lowestScore > ascendingOrder.Min()
                                 select lowestScore;
                Console.WriteLine("Drop lowest");
                foreach (var item in dropLowest)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                studentAverage.Add(dropLowest.Average());
            }
            Console.WriteLine("Individual Averages");
            for (int k = 0; k < studentAverage.Count; k++)
            {
                Console.WriteLine(studentAverage[k]);
            }
            Console.WriteLine("Class Average");
            classAverage = studentAverage.Average();
            Console.WriteLine(classAverage);
            Console.WriteLine("");
            Console.ReadLine();

            ////Problem4

                //string str = "terrill";
                //List<string> charCounts = str.GroupBy(ch => ch).OrderBy(item => item.Key).Select(
                //                       item => item.Key + "=" + item.Count().ToString()).ToList();

                //foreach (string s in charCounts)
                //{
                //    Console.WriteLine(s);

                //}
                //Console.ReadKey();

        }
    }
}