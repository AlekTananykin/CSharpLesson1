using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Тананыкин
 * 
* Написать программу «Анкета». Последовательно задаются вопросы 
* (имя, фамилия, возраст, рост, вес). В результате вся информация 
* выводится в одну строчку:
    а) используя  склеивание;
    б) используя форматированный вывод;
    в) используя вывод со знаком $.
 */

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа \"Анкета\"");

            try
            {
                Console.Write("\nВведите ваше имя: ");
                string name = Console.ReadLine();

                if (0 == name.Length)
                    throw new FormatException("Неверный формат имени.");
                    
                Console.Write("\nВведи вашу фамилию: ");
                string surname = Console.ReadLine();

                if (0 == surname.Length)
                    throw new FormatException("Неверный формат фамилии");

                Console.Write("\nВведите ваш возраст: ");
                int age = int.Parse(Console.ReadLine());


                Console.Write("\nВведите ваш рост в сантиметрах: ");
                int height = int.Parse(Console.ReadLine());

                Console.Write("\nВведите ваш вес: ");
                int weight = int.Parse(Console.ReadLine());

                Console.WriteLine("\nВариант а: " + name + " " + surname +
                    ", возраст " + age + " лет, рост " + height +
                    "(см), вес " + weight + "(кг)");

                Console.WriteLine("\nВариант б: {0} {1}, " +
                    "возраст {2} лет, рост {3}(см), вес {4}(кг)",
                    name, surname, age, height, weight);

                Console.WriteLine($"\nВариант в: {name} {surname}, " +
                    $"возраст {age} лет, рост {height}(см), вес {weight}(кг)");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Нарушен формат вводимых данных. " + e.Message);
            }

            Console.WriteLine(
                    "\nДля завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
