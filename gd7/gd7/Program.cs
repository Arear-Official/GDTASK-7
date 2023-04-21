using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gd7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("write a number");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("wrong number");
            }
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 1; i < num; i ++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    c++;
                    continue;
                }
                if (i % 3 == 0)
                {
                    a++;
                    continue;
                }
                if (i % 5 == 0)
                {
                    b++;
                    continue;
                }
            }
            Console.WriteLine($"A = {a}, B = {b}, C= {c}");
        }
    }
}
