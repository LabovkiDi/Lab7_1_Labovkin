using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стороны 1-го треугольника:");

            double S1, S2;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a < b + c) || (b < c + a) || (c < a + b)) /*условие что сумму 2-ух сторон всегда больше 1ой*/
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }

            GeronParam(a, b, c, out double S); /*вызов метода*/
            S1 = S;

            Console.WriteLine("Площадь треугольника равна = {0:f2}", S1);
            Console.WriteLine();
            Console.WriteLine("Введите значения сторон 2-го треугольника:");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if ((a < b + c) || (b < c + a) || (c < a + b))
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }

            GeronParam(a, b, c, out S);
            S2 = S;

            Console.WriteLine("Площадь треугольника равна = {0:f2}", S2);

            if (S1 > S2)
            {
                Console.WriteLine("Площадь 1-го треугольника больше");
            }
            else if (S1 < S2)
            {
                Console.WriteLine("Площадь 2-го треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }

            Console.ReadKey();

        }

        static void GeronParam(int x, int y, int z, out double S)
        {
            double p = (x + y + z) / 2.0f;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

    }
}