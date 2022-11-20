using System;

namespace _6._103
{
    class Program
    {
        static double Metod(string Name, double Min = double.MinValue, double Max = double.MaxValue, double E2 = double.MinValue)
        {
            double Num;
            Console.WriteLine($"Введите {Name}:");
            while (!(double.TryParse(Console.ReadLine(), out Num) && Num > Min && Num < Max && Num != E2)) Console.WriteLine($"Неверно {Name}");
            return Num;
        }
        static void Main(string[] args)
        {
            int a = (int)Metod("Числитель");
            int b = (int)Metod("Знаменатель");
            int a1 = 0;
            int b2 = 0;
            if (a > b) { a1 = a; b2 = b; }
            else { a1 = b; b2 = a; }
            while (a1 != 0)
            {
                if (a1 < b2) { b2 -= a1; continue; }
                a1 -= b2;
            }
            int z = a / b2;
            int x = b / b2;
            Console.WriteLine(b2 == 1 ? "Дроби не сокращаются" : $"{a}/{b} = {z}/{x}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
