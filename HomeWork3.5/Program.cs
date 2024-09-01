using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._5
{
    public class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Игра удагай число");
            Console.WriteLine("Введите диапозон чисел: ");
            int max = int.Parse(Console.ReadLine());
            int r = rnd.Next(1 , max);
            string empty;
            Console.WriteLine("Введите угадываемое число ");
            while (true)
            {

                empty = Console.ReadLine();
                if (empty==string.Empty)
                {
                    Console.WriteLine($"Было загадано: {r}");
                    break;
                }
                int randomN = int.Parse(empty);
                if (r < randomN)
                {
                    Console.WriteLine("Угадываемое число меньше");
                }
                else if (r > randomN)
                {
                    Console.WriteLine("Угадываемое число больше");
                }
                else if (r == randomN)
                {
                    Console.WriteLine("Угадали");
                    break;
                }
                
            }
            Console.ReadLine();
        }
        
    }
}
