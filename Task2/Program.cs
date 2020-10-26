using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Тананыкин
     * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
     * по формуле I=m/(h*h); 
     * где m — масса тела в килограммах, h — рост в метрах.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчёта индекса массы тела человека");
            try
            {
                Console.Write("Введите вес человека в килограммах: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Введите рост человека в метрах: ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("Индекс тела {0:F2}", 
                    weight / (height * height));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Не верно ведены параметры человека");
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат ввода чисел");
            }

            Console.WriteLine(
                    "\nДля завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
