﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    Console.WriteLine("Число отрицательно преобразовано в положительное");
    num = -num;
}
for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }