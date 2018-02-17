using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegExTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"abc", RegexOptions.IgnoreCase);

            Match match = regex.Match("abc");
            
            if(match.Success)
            {
                Console.WriteLine("Matching");
            }

            Console.ReadKey();
        }
    }
}
