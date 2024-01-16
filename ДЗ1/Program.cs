using System;

class Program
{
    static void Main()
    {
        // Ввод числа с клавиатуры
        Console.Write("Введите число: ");
        int userNumber = int.Parse(Console.ReadLine());

        // Проверка кратности 7 и 23
        if (CheckDivisibility(userNumber))
        {
            Console.WriteLine($"{userNumber} кратно и 7, и 23.");
        }
        else
        {
            Console.WriteLine($"{userNumber} не кратно одновременно 7 и 23.");
        }
    }

    static bool CheckDivisibility(int number)
    {
        // Проверка кратности 7 и 23
        if (number % 7 == 0 && number % 23 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


