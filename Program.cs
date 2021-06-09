using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxValue, MinValue;
            Console.WriteLine("Введите максимальную температуру за месяц");
            MaxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру за месяц");
            MinValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Средняя температура за месяц - " + (MaxValue + MinValue) / 2);
        }
    }
}
