using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько у вас карт на руках: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string card;
            for (int i = n; n < 2; n++)
            {
                Console.WriteLine("Введите номинал карты: ");
                card = Console.ReadLine();

                switch (card)
                    {
                    case "J":
                        sum = sum + 10;
                        continue;
                    case "Q":
                        sum = sum + 10;
                        continue;
                    case "K":
                        sum = sum + 10;
                        continue;
                    case "T":
                        sum = sum + 10;
                        continue;
                    }
                
                int Card = int.Parse(card);
                sum += Card;
            }

            Console.WriteLine($"Сумма ваших карт: {sum}");
            Console.ReadLine();
        }
    }
}
