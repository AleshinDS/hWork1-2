using System;

namespace Ex2_2
{
    class Program
    {
        //Написать метод подсчета количества цифр числа.

        static void Main(string[] args)
        {
        int a;
        Console.Write("введите число: ");
        a = int.Parse(Console.ReadLine());
        String b = a.ToString();
        Console.WriteLine("Количество цифр в числе {0}:", b.Length);
       }
        
    }
}
