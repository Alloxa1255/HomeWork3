using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа по определению чётное число или не чётное ");
            Console.WriteLine("Введите число:");
            int n = int.Parse( Console.ReadLine() );
            if (n % 2 == 0)
            {   
                Console.WriteLine($"Число чётное!");
            }
            else
            {
                Console.WriteLine($"Число не чётное!");
            }
            Console.ReadLine();
        }
    }
}
