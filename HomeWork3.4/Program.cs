using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина последовательности: ");
            int a = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int val = 0;
            for (; a > 0; a--)
            {
                val = int.Parse(Console.ReadLine());
                min = min > val ? val : min;
            }
            Console.WriteLine($"Минимальное число: {min}");
            Console.ReadKey();
        }
    }
}
