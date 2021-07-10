using System;

namespace Ex2_5
{
    class Program
    {
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
        //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        static void Main(string[] args)
        {
            double weight, height, normalWeightMin, normalWeightMax, deltaW, IMT;
            Console.WriteLine("Введите ваш вес в килограммах");
            weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            height = Double.Parse(Console.ReadLine());
            if (height > 3)
            {
                height = height / 100;  //защита от ввода роста в сантиметрах, вряд ли кто то введет значение больше 3,
                                        //имея в виду метры, так что все, что больше 3 заведомо введено в см, и нужно разделить на 100
                
            }
            IMT = weight / (height * height);
            normalWeightMin = 18.5 * (height * height);
            normalWeightMax = 24.9 * (height * height);
            if (IMT < 18.5)
            {
                deltaW = normalWeightMin - weight;
                Console.WriteLine($"Ваш ИМТ равен {IMT:F2}, вам следует набрать {deltaW:F1} кг."); //точность больше чем до 100 грамм не думаю что нужна
            } else if (IMT>= 18.5 && IMT < 25)
            {
                Console.WriteLine($"Ваш ИМТ равен {IMT:F2}, ваш вес находится в норме");
            } else
            {
                deltaW = weight - normalWeightMax;
                Console.WriteLine($"Ваш ИМТ равен {IMT:F2}, вам следует сбросить {deltaW:F1} кг.");
            }
            
        }
    }
}
