using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Тананыкин
     * 
     * а) Написать программу, которая подсчитывает расстояние между точками с 
     * координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+
     * Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата 
     * .2f (с двумя знаками после запятой);
       б) *Выполнить предыдущее задание, оформив вычисления расстояния между 
        точками в виде метода.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки");

            try
            {
                double point1X, point1Y;
                IntakePointCoordinates(out point1X, out point1Y);

                Console.WriteLine("Введите координаты второй точки");
                double point2X, point2Y;
                IntakePointCoordinates(out point2X, out point2Y);

                double distance = Math.Sqrt(Math.Pow(point2X - point1X, 2) +
                    Math.Pow(point2Y - point1Y, 2));

                Console.WriteLine(
                    "а )Расстояние между точками равно: {0:F2}", distance);

                Console.WriteLine(
                    "б )Расстояние между точками равно: {0:F2}", 
                    ProcessDistance(point1X, point1Y, point2X, point2Y));
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            Console.WriteLine(
                    "\nДля завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }

        private static double ProcessDistance(double point1X, double point1Y, 
            double point2X, double point2Y)
        {
            return Math.Sqrt(Math.Pow(point2X - point1X, 2) +
                    Math.Pow(point2Y - point1Y, 2));
        }

        static void IntakePointCoordinates(out double x, out double y)
        {
            Console.Write("\nX: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
