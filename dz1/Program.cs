﻿// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Проверяем явлется ли первое число квадратом второго ");

if (b*b==a)
{
     Console.WriteLine("Первое число явлется квадратом второго ");
}

else
{
    Console.WriteLine("Первое число не явлется квадратом второго ");
}



 

