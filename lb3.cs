using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = 12;
            int min = 30;
            if (n == 0)
            {
                Console.WriteLine($"{h}:{min}");
            }
            else {
                
                min = 5 * (n+1);
                if (min >= 60) { h++; min %= 60; }
                h += n;
                while (h>=12) {h%=12;} 
                Console.WriteLine($"{h}:{min}");
            }
            
            Console.ReadLine();
        }
    }
}
