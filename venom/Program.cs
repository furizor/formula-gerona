using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace venom
{
    internal class Program
    {
        class Triangle
        {
            private double storonaA;
            private double storonaB;
            private double storonaC;

            public Triangle(double a, double b, double c)
            {
                if (a <= 0 || b <= 0 || c <= 0)
        {
                    throw new ArgumentException("Длины сторон должны быть положительными ");
                }

                if (a + b <= c || a + c <= b || b + c <= a)
        {
                    throw new ArgumentException("Сумма любых двух сторон должна быть больше третьей стороны.");
                }

                storonaA = a;
                storonaB = b;
                storonaC = c;
            }

            public double Calculator()
            {
                
                double p = (storonaA + storonaB + storonaC) / 2; 
                double geron = Math.Sqrt(p * (p - storonaA) * (p - storonaB) * (p - storonaC));
                return geron;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            try
            {
                Console.WriteLine("Введите длины сторон треугольника:");
                Console.Write("Сторона a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Сторона b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Сторона c: ");
                double c = double.Parse(Console.ReadLine());

                Triangle treygol = new Triangle(a, b, c);
                double ploshad = treygol.Calculator();

                Console.WriteLine($"Площадь треугольника: {ploshad}");
            }
            catch 
            {
                Console.WriteLine("Ошибка: Введено неправильнрое значение");
            }
            Console.ReadLine();
        }
    }
}
