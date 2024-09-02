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
            int i = 2;
            bool simple = true;
            while (i < n - 1)
            {
                if (n % i == 0)
                { 
                    simple = false;
                    break;
                }
                i++;    
                
            }
            if (simple)
            {
                Console.WriteLine("Ваше числе простое ");
            }
            else
            {
                Console.WriteLine("Ваше число не простое ");
            }
            Console.ReadLine();
        }
    }
}
