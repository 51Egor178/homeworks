using System;

class Program
{
    static void Main()
    {
        // Ввод натурального числа
        Console.Write("Введите натуральное число N: ");
        int n = int.Parse(Console.ReadLine());

        // Проверка, что число положительное
        if (n > 0)
        {
            // Вывод цифр числа через запятую
            Console.Write("Цифры числа через запятую: ");
            DisplayDigitsSeparatedByComma(n);
        }
        else
        {
            Console.WriteLine("Введенное число не является натуральным.");
        }
    }

    static void DisplayDigitsSeparatedByComma(int number)
    {
        // Преобразование числа в строку для перебора цифр
        string numberStr = number.ToString();

        // Вывод цифр через запятую
        for (int i = 0; i < numberStr.Length; i++)
        {
            Console.Write(numberStr[i]);

            // Вывод запятой, если не последняя цифра
            if (i < numberStr.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}
