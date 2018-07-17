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
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

            var justOneName = names.Select(n => n).Distinct().ToList();
            //List<string> names2 = names.Distinct().ToList();
            foreach (var name in justOneName)
            {
                Console.WriteLine("{0}", name);
            }
            Console.ReadKey();
        }
    }
}
