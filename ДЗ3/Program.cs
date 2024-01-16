using System;

class Program
{
    static void Main()
    {
        // Ввод целого числа из отрезка [10, 99]
        Console.Write("Введите целое число от 10 до 99: ");
        int number = int.Parse(Console.ReadLine());

        // Проверка, что число находится в заданном диапазоне
        if (number >= 10 && number <= 99)
        {
            // Определение наибольшей цифры
            int maxDigit = FindMaxDigit(number);

            // Вывод результата
            Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}.");
        }
        else
        {
            Console.WriteLine("Введенное число не находится в диапазоне [10, 99].");
        }
    }

    static int FindMaxDigit(int number)
    {
        // Извлечение десятков и единиц
        int tens = number / 10;
        int units = number % 10;

        // Определение наибольшей цифры
        return Math.Max(tens, units);
    }
}
