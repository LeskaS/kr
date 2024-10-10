using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: "); 
        int num = int.Parse(Console.ReadLine());
        if (num < 100 || num > 999) 
        {
            Console.WriteLine("Ошибка");
            Console.ReadKey();
            return;
        }
        int a = num % 10; // Единицы
        int b = (num / 10) % 10; // Десятки
        int c = num / 100; // Сотни
        int sum = a + b + c; 
        int pr = a * b * c;
        Console.WriteLine($"Число единиц: {a}");
        Console.WriteLine($"Число десятков: {b}");
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {pr}");
        Console.ReadKey();
    }
}

