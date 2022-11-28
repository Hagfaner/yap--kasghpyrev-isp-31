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
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            while (number > 1)
            {
                if (number % 2 == 0)
                    number /= 2;
                else number = number*3 + 1;
                count+=1;
            }
            Console.WriteLine($"Количество необходимых действий над числом - {count}");
            Console.ReadLine();
        }
    }
}
