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
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            int ch1 = Convert.ToInt32(b[0]);int ch2 = Convert.ToInt32(b[1]);
            while (true) {
                int ch = ch1;
                while (ch>0) { 
                if (ch % 10 == ch2 % 10){
                   Console.Write($"{ch2 % 10} ");
                   ch /= 10;
                }else { ch /= 10; }}
                ch2 /= 10;
                if (ch2 == 0) break;
            }
            Console.ReadLine();
        }
    }
}
