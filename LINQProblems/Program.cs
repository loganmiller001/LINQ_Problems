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
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

             var lettersCount = words.Where(w => w.Contains("th")).Count();
            //    foreach (var letters in words)
            //{
            //    Console.WriteLine("Words with the letters 'th' are: " + lettersCount);
            //}
            Console.WriteLine("Words with the letters 'th' are: " + lettersCount);
            Console.ReadKey();
            
        }
    }
}
