using System;

namespace Ex2_4
{
    class Program
        //Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
        //выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
        //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
        //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
        //цикла do while ограничить ввод пароля тремя попытками.
    {
        static void Main(string[] args)
        {
            string Log, Pass, uLog, uPass;
            int count;
            Log = "root";
            Pass = "GeekBrains";
            count = 3;
            


            while (count >0)
            {
                Console.Write("Введите логин: ");
                uLog = Console.ReadLine();
                Console.Write("Введите пароль: ");
                uPass = Console.ReadLine();
                if (uLog == Log && uPass == Pass)
                {
                    Console.WriteLine("Добро пожаловать на GeekBrains.ru!");
                    return;
                } else
                {
                    count = count-1;
                    Console.WriteLine($"Неверная пара логин/пароль, попробуйте снова. Попыток осталось: {count}");
                }
            }
            Console.WriteLine("Лимит попыток исчерпан");
            

        }
    }
}
