﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//===============НАЧАЛО===============
System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    System.Console.WriteLine("Не трехзначное число");
    return;
}
{
    while (number > 100) number /= 10;
    int number2 = number % 10;
    System.Console.WriteLine($"{number2}");
}
// ================КОНЕЦ===============