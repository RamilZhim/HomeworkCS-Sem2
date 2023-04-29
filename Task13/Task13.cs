﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next();
Console.WriteLine($"Cлучайное число: {number}");

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (number > 999)
        number = number / 10;
    Console.WriteLine($"Третья цифра случайного числа: {number % 10}");
}
