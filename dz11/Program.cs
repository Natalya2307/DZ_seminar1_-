﻿// Задача 3. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("введите число");
int N = int.Parse(Console.ReadLine()!);

int N1 = (N) * (-1);

while (N1 <= N)
{
    Console.WriteLine (N1);
}
N1 = N1 + 1;


