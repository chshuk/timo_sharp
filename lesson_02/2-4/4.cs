﻿// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

while (n > 0)
{
    Console.Write(n % 10 + ", ");
    n = n / 10;
}