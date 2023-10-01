using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_6ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(100, 199));
            Console.WriteLine(test(250, 300));
            Console.WriteLine(test(105, 190));
            Console.ReadLine();
        }
        public static bool test(int a, int b)
        {
            return (a >= 100 && a <= 100) || (b >= 100 && b <= 200);
        }
    }
}
