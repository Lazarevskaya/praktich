using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("=== КАЛЬКУЛЯТОР ===");

        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");
        Console.WriteLine("4 - Деление");

        Console.Write("Ваш выбор: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Результат: " + (a + b));
        }
        else if (choice == 2)
        {
            Console.WriteLine("Результат: " + (a - b));
        }
        else if (choice == 3)
        {
            Console.WriteLine("Результат: " + (a * b));
        }
        else if (choice == 4)
        {
            if (b != 0)
            {
                Console.WriteLine("Результат: " + (a / b));
            }
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор операции!");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}