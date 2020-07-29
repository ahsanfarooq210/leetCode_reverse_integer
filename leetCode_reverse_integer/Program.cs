using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode_reverse_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(num));
            Console.ReadLine();

        }
        public static int Reverse(int x)
        {
            long reversed = 0;
            while (x != 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }
            if (reversed > int.MaxValue || reversed < int.MinValue) return 0;
            return (int)reversed;
        }
    }
}
