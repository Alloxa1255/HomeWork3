using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск простого числа");
            Console.Write("Введите ваше число ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            bool simple;
            while (i < n - 1)
            {

                simple = Convert.ToBoolean( n % i);
                i++;    
                
                Console.WriteLine(simple);
                if (simple == false)
                {
                    Console.WriteLine("Ваше числе простое ");
                }
                else
                {
                    Console.WriteLine("Ваше число не простое ");
                }
                break;
            }
            Console.ReadLine();
        }
    }
}
