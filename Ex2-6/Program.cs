using System;

namespace Ex2_6
{
    class Program
    {
        //Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать
        //подсчёт времени выполнения программы, используя структуру DateTime.

        static void Main(string[] args)
        {
                int min = 1;
                int max = 1000000000;
                int count = 0;
                bool flag = false;
                DateTime start = DateTime.Now;

            for (int i = min; i < max; i++)
                {
                    flag = Check(i);
                    if (flag) count++;

                }
                Console.WriteLine($"Количество Хороших чисел в интервале от 1 до 1 000 000 000 составило {count:N0} штук");
            Console.WriteLine(DateTime.Now - start);
                

            static bool Check(int i)
            {
                int temp = i;
                int SuN = 0;
                while (temp > 0)
                {
                    SuN += temp % 10;
                    temp /= 10;
                }
                return i % SuN == 0;

            }
        }
    }
}
