// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
int count = 2;
if (N < 2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("В заданном диапазоне отсутствуют четные числа. Введите число больше 1");
}
while (count < N)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}
if (count == N)
{
    Console.Write($"{count}");
}