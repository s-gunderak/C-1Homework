﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите число 1:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write($"max = {a}");
}
else
{
    Console.Write($"max = {b}");
}