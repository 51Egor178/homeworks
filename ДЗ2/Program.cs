using System;

class Program
{
    static void Main()
    {
        // Ввод координат точки с клавиатуры
        Console.Write("Введите координату X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        // Проверка на то, что X и Y не равны нулю
        if (x != 0 && y != 0)
        {
            // Определение номера координатной четверти
            int quadrant = DetermineQuadrant(x, y);

            // Вывод результата
            Console.WriteLine($"Точка ({x}, {y}) находится в {quadrant}-й координатной четверти.");
        }
        else
        {
            Console.WriteLine("Координаты не могут быть равны нулю.");
        }
    }

    static int DetermineQuadrant(double x, double y)
    {
        // Определение номера координатной четверти
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
}
