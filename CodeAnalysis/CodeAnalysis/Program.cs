using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "a", "b", "bc", "d" };
            var names2 = names.Where(n => n.StartsWith("b"));
            Console.ReadLine();
        }
    }
}
