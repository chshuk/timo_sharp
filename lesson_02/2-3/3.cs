// Задача 3: Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 10 || n > 99)
    Console.WriteLine("введите правильное число");
else 
    {int num1 = n / 10;
     int num2 = n % 10;
     if (num1 > num2)
        Console.WriteLine(num1);
     else 
        Console.WriteLine(num2);
    }