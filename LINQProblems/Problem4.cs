using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class Problem4
    {
        public void GetCountAndAlphabetize()
        {
            string str = "terrill";
            List<string> charCounts = str.GroupBy(ch => ch).OrderBy(item => item.Key).Select(
                                   item => item.Key + "=" + item.Count().ToString()).ToList();

            foreach (string s in charCounts)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }


    }
}
