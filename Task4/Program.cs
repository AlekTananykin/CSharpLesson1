using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Тананыкин
     * 
     * Написать программу обмена значениями двух переменных:
     *а) с использованием третьей переменной;
     *б) *без использования третьей переменной.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа обмена целых чисел\n\n" +
                "Введите целое число A:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите целое число B:");
                int b = int.Parse(Console.ReadLine());

                int buffer = a;
                a = b;
                b = buffer;

                Console.WriteLine("а)После обмена чисел через буффер: " +
                    "A = {0}, B = {1}", a, b);

                a += b;
                b = a - b;
                a -= b;

                Console.WriteLine("б)После повторного обмена чисел, " +
                    "но без буффера: A = {0}, B = {1}", a, b);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine(
                    "\nДля завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
