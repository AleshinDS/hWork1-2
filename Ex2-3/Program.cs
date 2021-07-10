using System;

namespace Ex2_3
{
    class Program
    {
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
        //положительных чисел.

        static void Main(string[] args)
        {
            int a, sum=0;
            do
            {
                Console.WriteLine("введите число");
                a = int.Parse(Console.ReadLine());
                if (a > 0 && a % 2 != 0)
                {
                    sum = sum + a;
                } 
            }
            while (a != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {sum}");
            
            
        }
    }
}
