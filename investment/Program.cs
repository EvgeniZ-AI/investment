using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace investment
{
    class Program
    {
        // тут пмне просто интересно поиграть с числами и процентами девидентов)
        static void Main(string[] args)
        {
            int profit = 0;
            double oneProcent = 0;

            while (true)
            {
                Console.WriteLine("Введите сумму ежемесечных пополнений");
                int money = int.Parse(Console.ReadLine());
                const int percentagePerMonth = 6;

                Console.WriteLine($"посчитать доход за один год с вложениями: {money}?");
                Console.WriteLine("enter 'yes'");
                string answer = Console.ReadLine();

                if (answer == "yes" || answer == "Yes")
                {
                    for (int i = 0; i < 12; i++)
                    {
                        oneProcent = profit / 100;
                        profit += (int)oneProcent * percentagePerMonth;
                        Console.WriteLine($"Сумма на счету = {profit}");
                        profit += money;
                    }
                }
                else
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"Ежегодный доход = {oneProcent * 15} =15%");
                Console.WriteLine();
                Console.WriteLine($"Ежемесечный доход = {oneProcent * 6} = 6%");
                Console.WriteLine();
            }
            Console.WriteLine("END");


        }
    }
}
