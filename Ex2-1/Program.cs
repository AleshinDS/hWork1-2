using System;

namespace Ex2_1
{
    class Program
    {
        //Написать метод, возвращающий минимальное из трёх чисел.
        static void Main(string[] args)
        {
            int a, b, c, max;
            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c) //через if/else
            {
                max = a;
            }
            else if (b > c)
            {
               max = b;
            }
            else
            {
                max = c;
            }
            Console.WriteLine($"наибольшее число {max}");

            max = a > b && a > c ? a : b > c ? b : c; //через тернарный оператор
            Console.WriteLine($"наибольшее число {max}");
        }
    }
}
