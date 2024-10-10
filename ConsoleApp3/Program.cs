using System;

class Program
{
    static void Main()
    {
   
        Console.Write("Введите трехзначное число: "); // Ввод трехзначного числа
        int num = int.Parse(Console.ReadLine());

        
        if (num < 100 || num > 999) // Проверка
        {
            Console.WriteLine("Ошибка");
            Console.ReadKey();
            return;
        }

  
        int a = num % 10; // Единицы
        int b = (num / 10) % 10; // Десятки
        int c = num / 100; // Сотни

        
        int sum = a + b + c; // Сумма цифр

        
        int pr = a * b * c;// Произведение цифр

        // Вывод результатов
        Console.WriteLine($"Число единиц: {a}");
        Console.WriteLine($"Число десятков: {b}");
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {pr}");
        Console.WriteLine($"Произведение цифр: {pr}");
        Console.ReadKey();
    }
}