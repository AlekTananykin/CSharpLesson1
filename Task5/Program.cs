using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{

    /* Тананыкин Алекс
     * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) *Сделать задание, только вывод организовать в центре экрана.
        в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

     */
    class Program
    {
        static void Main(string[] args)
        {
            string lineToPrint = "Тананыкин Алекс, г. Чехов";
            Console.WriteLine("а)" + lineToPrint);

            PrintLineOnCenter("б)в)" + lineToPrint);

            Console.ReadKey();
        }

        static void PrintLineOnCenter(string lineToPrint)
        {
            int linePos;
            if (Console.WindowWidth < lineToPrint.Length)
                linePos = 0;
            else
                linePos = (Console.WindowWidth - lineToPrint.Length) / 2;
           
            Print(lineToPrint, linePos, Console.WindowHeight / 2);
        }

        static void Print(string lineToPrint, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(lineToPrint);
        }

    }
}
