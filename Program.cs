using System;

namespace Ex2_7
{
    class Program
    {
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        /*a*/
        public static void f(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b)
            {
                f(a + 1, b);
            }

        }

        /*b*/
        public static void q(int a, int b, int res)  //ошибка CS0161
        {
            if (a == b)
            {
                 Console.WriteLine($"сумма чисел от a до b  равна {res}");
            }
            else
            {
                q(a + 1, b, res + a);
            }
            
                       
        } 




        static void Main(string[] args)
        {
            Console.WriteLine("Введите конечное число ряда");
            int b = int.Parse(Console.ReadLine());
            f(0, b);
            q(0, b, 0);

        }
    }
}
