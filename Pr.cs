using System;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            string radiusInput = Console.ReadLine();

            if (double.TryParse(radiusInput, out double radius))
            {
                if (radius >= 0)
                {
                    double area = Math.PI * radius * radius;

                    Console.WriteLine("Площадь круга с радиусом " + radius + " равна: " + area);
                }
                else
                {
                    Console.WriteLine("Радиус не может быть отрицательным.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            Console.ReadKey();
        }
    }
}
